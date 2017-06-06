namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class acd : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DataElement", "DataSetSectionElement_DSSEId", "dbo.DataSetSectionElement");
            DropIndex("dbo.DataElement", new[] { "DataSetSectionElement_DSSEId" });
            AddColumn("dbo.DataSetSectionElement", "DataElement_DEID", c => c.Int());
            CreateIndex("dbo.DataSetSectionElement", "DataElement_DEID");
            AddForeignKey("dbo.DataSetSectionElement", "DataElement_DEID", "dbo.DataElement", "DEID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DataSetSectionElement", "DataElement_DEID", "dbo.DataElement");
            DropIndex("dbo.DataSetSectionElement", new[] { "DataElement_DEID" });
            DropColumn("dbo.DataSetSectionElement", "DataElement_DEID");
            CreateIndex("dbo.DataElement", "DataSetSectionElement_DSSEId");
            AddForeignKey("dbo.DataElement", "DataSetSectionElement_DSSEId", "dbo.DataSetSectionElement", "DSSEId");
        }
    }
}
