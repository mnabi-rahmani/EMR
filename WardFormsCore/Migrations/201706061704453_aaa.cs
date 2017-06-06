namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DataSetSectionElement", "DataElement_DEID", "dbo.DataElement");
            DropForeignKey("dbo.DataSetSectionElement", "DataElement_DEID1", "dbo.DataElement");
            DropIndex("dbo.DataSetSectionElement", new[] { "DataElement_DEID" });
            DropIndex("dbo.DataSetSectionElement", new[] { "DataElement_DEID1" });
            DropColumn("dbo.DataSetSectionElement", "FKDSSEDataElementID");
            DropColumn("dbo.DataSetSectionElement", "DataElement_DEID");
            DropColumn("dbo.DataSetSectionElement", "DataElement_DEID1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DataSetSectionElement", "DataElement_DEID1", c => c.Int());
            AddColumn("dbo.DataSetSectionElement", "DataElement_DEID", c => c.Int());
            AddColumn("dbo.DataSetSectionElement", "FKDSSEDataElementID", c => c.Int());
            CreateIndex("dbo.DataSetSectionElement", "DataElement_DEID1");
            CreateIndex("dbo.DataSetSectionElement", "DataElement_DEID");
            AddForeignKey("dbo.DataSetSectionElement", "DataElement_DEID1", "dbo.DataElement", "DEID");
            AddForeignKey("dbo.DataSetSectionElement", "DataElement_DEID", "dbo.DataElement", "DEID");
        }
    }
}
