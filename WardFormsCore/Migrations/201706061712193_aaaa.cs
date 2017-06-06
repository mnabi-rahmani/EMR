namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataSetSectionElement", "FKDSSEDataelementID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DataSetSectionElement", "FKDSSEDataelementID");
        }
    }
}
