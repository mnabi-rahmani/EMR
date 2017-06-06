namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataSetSectionElement", "DEID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DataSetSectionElement", "DEID");
        }
    }
}
