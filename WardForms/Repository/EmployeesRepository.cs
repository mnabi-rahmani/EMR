using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using WardForms.Models;

namespace WardForms.Repository
{
    public class EmployeesRepository : Repository<Employee>
    {

        ApplicationDbContext ApplicationDbContext = new ApplicationDbContext();
        public EmployeesRepository(ApplicationDbContext _ApplicationDbContext) : base(_ApplicationDbContext)
        {
            ApplicationDbContext = _ApplicationDbContext;
        }

        public void AddEmployee(EmployeeViewModel employeeViewModel)
        {
            //Add Person First
            Person newperson = new Person();
            newperson.FirstName = employeeViewModel.FirstName;
            newperson.MiddleName = employeeViewModel.MiddleName;
            newperson.LastName = employeeViewModel.LastName;
            newperson.FatherName = employeeViewModel.FatherName;
            newperson.Gender = employeeViewModel.Gender;
            newperson.MaritalStatus = employeeViewModel.MaritalStatus;
            newperson.DateOfBirth = employeeViewModel.DateOfBirth;
            newperson.BloodGroup = employeeViewModel.BloodGroup;
            newperson.TazkiraNumber = employeeViewModel.TazkiraNumber;
            newperson.PassportNumber = employeeViewModel.PassportNumber;
            ApplicationDbContext.Persons.Add(newperson);
            ApplicationDbContext.SaveChanges();
            int personid = newperson.PersonID;

            //Add Employee by getting ID from newly created Person
            Employee newemployee = new Employee();
            newemployee.Person = newperson;
            newemployee.EmployeeType = employeeViewModel.EmployeeType;
            ApplicationDbContext.Employees.Add(newemployee);
            ApplicationDbContext.SaveChanges();


        }

        public List<EmployeeViewModel> GetAllEmployees()
        {
            using (ApplicationDbContext appcontext = new ApplicationDbContext())
            {
                List<EmployeeViewModel> employeeslist = new List<EmployeeViewModel>();

                var list = appcontext.Employees
                    .Include(a => a.Person)
                    .ToList();

                foreach (var item in list)
                {
                    EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                    employeeViewModel.FirstName = item.Person.FirstName;
                    employeeViewModel.MiddleName = item.Person.MiddleName;
                    employeeViewModel.LastName = item.Person.LastName;
                    employeeViewModel.FatherName = item.Person.FatherName;
                    employeeViewModel.Gender = item.Person.Gender;
                    employeeViewModel.MaritalStatus = item.Person.MaritalStatus;
                    employeeViewModel.DateOfBirth = item.Person.DateOfBirth;
                    employeeViewModel.BloodGroup = item.Person.BloodGroup;
                    employeeViewModel.TazkiraNumber = item.Person.TazkiraNumber;
                    employeeViewModel.PassportNumber = item.Person.PassportNumber;
                    employeeViewModel.PersonID = item.Person.PersonID;
                    employeeViewModel.EmployeeID = item.EmployeeID;
                    employeeViewModel.EmployeeType = item.EmployeeType;
                    employeeslist.Add(employeeViewModel);

                }

                return employeeslist;
            }
        }
        public EmployeeViewModel GetEmployee(int? id)
        {

            using (ApplicationDbContext appcontext = new ApplicationDbContext())
            { 
                EmployeeViewModel employee = new EmployeeViewModel();

            var list = appcontext.Employees
               .Include(a => a.Person)
               .Where(b=>b.EmployeeID==id)
               .ToList();

            foreach (var item in list)
            {
                EmployeeViewModel employeeViewModel = new EmployeeViewModel();
                employeeViewModel.FirstName = item.Person.FirstName;
                employeeViewModel.MiddleName = item.Person.MiddleName;
                employeeViewModel.LastName = item.Person.LastName;
                employeeViewModel.FatherName = item.Person.FatherName;
                employeeViewModel.Gender = item.Person.Gender;
                employeeViewModel.MaritalStatus = item.Person.MaritalStatus;
                employeeViewModel.DateOfBirth = item.Person.DateOfBirth;
                employeeViewModel.BloodGroup = item.Person.BloodGroup;
                employeeViewModel.TazkiraNumber = item.Person.TazkiraNumber;
                employeeViewModel.PassportNumber = item.Person.PassportNumber;

                employeeViewModel.EmployeeID = item.EmployeeID;
                employeeViewModel.EmployeeType = item.EmployeeType;
                employee=employeeViewModel;

            }
           
            return employee;
            }
        }
        

             public void UpdateEmployee(EmployeeViewModel employeeViewModel)
        {
            //Add Person First
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                context.Persons

            }
                newperson.FirstName = employeeViewModel.FirstName;
            newperson.MiddleName = employeeViewModel.MiddleName;
            newperson.LastName = employeeViewModel.LastName;
            newperson.FatherName = employeeViewModel.FatherName;
            newperson.Gender = employeeViewModel.Gender;
            newperson.MaritalStatus = employeeViewModel.MaritalStatus;
            newperson.DateOfBirth = employeeViewModel.DateOfBirth;
            newperson.BloodGroup = employeeViewModel.BloodGroup;
            newperson.TazkiraNumber = employeeViewModel.TazkiraNumber;
            newperson.PassportNumber = employeeViewModel.PassportNumber;
            ApplicationDbContext.Persons.Add(newperson);
            ApplicationDbContext.SaveChanges();
            int personid = newperson.PersonID;

            //Add Employee by getting ID from newly created Person
            Employee newemployee = new Employee();
            newemployee.Person = newperson;
            newemployee.EmployeeType = employeeViewModel.EmployeeType;
            ApplicationDbContext.Employees.Add(newemployee);
            ApplicationDbContext.SaveChanges();


        }






    }
}
