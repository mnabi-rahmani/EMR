namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DataElement", "FKDEDataSetSectionElementID", "dbo.DataSetSectionElement");
            DropIndex("dbo.DataElement", new[] { "FKDEDataSetSectionElementID" });
            AddColumn("dbo.DataElement", "DataSetSectionElement_DSSEId", c => c.Int());
            AddColumn("dbo.DataSetSectionElement", "FKDSSEDataElementID", c => c.Int());
            AddColumn("dbo.DataSetSectionElement", "DataElement_DEID", c => c.Int());
            AddColumn("dbo.DataSetSectionElement", "DataElement_DEID1", c => c.Int());
            CreateIndex("dbo.DataElement", "DataSetSectionElement_DSSEId");
            CreateIndex("dbo.DataSetSectionElement", "DataElement_DEID");
            CreateIndex("dbo.DataSetSectionElement", "DataElement_DEID1");
            AddForeignKey("dbo.DataSetSectionElement", "DataElement_DEID", "dbo.DataElement", "DEID");
            AddForeignKey("dbo.DataSetSectionElement", "DataElement_DEID1", "dbo.DataElement", "DEID");
            AddForeignKey("dbo.DataElement", "DataSetSectionElement_DSSEId", "dbo.DataSetSectionElement", "DSSEId");
            DropColumn("dbo.DataSetSectionElement", "DEID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DataSetSectionElement", "DEID", c => c.Int());
            DropForeignKey("dbo.DataElement", "DataSetSectionElement_DSSEId", "dbo.DataSetSectionElement");
            DropForeignKey("dbo.DataSetSectionElement", "DataElement_DEID1", "dbo.DataElement");
            DropForeignKey("dbo.DataSetSectionElement", "DataElement_DEID", "dbo.DataElement");
            DropIndex("dbo.DataSetSectionElement", new[] { "DataElement_DEID1" });
            DropIndex("dbo.DataSetSectionElement", new[] { "DataElement_DEID" });
            DropIndex("dbo.DataElement", new[] { "DataSetSectionElement_DSSEId" });
            DropColumn("dbo.DataSetSectionElement", "DataElement_DEID1");
            DropColumn("dbo.DataSetSectionElement", "DataElement_DEID");
            DropColumn("dbo.DataSetSectionElement", "FKDSSEDataElementID");
            DropColumn("dbo.DataElement", "DataSetSectionElement_DSSEId");
            CreateIndex("dbo.DataElement", "FKDEDataSetSectionElementID");
            AddForeignKey("dbo.DataElement", "FKDEDataSetSectionElementID", "dbo.DataSetSectionElement", "DSSEId", cascadeDelete: true);
        }
    }
}
