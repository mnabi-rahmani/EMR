using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using WardForms.Models;


namespace WardForms.Repository
{
    public class PatientsRepository : Repository<Employee>
    {
        
            ApplicationDbContext Context = new ApplicationDbContext();
            public PatientsRepository()
            {

            }

            public void AddPatient(PatientViewModel PatientViewModel)
            {
                //Add Person First
                Person newperson = new Person();
                newperson.FirstName = PatientViewModel.FirstName;
                newperson.MiddleName = PatientViewModel.MiddleName;
                newperson.LastName = PatientViewModel.LastName;
                newperson.FatherName = PatientViewModel.FatherName;
                newperson.Gender = PatientViewModel.Gender;
                newperson.MaritalStatus = PatientViewModel.MaritalStatus;
                newperson.DateOfBirth = PatientViewModel.DateOfBirth;
                newperson.BloodGroup = PatientViewModel.BloodGroup;
                newperson.TazkiraNumber = PatientViewModel.TazkiraNumber;
                newperson.PassportNumber = PatientViewModel.PassportNumber;
                Context.Persons.Add(newperson);
                Context.SaveChanges();
                int personid = newperson.PersonID;

                //Add Patient by getting ID from newly created Person
                Patient newpatient= new Patient();
                newpatient.Person = newperson;
                newpatient.PatientType = PatientViewModel.PatientType;
                Context.Patients.Add(newpatient);
                Context.SaveChanges();


            }

            public List<PatientViewModel> GetAllPatients()
            {
                // using (ApplicationDbContext appcontext = new ApplicationDbContext())
                //   {
                List<PatientViewModel> Patientslist = new List<PatientViewModel>();

                var list = Context.Patients
                    .Include(a => a.Person)
                    .ToList();

                foreach (var item in list)
                {
                    PatientViewModel patientViewModel = new PatientViewModel();
                patientViewModel.FirstName = item.Person.FirstName;
                patientViewModel.MiddleName = item.Person.MiddleName;
                patientViewModel.LastName = item.Person.LastName;
                patientViewModel.FatherName = item.Person.FatherName;
                patientViewModel.Gender = item.Person.Gender;
                patientViewModel.MaritalStatus = item.Person.MaritalStatus;
                patientViewModel.DateOfBirth = item.Person.DateOfBirth;
                patientViewModel.BloodGroup = item.Person.BloodGroup;
                patientViewModel.TazkiraNumber = item.Person.TazkiraNumber;
                patientViewModel.PassportNumber = item.Person.PassportNumber;
                patientViewModel.PersonID = item.Person.PersonID;
                patientViewModel.PatientID = item.PatientID;
                patientViewModel.PatientType = item.PatientType;
                Patientslist.Add(patientViewModel);

                }

                return Patientslist;
            }


            public PatientViewModel GetPatient(int? id)
            {
           PatientViewModel patient = new PatientViewModel();

            var list = Context.Patients
                .Include(a => a.Person)
                .ToList();
            PatientViewModel patientViewModel = new PatientViewModel();
            foreach (var item in list)
            {
             
                patientViewModel.FirstName = item.Person.FirstName;
                patientViewModel.MiddleName = item.Person.MiddleName;
                patientViewModel.LastName = item.Person.LastName;
                patientViewModel.FatherName = item.Person.FatherName;
                patientViewModel.Gender = item.Person.Gender;
                patientViewModel.MaritalStatus = item.Person.MaritalStatus;
                patientViewModel.DateOfBirth = item.Person.DateOfBirth;
                patientViewModel.BloodGroup = item.Person.BloodGroup;
                patientViewModel.TazkiraNumber = item.Person.TazkiraNumber;
                patientViewModel.PassportNumber = item.Person.PassportNumber;
                patientViewModel.PersonID = item.Person.PersonID;
                patientViewModel.PatientID = item.PatientID;
                patientViewModel.PatientType = item.PatientType;
                

            }

            return patientViewModel;

        }


            public void UpdatePatient(PatientViewModel PatientViewModel)
            {
                //Add Person First


                var newperson = Context.Persons.Find(PatientViewModel.PersonID);
                newperson.FirstName = PatientViewModel.FirstName;
                newperson.MiddleName = PatientViewModel.MiddleName;
                newperson.LastName = PatientViewModel.LastName;
                newperson.FatherName = PatientViewModel.FatherName;
                newperson.Gender = PatientViewModel.Gender;
                newperson.MaritalStatus = PatientViewModel.MaritalStatus;
                newperson.DateOfBirth = PatientViewModel.DateOfBirth;
                newperson.BloodGroup = PatientViewModel.BloodGroup;
                newperson.TazkiraNumber = PatientViewModel.TazkiraNumber;
                newperson.PassportNumber = PatientViewModel.PassportNumber;


                var newpatient = Context.Patients.Find(PatientViewModel.PatientID);

                   newpatient.PatientType = PatientViewModel.PatientType;

                Context.SaveChanges();

            }
            public void RemovePatient(int id)
            {
                var list = Context.Patients
                   .Include(a => a.Person)
                   .Where(b => b.PatientID == id)
                   .ToList();

                foreach (var item in list)
                {
                    Patient patient= Context.Patients.Find(item.PatientID);
                    Person person = Context.Persons.Find(item.Person.PersonID);

                    //    var entry = Context.Entry(employee);
                    //   if (entry.State == EntityState.Detached)
                    //     Context.Employees.Attach(employee);
                    Context.Patients.Remove(patient);




                    if (person.PersonID != 0)
                    {
                        // var Personentry = Context.Entry(person);
                        //   if (Personentry.State == EntityState.Detached)
                        //       Context.Persons.Attach(person);
                        Context.Persons.Remove(person);
                    }



                    Context.SaveChanges();

                }


            }




        }
    }







