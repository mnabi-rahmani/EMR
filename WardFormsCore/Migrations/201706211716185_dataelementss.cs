namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataelementss : DbMigration
    {
        public override void Up()
        {
           // AddColumn("dbo.AllElements", "ElementType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
         //   DropColumn("dbo.AllElements", "ElementType");
        }
    }
}
