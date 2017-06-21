namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataelement : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataElement", "ElementType", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DataElement", "ElementType");
        }
    }
}
