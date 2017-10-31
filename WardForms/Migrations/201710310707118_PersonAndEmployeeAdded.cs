namespace WardForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonAndEmployeeAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeType = c.Int(nullable: false),
                        Person_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Person", t => t.Person_PersonID)
                .Index(t => t.Person_PersonID);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 350),
                        MiddleName = c.String(maxLength: 350),
                        LastName = c.String(maxLength: 350),
                        FatherName = c.String(maxLength: 350),
                        Gender = c.Int(),
                        MaritalStatus = c.Int(),
                        DateOfBirth = c.DateTime(),
                        BloodGroup = c.Int(),
                        TazkiraNumber = c.String(maxLength: 60),
                        PassportNumber = c.String(maxLength: 60),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Person_PersonID", "dbo.Person");
            DropIndex("dbo.Employees", new[] { "Person_PersonID" });
            DropTable("dbo.Person");
            DropTable("dbo.Employees");
        }
    }
}
