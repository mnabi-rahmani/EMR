namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataelements : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DataElement", "ElementType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.DataElement", "ElementType", c => c.String(maxLength: 150));
        }
    }
}
