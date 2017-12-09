namespace WardForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FacilityandRelatedEntitiesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.District",
                c => new
                    {
                        DistrictCode = c.Int(nullable: false, identity: true),
                        District = c.String(maxLength: 250),
                        DistrictLocal = c.String(maxLength: 350),
                        ProvinceCode = c.Int(),
                    })
                .PrimaryKey(t => t.DistrictCode)
                .ForeignKey("dbo.Province", t => t.ProvinceCode)
                .Index(t => t.ProvinceCode);
            
            CreateTable(
                "dbo.Facility",
                c => new
                    {
                        FID = c.Int(nullable: false),
                        FKFFacilityTypeID = c.Int(nullable: false),
                        FacilityName = c.String(maxLength: 255),
                        FacilityNameLocal = c.String(maxLength: 350),
                        FacilityDescription = c.String(maxLength: 500),
                        EstablishmentDate = c.DateTime(),
                        FKFDisctictCode = c.Int(),
                        FKFProvinceCode = c.Int(),
                        District_DistrictCode = c.Int(),
                        FacilityType_FacilityTypeID = c.Int(),
                        Province_ProvinceCode = c.Int(),
                    })
                .PrimaryKey(t => t.FID)
                .ForeignKey("dbo.District", t => t.District_DistrictCode)
                .ForeignKey("dbo.FacilityType", t => t.FacilityType_FacilityTypeID)
                .ForeignKey("dbo.Province", t => t.Province_ProvinceCode)
                .Index(t => t.District_DistrictCode)
                .Index(t => t.FacilityType_FacilityTypeID)
                .Index(t => t.Province_ProvinceCode);
            
            CreateTable(
                "dbo.FacilityContactMechanisim",
                c => new
                    {
                        FMID = c.Int(nullable: false, identity: true),
                        FKFCMFacilityID = c.Int(),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        Facility_FID = c.Int(),
                    })
                .PrimaryKey(t => t.FMID)
                .ForeignKey("dbo.Facility", t => t.Facility_FID)
                .Index(t => t.Facility_FID);
            
            CreateTable(
                "dbo.FacilityContactMechanisimPurpose",
                c => new
                    {
                        FCMPID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        ContactPurposeType = c.String(maxLength: 355),
                        FKFCMPFCMID = c.Int(),
                        FacilityContactMechanisim_FMID = c.Int(),
                    })
                .PrimaryKey(t => t.FCMPID)
                .ForeignKey("dbo.FacilityContactMechanisim", t => t.FacilityContactMechanisim_FMID)
                .Index(t => t.FacilityContactMechanisim_FMID);
            
            CreateTable(
                "dbo.FacilityContent",
                c => new
                    {
                        FCID = c.Int(nullable: false, identity: true),
                        FacilityContent = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKFCFacilityID = c.Int(),
                        Facility_FID = c.Int(),
                    })
                .PrimaryKey(t => t.FCID)
                .ForeignKey("dbo.Facility", t => t.Facility_FID)
                .Index(t => t.Facility_FID);
            
            CreateTable(
                "dbo.FacilityGroup",
                c => new
                    {
                        FGID = c.Int(nullable: false, identity: true),
                        FKFGFacilityGroupTypeID = c.Int(),
                        FacilityGroup = c.String(maxLength: 250),
                        FacilityGroupLocal = c.String(maxLength: 350),
                        FKFGFacilityID = c.Int(),
                        Facility_FID = c.Int(),
                        FacilityGroupType_FGTID = c.Int(),
                    })
                .PrimaryKey(t => t.FGID)
                .ForeignKey("dbo.Facility", t => t.Facility_FID)
                .ForeignKey("dbo.FacilityGroupType", t => t.FacilityGroupType_FGTID)
                .Index(t => t.Facility_FID)
                .Index(t => t.FacilityGroupType_FGTID);
            
            CreateTable(
                "dbo.FacilityGroupMember",
                c => new
                    {
                        FGMID = c.Int(nullable: false, identity: true),
                        FKFGMFacilityGroupID = c.Int(),
                        FacilityGroupMemberDescription = c.String(maxLength: 500),
                        FromDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKFGMFacilityID = c.Int(),
                        FacilityGroup_FGID = c.Int(),
                    })
                .PrimaryKey(t => t.FGMID)
                .ForeignKey("dbo.FacilityGroup", t => t.FacilityGroup_FGID)
                .Index(t => t.FacilityGroup_FGID);
            
            CreateTable(
                "dbo.FacilityGroupRole",
                c => new
                    {
                        FGRId = c.Int(nullable: false, identity: true),
                        FKFGRFacilityGroupID = c.Int(),
                        FKFGRFacilityPartyID = c.Int(),
                        FKFGRRoleTypeID = c.Int(),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FacilityGroup_FGID = c.Int(),
                    })
                .PrimaryKey(t => t.FGRId)
                .ForeignKey("dbo.FacilityGroup", t => t.FacilityGroup_FGID)
                .Index(t => t.FacilityGroup_FGID);
            
            CreateTable(
                "dbo.FacilityGroupType",
                c => new
                    {
                        FGTID = c.Int(nullable: false, identity: true),
                        FacilityGroupType = c.String(nullable: false, maxLength: 250),
                        FacilityGroupTypeLocal = c.String(maxLength: 350),
                        FacilityGroupTypeDescription = c.String(maxLength: 500),
                        FKFGTFacilityID = c.Int(),
                    })
                .PrimaryKey(t => t.FGTID);
            
            CreateTable(
                "dbo.FacilityLocationGeoPiont",
                c => new
                    {
                        FLGeoPID = c.Int(nullable: false, identity: true),
                        Lat = c.String(maxLength: 50),
                        Lan = c.String(maxLength: 50),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        Status = c.Int(),
                        FKFLGPFacilityID = c.Int(),
                        FacilityGeoPiontDescription = c.String(maxLength: 500),
                        Facility_FID = c.Int(),
                    })
                .PrimaryKey(t => t.FLGeoPID)
                .ForeignKey("dbo.Facility", t => t.Facility_FID)
                .Index(t => t.Facility_FID);
            
            CreateTable(
                "dbo.FacilityParty",
                c => new
                    {
                        FPID = c.Int(nullable: false, identity: true),
                        FKFPFacilityID = c.Int(),
                        FKFPPartyID = c.Int(),
                        FKFPRoleTypeID = c.Int(),
                        FromDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        Facility_FID = c.Int(),
                    })
                .PrimaryKey(t => t.FPID)
                .ForeignKey("dbo.Facility", t => t.Facility_FID)
                .Index(t => t.Facility_FID);
            
            CreateTable(
                "dbo.FacilityRole",
                c => new
                    {
                        FacilityRoleID = c.Int(nullable: false, identity: true),
                        FKFRFacilityID = c.Int(),
                        FKFRPartyID = c.Int(),
                        FKFRRoleTypeID = c.Int(),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        Facility_FID = c.Int(),
                    })
                .PrimaryKey(t => t.FacilityRoleID)
                .ForeignKey("dbo.Facility", t => t.Facility_FID)
                .Index(t => t.Facility_FID);
            
            CreateTable(
                "dbo.FacilityType",
                c => new
                    {
                        FacilityTypeID = c.Int(nullable: false, identity: true),
                        FacilityType = c.String(maxLength: 350),
                        FacilityTypeLocal = c.String(maxLength: 350),
                        FacilityTypeDescription = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.FacilityTypeID);
            
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        ProvinceCode = c.Int(nullable: false, identity: true),
                        Province = c.String(maxLength: 350),
                        ProvinceLocal = c.String(maxLength: 350),
                    })
                .PrimaryKey(t => t.ProvinceCode);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facility", "Province_ProvinceCode", "dbo.Province");
            DropForeignKey("dbo.District", "ProvinceCode", "dbo.Province");
            DropForeignKey("dbo.Facility", "FacilityType_FacilityTypeID", "dbo.FacilityType");
            DropForeignKey("dbo.FacilityRole", "Facility_FID", "dbo.Facility");
            DropForeignKey("dbo.FacilityParty", "Facility_FID", "dbo.Facility");
            DropForeignKey("dbo.FacilityLocationGeoPiont", "Facility_FID", "dbo.Facility");
            DropForeignKey("dbo.FacilityGroup", "FacilityGroupType_FGTID", "dbo.FacilityGroupType");
            DropForeignKey("dbo.FacilityGroupRole", "FacilityGroup_FGID", "dbo.FacilityGroup");
            DropForeignKey("dbo.FacilityGroupMember", "FacilityGroup_FGID", "dbo.FacilityGroup");
            DropForeignKey("dbo.FacilityGroup", "Facility_FID", "dbo.Facility");
            DropForeignKey("dbo.FacilityContent", "Facility_FID", "dbo.Facility");
            DropForeignKey("dbo.FacilityContactMechanisimPurpose", "FacilityContactMechanisim_FMID", "dbo.FacilityContactMechanisim");
            DropForeignKey("dbo.FacilityContactMechanisim", "Facility_FID", "dbo.Facility");
            DropForeignKey("dbo.Facility", "District_DistrictCode", "dbo.District");
            DropIndex("dbo.FacilityRole", new[] { "Facility_FID" });
            DropIndex("dbo.FacilityParty", new[] { "Facility_FID" });
            DropIndex("dbo.FacilityLocationGeoPiont", new[] { "Facility_FID" });
            DropIndex("dbo.FacilityGroupRole", new[] { "FacilityGroup_FGID" });
            DropIndex("dbo.FacilityGroupMember", new[] { "FacilityGroup_FGID" });
            DropIndex("dbo.FacilityGroup", new[] { "FacilityGroupType_FGTID" });
            DropIndex("dbo.FacilityGroup", new[] { "Facility_FID" });
            DropIndex("dbo.FacilityContent", new[] { "Facility_FID" });
            DropIndex("dbo.FacilityContactMechanisimPurpose", new[] { "FacilityContactMechanisim_FMID" });
            DropIndex("dbo.FacilityContactMechanisim", new[] { "Facility_FID" });
            DropIndex("dbo.Facility", new[] { "Province_ProvinceCode" });
            DropIndex("dbo.Facility", new[] { "FacilityType_FacilityTypeID" });
            DropIndex("dbo.Facility", new[] { "District_DistrictCode" });
            DropIndex("dbo.District", new[] { "ProvinceCode" });
            DropTable("dbo.Province");
            DropTable("dbo.FacilityType");
            DropTable("dbo.FacilityRole");
            DropTable("dbo.FacilityParty");
            DropTable("dbo.FacilityLocationGeoPiont");
            DropTable("dbo.FacilityGroupType");
            DropTable("dbo.FacilityGroupRole");
            DropTable("dbo.FacilityGroupMember");
            DropTable("dbo.FacilityGroup");
            DropTable("dbo.FacilityContent");
            DropTable("dbo.FacilityContactMechanisimPurpose");
            DropTable("dbo.FacilityContactMechanisim");
            DropTable("dbo.Facility");
            DropTable("dbo.District");
        }
    }
}
