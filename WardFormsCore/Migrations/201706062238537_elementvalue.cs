namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class elementvalue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ElementValues", "DataElementValue", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ElementValues", "DataElementValue", c => c.Int());
        }
    }
}
