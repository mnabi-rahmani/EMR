namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdfddj : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.AllElements",
            //    c => new
            //        {
            //            DSId = c.Int(nullable: false),
            //            DataSetShortName = c.String(nullable: false, maxLength: 150),
            //            DSSID = c.Int(nullable: false),
            //            DataSetSectionShortName = c.String(nullable: false, maxLength: 150),
            //            DSSEId = c.Int(nullable: false),
            //            DataSetSectionElementShortName = c.String(nullable: false, maxLength: 150),
            //            DEID = c.Int(nullable: false),
            //            DataSetName = c.String(maxLength: 250),
            //            DataSetNamePersian = c.String(maxLength: 350),
            //            DataSetNamePashto = c.String(maxLength: 350),
            //            DataSetFor = c.String(maxLength: 100),
            //            DataSetSectionName = c.String(maxLength: 250),
            //            DataSetNameSectionPersian = c.String(maxLength: 350),
            //            DataSetNameSectionPashto = c.String(maxLength: 350),
            //            FKDSSDataSetID = c.Int(),
            //            DataSetSectionElementName = c.String(maxLength: 250),
            //            DataSetNameSectionElementPersian = c.String(maxLength: 350),
            //            DataSetNameSectionElementPashto = c.String(maxLength: 350),
            //            FKDSSEDataSetSectionID = c.Int(),
            //            FKDSSEDataelementID = c.Int(),
            //            DataElement = c.String(maxLength: 150),
            //            DataElementPersian = c.String(maxLength: 350),
            //            DataElementPashto = c.String(maxLength: 350),
            //            FKDEDataSetClassficationID = c.Int(),
            //            SortOrder = c.Int(),
            //            DataElementStatus = c.Boolean(),
            //        })
            //    .PrimaryKey(t => new { t.DSId, t.DataSetShortName, t.DSSID, t.DataSetSectionShortName, t.DSSEId, t.DataSetSectionElementShortName, t.DEID });
            
            //CreateTable(
            //    "dbo.allelementsv",
            //    c => new
            //        {
            //            DSId = c.Int(nullable: false),
            //            DataSetShortName = c.String(nullable: false, maxLength: 150),
            //            DSSID = c.Int(nullable: false),
            //            DataSetSectionShortName = c.String(nullable: false, maxLength: 150),
            //            DSSEId = c.Int(nullable: false),
            //            DataSetSectionElementShortName = c.String(nullable: false, maxLength: 150),
            //            DEID = c.Int(nullable: false),
            //            DataSetName = c.String(maxLength: 250),
            //            DataSetNamePersian = c.String(maxLength: 350),
            //            DataSetNamePashto = c.String(maxLength: 350),
            //            DataSetFor = c.String(maxLength: 100),
            //            DataSetSectionName = c.String(maxLength: 250),
            //            DataSetNameSectionPersian = c.String(maxLength: 350),
            //            DataSetNameSectionPashto = c.String(maxLength: 350),
            //            FKDSSDataSetID = c.Int(),
            //            DataSetSectionElementName = c.String(maxLength: 250),
            //            DataSetNameSectionElementPersian = c.String(maxLength: 350),
            //            DataSetNameSectionElementPashto = c.String(maxLength: 350),
            //            FKDSSEDataSetSectionID = c.Int(),
            //            FKDSSEDataelementID = c.Int(),
            //            DataElement = c.String(maxLength: 150),
            //            DataElementPersian = c.String(maxLength: 350),
            //            DataElementPashto = c.String(maxLength: 350),
            //            FKDEDataSetClassficationID = c.Int(),
            //            SortOrder = c.Int(),
            //            DataElementStatus = c.Boolean(),
            //        })
            //    .PrimaryKey(t => new { t.DSId, t.DataSetShortName, t.DSSID, t.DataSetSectionShortName, t.DSSEId, t.DataSetSectionElementShortName, t.DEID });
            
        }
        
        public override void Down()
        {
            DropTable("dbo.allelementsv");
            DropTable("dbo.AllElements");
        }
    }
}
