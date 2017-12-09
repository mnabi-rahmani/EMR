namespace WardForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class patientEntityAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientID = c.Int(nullable: false, identity: true),
                        PatientType = c.Int(nullable: false),
                        Person_PersonID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PatientID)
                .ForeignKey("dbo.Person", t => t.Person_PersonID, cascadeDelete: true)
                .Index(t => t.Person_PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "Person_PersonID", "dbo.Person");
            DropIndex("dbo.Patients", new[] { "Person_PersonID" });
            DropTable("dbo.Patients");
        }
    }
}
