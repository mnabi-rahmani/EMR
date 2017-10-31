namespace WardForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonAndEmployeeAddedv1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "Person_PersonID", "dbo.Person");
            DropIndex("dbo.Employees", new[] { "Person_PersonID" });
            AlterColumn("dbo.Employees", "Person_PersonID", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "Person_PersonID");
            AddForeignKey("dbo.Employees", "Person_PersonID", "dbo.Person", "PersonID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Person_PersonID", "dbo.Person");
            DropIndex("dbo.Employees", new[] { "Person_PersonID" });
            AlterColumn("dbo.Employees", "Person_PersonID", c => c.Int());
            CreateIndex("dbo.Employees", "Person_PersonID");
            AddForeignKey("dbo.Employees", "Person_PersonID", "dbo.Person", "PersonID");
        }
    }
}
