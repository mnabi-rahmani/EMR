namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataClassfication",
                c => new
                    {
                        DataClsID = c.Int(nullable: false, identity: true),
                        DataClassfication = c.String(nullable: false, maxLength: 250, unicode: false),
                        DataClassficationPersian = c.String(maxLength: 350),
                        DataClassficationPashto = c.String(maxLength: 350),
                        DataClassficationDescription = c.String(maxLength: 500),
                        DataClassficationStatus = c.Boolean(),
                        DataClassficationFor = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.DataClsID);
            
            CreateTable(
                "dbo.DataElement",
                c => new
                    {
                        DEID = c.Int(nullable: false, identity: true),
                        DataElement = c.String(maxLength: 150, unicode: false),
                        DataElementPersian = c.String(maxLength: 350),
                        DataElementPashto = c.String(maxLength: 350),
                        FKDEDataSetSectionElementID = c.Int(),
                        FKDEDataSetClassficationID = c.Int(),
                        SortOrder = c.Int(),
                        DataElementStatus = c.Boolean(),
                    })
                .PrimaryKey(t => t.DEID)
                .ForeignKey("dbo.DataSetSectionElement", t => t.FKDEDataSetSectionElementID, cascadeDelete: true)
                .ForeignKey("dbo.DataClassfication", t => t.FKDEDataSetClassficationID, cascadeDelete: true)
                .Index(t => t.FKDEDataSetSectionElementID)
                .Index(t => t.FKDEDataSetClassficationID);
            
            CreateTable(
                "dbo.DataSetSectionElement",
                c => new
                    {
                        DSSEId = c.Int(nullable: false, identity: true),
                        DataSetSectionElementShortName = c.String(nullable: false, maxLength: 150, unicode: false),
                        DataSetSectionElementName = c.String(maxLength: 250, unicode: false),
                        DataSetNameSectionElementPersian = c.String(maxLength: 350),
                        DataSetNameSectionElementPashto = c.String(maxLength: 350),
                        FKDSSEDataSetSectionID = c.Int(),
                    })
                .PrimaryKey(t => t.DSSEId)
                .ForeignKey("dbo.DataSetSection", t => t.FKDSSEDataSetSectionID, cascadeDelete: true)
                .Index(t => t.FKDSSEDataSetSectionID);
            
            CreateTable(
                "dbo.DataSetSection",
                c => new
                    {
                        DSSID = c.Int(nullable: false, identity: true),
                        DataSetSectionShortName = c.String(nullable: false, maxLength: 150, unicode: false),
                        DataSetSectionName = c.String(maxLength: 250, unicode: false),
                        DataSetNameSectionPersian = c.String(maxLength: 350),
                        DataSetNameSectionPashto = c.String(maxLength: 350),
                        FKDSSDataSetID = c.Int(),
                    })
                .PrimaryKey(t => t.DSSID)
                .ForeignKey("dbo.DataSetTbl", t => t.FKDSSDataSetID, cascadeDelete: true)
                .Index(t => t.FKDSSDataSetID);
            
            CreateTable(
                "dbo.DataSetTbl",
                c => new
                    {
                        DSId = c.Int(nullable: false, identity: true),
                        DataSetShortName = c.String(nullable: false, maxLength: 150, fixedLength: true),
                        DataSetName = c.String(maxLength: 250, fixedLength: true),
                        DataSetNamePersian = c.String(maxLength: 350),
                        DataSetNamePashto = c.String(maxLength: 350),
                        DataSetFor = c.String(maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.DSId);
            
            CreateTable(
                "dbo.Refer",
                c => new
                    {
                        ReferID = c.Int(nullable: false, identity: true),
                        ReferDate = c.DateTime(),
                        ReferFrom = c.Int(),
                        ReferTo = c.Int(),
                        ReferWardTo = c.Int(),
                        ReferDescription = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.ReferID)
                .ForeignKey("dbo.Service", t => t.ReferFrom)
                .ForeignKey("dbo.Facility", t => t.ReferTo)
                .ForeignKey("dbo.DataSetTbl", t => t.ReferWardTo)
                .Index(t => t.ReferFrom)
                .Index(t => t.ReferTo)
                .Index(t => t.ReferWardTo);
            
            CreateTable(
                "dbo.Facility",
                c => new
                    {
                        FID = c.Int(nullable: false),
                        FKFFacilityTypeID = c.Int(nullable: false),
                        FacilityName = c.String(maxLength: 255, unicode: false),
                        FacilityNameLocal = c.String(maxLength: 350),
                        FacilityDescription = c.String(maxLength: 500),
                        EstablishmentDate = c.DateTime(),
                        FKFDisctictCode = c.Int(),
                        FKFProvinceCode = c.Int(),
                    })
                .PrimaryKey(t => t.FID)
                .ForeignKey("dbo.District", t => t.FKFDisctictCode)
                .ForeignKey("dbo.Province", t => t.FKFProvinceCode)
                .ForeignKey("dbo.FacilityType", t => t.FKFFacilityTypeID)
                .Index(t => t.FKFFacilityTypeID)
                .Index(t => t.FKFDisctictCode)
                .Index(t => t.FKFProvinceCode);
            
            CreateTable(
                "dbo.District",
                c => new
                    {
                        DistrictCode = c.Int(nullable: false, identity: true),
                        District = c.String(maxLength: 250, unicode: false),
                        DistrictLocal = c.String(maxLength: 350),
                        ProvinceCode = c.Int(),
                    })
                .PrimaryKey(t => t.DistrictCode)
                .ForeignKey("dbo.Province", t => t.ProvinceCode, cascadeDelete: true)
                .Index(t => t.ProvinceCode);
            
            CreateTable(
                "dbo.PartyAddress",
                c => new
                    {
                        PartyAddressID = c.Int(nullable: false, identity: true),
                        FKPAPartyId = c.Int(),
                        PartyAddressProvince = c.Int(),
                        PartyAddressDistrict = c.Int(),
                        PartyAddressDescription = c.String(maxLength: 500),
                        PartyAddressStartDate = c.DateTime(),
                        PartyAddressThruDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PartyAddressID)
                .ForeignKey("dbo.Party", t => t.FKPAPartyId)
                .ForeignKey("dbo.Province", t => t.PartyAddressProvince)
                .ForeignKey("dbo.District", t => t.PartyAddressDistrict)
                .Index(t => t.FKPAPartyId)
                .Index(t => t.PartyAddressProvince)
                .Index(t => t.PartyAddressDistrict);
            
            CreateTable(
                "dbo.Party",
                c => new
                    {
                        PartyID = c.Int(nullable: false, identity: true),
                        PartyDescription = c.String(maxLength: 350, unicode: false),
                        PartyDescriptionLocal = c.String(maxLength: 350),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKPPartyType = c.Int(),
                    })
                .PrimaryKey(t => t.PartyID)
                .ForeignKey("dbo.PartyType", t => t.FKPPartyType)
                .Index(t => t.FKPPartyType);
            
            CreateTable(
                "dbo.PartyGroup",
                c => new
                    {
                        PartyGroupID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(maxLength: 150, unicode: false),
                        GroupNameLocal = c.String(maxLength: 150),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKPGPartyID = c.Int(),
                    })
                .PrimaryKey(t => t.PartyGroupID)
                .ForeignKey("dbo.Party", t => t.FKPGPartyID)
                .Index(t => t.FKPGPartyID);
            
            CreateTable(
                "dbo.PartyQualification",
                c => new
                    {
                        PartyQualificationId = c.Int(nullable: false, identity: true),
                        FKPQPartyID = c.Int(),
                        FKPQPartyQualificationTypeId = c.Int(),
                        PartyQualificationDescription = c.String(maxLength: 500),
                        PartyQualificationDescriptionLocal = c.String(maxLength: 500),
                        Title = c.String(maxLength: 150, unicode: false),
                        TitleLocal = c.String(maxLength: 250),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PartyQualificationId)
                .ForeignKey("dbo.PartyQualificationType", t => t.FKPQPartyQualificationTypeId)
                .ForeignKey("dbo.Party", t => t.FKPQPartyID)
                .Index(t => t.FKPQPartyID)
                .Index(t => t.FKPQPartyQualificationTypeId);
            
            CreateTable(
                "dbo.PartyQualificationType",
                c => new
                    {
                        PartyQualificationTypeID = c.Int(nullable: false, identity: true),
                        QualificationType = c.String(maxLength: 250, unicode: false),
                        QualificationTypeLocal = c.String(maxLength: 250),
                        PartyQualificationTypeDescription = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.PartyQualificationTypeID);
            
            CreateTable(
                "dbo.PartyRelationship",
                c => new
                    {
                        PartyRelationshipID = c.Int(nullable: false, identity: true),
                        PartyRelationshipDescription = c.String(maxLength: 500, unicode: false),
                        PartyRelationshipDescriptionLocal = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        PartyIdTo = c.Int(),
                        RoleTypeTo = c.Int(),
                        PartyIdFrom = c.Int(),
                        RoleTypeFrom = c.Int(),
                        RelationshipName = c.String(maxLength: 255, unicode: false),
                        PartyRelationshipTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.PartyRelationshipID)
                .ForeignKey("dbo.PartyRelationshipType", t => t.PartyRelationshipTypeId)
                .ForeignKey("dbo.PartyRole", t => t.RoleTypeTo)
                .ForeignKey("dbo.PartyRole", t => t.RoleTypeFrom)
                .ForeignKey("dbo.Party", t => t.PartyIdTo)
                .ForeignKey("dbo.Party", t => t.PartyIdFrom)
                .Index(t => t.PartyIdTo)
                .Index(t => t.RoleTypeTo)
                .Index(t => t.PartyIdFrom)
                .Index(t => t.RoleTypeFrom)
                .Index(t => t.PartyRelationshipTypeId);
            
            CreateTable(
                "dbo.PartyRelationshipType",
                c => new
                    {
                        PartyRelationshipTypeId = c.Int(nullable: false, identity: true),
                        PartyRelationshipTypeDescription = c.String(maxLength: 500, unicode: false),
                        PartyRelationshipTypeDescriptionLocal = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PartyRelationshipTypeId);
            
            CreateTable(
                "dbo.PartyRole",
                c => new
                    {
                        PartyRoleID = c.Int(nullable: false, identity: true),
                        PartyRoleDescription = c.String(maxLength: 500, unicode: false),
                        PartyRoleDescriptionLocal = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKPRPartyID = c.Int(),
                        FKPRRoleTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.PartyRoleID)
                .ForeignKey("dbo.RoleType", t => t.FKPRRoleTypeId)
                .ForeignKey("dbo.Party", t => t.FKPRPartyID)
                .Index(t => t.FKPRPartyID)
                .Index(t => t.FKPRRoleTypeId);
            
            CreateTable(
                "dbo.RoleType",
                c => new
                    {
                        RoleTypeId = c.Int(nullable: false, identity: true),
                        RoleType = c.String(maxLength: 255, unicode: false),
                        RoleTypeLocal = c.String(maxLength: 255),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.RoleTypeId);
            
            CreateTable(
                "dbo.PartySkills",
                c => new
                    {
                        PartySkillIId = c.Int(nullable: false, identity: true),
                        FKPSPartyId = c.Int(),
                        FKPSSkillTypeId = c.Int(),
                        Skill = c.String(maxLength: 350, unicode: false),
                        SkillLocal = c.String(maxLength: 350),
                        YearExprience = c.Int(),
                        Rating = c.Int(),
                        SkillLevel = c.Int(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PartySkillIId)
                .ForeignKey("dbo.SkillType", t => t.FKPSSkillTypeId)
                .ForeignKey("dbo.Party", t => t.FKPSPartyId)
                .Index(t => t.FKPSPartyId)
                .Index(t => t.FKPSSkillTypeId);
            
            CreateTable(
                "dbo.SkillType",
                c => new
                    {
                        SkillTypeID = c.Int(nullable: false, identity: true),
                        SkillDescription = c.String(maxLength: 350, unicode: false),
                        SkillDescriptionLocal = c.String(maxLength: 350),
                    })
                .PrimaryKey(t => t.SkillTypeID);
            
            CreateTable(
                "dbo.PartyType",
                c => new
                    {
                        PartyTypeID = c.Int(nullable: false, identity: true),
                        PartyTypeDescription = c.String(maxLength: 500, unicode: false),
                        PartyTypeDescriptionLocal = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKPartyRoleID = c.Int(),
                    })
                .PrimaryKey(t => t.PartyTypeID);
            
            CreateTable(
                "dbo.PersonInfo",
                c => new
                    {
                        MRID = c.Decimal(nullable: false, precision: 18, scale: 0, storeType: "numeric"),
                        Name = c.String(maxLength: 350, unicode: false),
                        FatherName = c.String(maxLength: 350, unicode: false),
                        Gender = c.Int(),
                        MaritalStatus = c.Int(),
                        PhoneNumber = c.String(maxLength: 55, unicode: false),
                        DateOfBirth = c.DateTime(),
                        BloodGroup = c.Int(),
                        FKPIPartyID = c.Int(),
                        SocialSecurityNumber = c.String(maxLength: 60, unicode: false),
                        PassportNumber = c.String(maxLength: 60, unicode: false),
                    })
                .PrimaryKey(t => t.MRID)
                .ForeignKey("dbo.Party", t => t.FKPIPartyID)
                .Index(t => t.FKPIPartyID);
            
            CreateTable(
                "dbo.PersonAddress",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        AddressType = c.String(maxLength: 250, unicode: false),
                        Province = c.Int(),
                        District = c.Int(),
                        ExactLocation = c.String(maxLength: 700),
                        StayLength = c.Int(),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKPAMRID = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.Province", t => t.Province)
                .ForeignKey("dbo.PersonInfo", t => t.FKPAMRID)
                .ForeignKey("dbo.District", t => t.District)
                .Index(t => t.Province)
                .Index(t => t.District)
                .Index(t => t.FKPAMRID);
            
            CreateTable(
                "dbo.Province",
                c => new
                    {
                        ProvinceCode = c.Int(nullable: false, identity: true),
                        Province = c.String(maxLength: 350, unicode: false),
                        ProvinceLocal = c.String(maxLength: 350),
                    })
                .PrimaryKey(t => t.ProvinceCode);
            
            CreateTable(
                "dbo.PersonEducation",
                c => new
                    {
                        PersonEducationID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        EducationDetails = c.String(maxLength: 500),
                        FKPEMRID = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.PersonEducationID)
                .ForeignKey("dbo.PersonInfo", t => t.FKPEMRID)
                .Index(t => t.FKPEMRID);
            
            CreateTable(
                "dbo.PersonOccupation",
                c => new
                    {
                        PersonOccupationID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        OccupationDetails = c.String(maxLength: 500),
                        FKPOMRID = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.PersonOccupationID)
                .ForeignKey("dbo.PersonInfo", t => t.FKPOMRID)
                .Index(t => t.FKPOMRID);
            
            CreateTable(
                "dbo.PersonRole",
                c => new
                    {
                        PersonRoleID = c.Decimal(nullable: false, precision: 18, scale: 0, identity: true, storeType: "numeric"),
                        FKPRPersonRoleTypeID = c.Int(),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKPRMRID = c.Decimal(precision: 18, scale: 0, storeType: "numeric"),
                    })
                .PrimaryKey(t => t.PersonRoleID)
                .ForeignKey("dbo.PersonRoleType", t => t.FKPRPersonRoleTypeID)
                .ForeignKey("dbo.PersonInfo", t => t.FKPRMRID)
                .Index(t => t.FKPRPersonRoleTypeID)
                .Index(t => t.FKPRMRID);
            
            CreateTable(
                "dbo.PersonRoleType",
                c => new
                    {
                        PersonRoleTypeID = c.Int(nullable: false, identity: true),
                        PersonRoleType = c.String(maxLength: 350, unicode: false),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.PersonRoleTypeID);
            
            CreateTable(
                "dbo.Service",
                c => new
                    {
                        ServiceID = c.Int(nullable: false, identity: true),
                        FKSFacillityID = c.Int(),
                        FKSWardID = c.Int(),
                        FKSPartyID = c.Int(),
                        StartDate = c.DateTime(),
                        EndDate = c.DateTime(),
                        Purpose = c.Int(),
                    })
                .PrimaryKey(t => t.ServiceID)
                .ForeignKey("dbo.PurposeType", t => t.Purpose)
                .ForeignKey("dbo.Party", t => t.FKSPartyID)
                .ForeignKey("dbo.Facility", t => t.FKSFacillityID)
                .ForeignKey("dbo.DataSetTbl", t => t.FKSWardID)
                .Index(t => t.FKSFacillityID)
                .Index(t => t.FKSWardID)
                .Index(t => t.FKSPartyID)
                .Index(t => t.Purpose);
            
            CreateTable(
                "dbo.PurposeType",
                c => new
                    {
                        PurposeID = c.Int(nullable: false, identity: true),
                        Purpose = c.String(maxLength: 250, unicode: false),
                        PurposeLocal = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.PurposeID);
            
            CreateTable(
                "dbo.FacilityContactMechanisim",
                c => new
                    {
                        FMID = c.Int(nullable: false, identity: true),
                        FKFCMFacilityID = c.Int(),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.FMID)
                .ForeignKey("dbo.Facility", t => t.FKFCMFacilityID)
                .Index(t => t.FKFCMFacilityID);
            
            CreateTable(
                "dbo.FacilityContactMechanisimPurpose",
                c => new
                    {
                        FCMPID = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        ContactPurposeType = c.String(maxLength: 355, unicode: false),
                        FKFCMPFCMID = c.Int(),
                    })
                .PrimaryKey(t => t.FCMPID)
                .ForeignKey("dbo.FacilityContactMechanisim", t => t.FKFCMPFCMID)
                .Index(t => t.FKFCMPFCMID);
            
            CreateTable(
                "dbo.FacilityContent",
                c => new
                    {
                        FCID = c.Int(nullable: false, identity: true),
                        FacilityContent = c.String(maxLength: 500, unicode: false),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        FKFCFacilityID = c.Int(),
                    })
                .PrimaryKey(t => t.FCID)
                .ForeignKey("dbo.Facility", t => t.FKFCFacilityID, cascadeDelete: true)
                .Index(t => t.FKFCFacilityID);
            
            CreateTable(
                "dbo.FacilityGroup",
                c => new
                    {
                        FGID = c.Int(nullable: false, identity: true),
                        FKFGFacilityGroupTypeID = c.Int(),
                        FacilityGroup = c.String(maxLength: 250, unicode: false),
                        FacilityGroupLocal = c.String(maxLength: 350),
                        FKFGFacilityID = c.Int(),
                    })
                .PrimaryKey(t => t.FGID)
                .ForeignKey("dbo.FacilityGroupType", t => t.FKFGFacilityGroupTypeID)
                .ForeignKey("dbo.Facility", t => t.FKFGFacilityID)
                .Index(t => t.FKFGFacilityGroupTypeID)
                .Index(t => t.FKFGFacilityID);
            
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
                    })
                .PrimaryKey(t => t.FGMID)
                .ForeignKey("dbo.FacilityGroup", t => t.FKFGMFacilityID)
                .Index(t => t.FKFGMFacilityID);
            
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
                    })
                .PrimaryKey(t => t.FGRId)
                .ForeignKey("dbo.FacilityGroup", t => t.FKFGRFacilityGroupID)
                .Index(t => t.FKFGRFacilityGroupID);
            
            CreateTable(
                "dbo.FacilityGroupType",
                c => new
                    {
                        FGTID = c.Int(nullable: false, identity: true),
                        FacilityGroupType = c.String(nullable: false, maxLength: 250, unicode: false),
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
                        Lat = c.String(maxLength: 50, unicode: false),
                        Lan = c.String(maxLength: 50, unicode: false),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                        Status = c.Int(),
                        FKFLGPFacilityID = c.Int(),
                        FacilityGeoPiontDescription = c.String(maxLength: 500),
                    })
                .PrimaryKey(t => t.FLGeoPID)
                .ForeignKey("dbo.Facility", t => t.FKFLGPFacilityID, cascadeDelete: true)
                .Index(t => t.FKFLGPFacilityID);
            
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
                    })
                .PrimaryKey(t => t.FPID)
                .ForeignKey("dbo.Facility", t => t.FKFPFacilityID)
                .Index(t => t.FKFPFacilityID);
            
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
                    })
                .PrimaryKey(t => t.FacilityRoleID)
                .ForeignKey("dbo.Facility", t => t.FKFRFacilityID)
                .Index(t => t.FKFRFacilityID);
            
            CreateTable(
                "dbo.FacilityType",
                c => new
                    {
                        FacilityTypeID = c.Int(nullable: false, identity: true),
                        FacilityType = c.String(maxLength: 350, unicode: false),
                        FacilityTypeLocal = c.String(maxLength: 350),
                        FacilityTypeDescription = c.String(maxLength: 500),
                        StartDate = c.DateTime(),
                        ThruDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.FacilityTypeID);
            
            CreateTable(
                "dbo.ElementValues",
                c => new
                    {
                        DEVID = c.Int(nullable: false, identity: true),
                        DataElementValue = c.Int(),
                        FKEVDataElementID = c.Int(),
                        FKEVServiceID = c.Int(),
                    })
                .PrimaryKey(t => t.DEVID)
                .ForeignKey("dbo.DataElement", t => t.FKEVDataElementID, cascadeDelete: true)
                .Index(t => t.FKEVDataElementID);
            
            CreateTable(
                "dbo.sysdiagrams",
                c => new
                    {
                        diagram_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 128),
                        principal_id = c.Int(nullable: false),
                        version = c.Int(),
                        definition = c.Binary(),
                    })
                .PrimaryKey(t => t.diagram_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DataElement", "FKDEDataSetClassficationID", "dbo.DataClassfication");
            DropForeignKey("dbo.ElementValues", "FKEVDataElementID", "dbo.DataElement");
            DropForeignKey("dbo.Service", "FKSWardID", "dbo.DataSetTbl");
            DropForeignKey("dbo.Refer", "ReferWardTo", "dbo.DataSetTbl");
            DropForeignKey("dbo.Service", "FKSFacillityID", "dbo.Facility");
            DropForeignKey("dbo.Refer", "ReferTo", "dbo.Facility");
            DropForeignKey("dbo.Facility", "FKFFacilityTypeID", "dbo.FacilityType");
            DropForeignKey("dbo.FacilityRole", "FKFRFacilityID", "dbo.Facility");
            DropForeignKey("dbo.FacilityParty", "FKFPFacilityID", "dbo.Facility");
            DropForeignKey("dbo.FacilityLocationGeoPiont", "FKFLGPFacilityID", "dbo.Facility");
            DropForeignKey("dbo.FacilityGroup", "FKFGFacilityID", "dbo.Facility");
            DropForeignKey("dbo.FacilityGroup", "FKFGFacilityGroupTypeID", "dbo.FacilityGroupType");
            DropForeignKey("dbo.FacilityGroupRole", "FKFGRFacilityGroupID", "dbo.FacilityGroup");
            DropForeignKey("dbo.FacilityGroupMember", "FKFGMFacilityID", "dbo.FacilityGroup");
            DropForeignKey("dbo.FacilityContent", "FKFCFacilityID", "dbo.Facility");
            DropForeignKey("dbo.FacilityContactMechanisim", "FKFCMFacilityID", "dbo.Facility");
            DropForeignKey("dbo.FacilityContactMechanisimPurpose", "FKFCMPFCMID", "dbo.FacilityContactMechanisim");
            DropForeignKey("dbo.PersonAddress", "District", "dbo.District");
            DropForeignKey("dbo.PartyAddress", "PartyAddressDistrict", "dbo.District");
            DropForeignKey("dbo.Service", "FKSPartyID", "dbo.Party");
            DropForeignKey("dbo.Refer", "ReferFrom", "dbo.Service");
            DropForeignKey("dbo.Service", "Purpose", "dbo.PurposeType");
            DropForeignKey("dbo.PersonInfo", "FKPIPartyID", "dbo.Party");
            DropForeignKey("dbo.PersonRole", "FKPRMRID", "dbo.PersonInfo");
            DropForeignKey("dbo.PersonRole", "FKPRPersonRoleTypeID", "dbo.PersonRoleType");
            DropForeignKey("dbo.PersonOccupation", "FKPOMRID", "dbo.PersonInfo");
            DropForeignKey("dbo.PersonEducation", "FKPEMRID", "dbo.PersonInfo");
            DropForeignKey("dbo.PersonAddress", "FKPAMRID", "dbo.PersonInfo");
            DropForeignKey("dbo.PersonAddress", "Province", "dbo.Province");
            DropForeignKey("dbo.PartyAddress", "PartyAddressProvince", "dbo.Province");
            DropForeignKey("dbo.Facility", "FKFProvinceCode", "dbo.Province");
            DropForeignKey("dbo.District", "ProvinceCode", "dbo.Province");
            DropForeignKey("dbo.Party", "FKPPartyType", "dbo.PartyType");
            DropForeignKey("dbo.PartySkills", "FKPSPartyId", "dbo.Party");
            DropForeignKey("dbo.PartySkills", "FKPSSkillTypeId", "dbo.SkillType");
            DropForeignKey("dbo.PartyRole", "FKPRPartyID", "dbo.Party");
            DropForeignKey("dbo.PartyRelationship", "PartyIdFrom", "dbo.Party");
            DropForeignKey("dbo.PartyRelationship", "PartyIdTo", "dbo.Party");
            DropForeignKey("dbo.PartyRole", "FKPRRoleTypeId", "dbo.RoleType");
            DropForeignKey("dbo.PartyRelationship", "RoleTypeFrom", "dbo.PartyRole");
            DropForeignKey("dbo.PartyRelationship", "RoleTypeTo", "dbo.PartyRole");
            DropForeignKey("dbo.PartyRelationship", "PartyRelationshipTypeId", "dbo.PartyRelationshipType");
            DropForeignKey("dbo.PartyQualification", "FKPQPartyID", "dbo.Party");
            DropForeignKey("dbo.PartyQualification", "FKPQPartyQualificationTypeId", "dbo.PartyQualificationType");
            DropForeignKey("dbo.PartyGroup", "FKPGPartyID", "dbo.Party");
            DropForeignKey("dbo.PartyAddress", "FKPAPartyId", "dbo.Party");
            DropForeignKey("dbo.Facility", "FKFDisctictCode", "dbo.District");
            DropForeignKey("dbo.DataSetSection", "FKDSSDataSetID", "dbo.DataSetTbl");
            DropForeignKey("dbo.DataSetSectionElement", "FKDSSEDataSetSectionID", "dbo.DataSetSection");
            DropForeignKey("dbo.DataElement", "FKDEDataSetSectionElementID", "dbo.DataSetSectionElement");
            DropIndex("dbo.ElementValues", new[] { "FKEVDataElementID" });
            DropIndex("dbo.FacilityRole", new[] { "FKFRFacilityID" });
            DropIndex("dbo.FacilityParty", new[] { "FKFPFacilityID" });
            DropIndex("dbo.FacilityLocationGeoPiont", new[] { "FKFLGPFacilityID" });
            DropIndex("dbo.FacilityGroupRole", new[] { "FKFGRFacilityGroupID" });
            DropIndex("dbo.FacilityGroupMember", new[] { "FKFGMFacilityID" });
            DropIndex("dbo.FacilityGroup", new[] { "FKFGFacilityID" });
            DropIndex("dbo.FacilityGroup", new[] { "FKFGFacilityGroupTypeID" });
            DropIndex("dbo.FacilityContent", new[] { "FKFCFacilityID" });
            DropIndex("dbo.FacilityContactMechanisimPurpose", new[] { "FKFCMPFCMID" });
            DropIndex("dbo.FacilityContactMechanisim", new[] { "FKFCMFacilityID" });
            DropIndex("dbo.Service", new[] { "Purpose" });
            DropIndex("dbo.Service", new[] { "FKSPartyID" });
            DropIndex("dbo.Service", new[] { "FKSWardID" });
            DropIndex("dbo.Service", new[] { "FKSFacillityID" });
            DropIndex("dbo.PersonRole", new[] { "FKPRMRID" });
            DropIndex("dbo.PersonRole", new[] { "FKPRPersonRoleTypeID" });
            DropIndex("dbo.PersonOccupation", new[] { "FKPOMRID" });
            DropIndex("dbo.PersonEducation", new[] { "FKPEMRID" });
            DropIndex("dbo.PersonAddress", new[] { "FKPAMRID" });
            DropIndex("dbo.PersonAddress", new[] { "District" });
            DropIndex("dbo.PersonAddress", new[] { "Province" });
            DropIndex("dbo.PersonInfo", new[] { "FKPIPartyID" });
            DropIndex("dbo.PartySkills", new[] { "FKPSSkillTypeId" });
            DropIndex("dbo.PartySkills", new[] { "FKPSPartyId" });
            DropIndex("dbo.PartyRole", new[] { "FKPRRoleTypeId" });
            DropIndex("dbo.PartyRole", new[] { "FKPRPartyID" });
            DropIndex("dbo.PartyRelationship", new[] { "PartyRelationshipTypeId" });
            DropIndex("dbo.PartyRelationship", new[] { "RoleTypeFrom" });
            DropIndex("dbo.PartyRelationship", new[] { "PartyIdFrom" });
            DropIndex("dbo.PartyRelationship", new[] { "RoleTypeTo" });
            DropIndex("dbo.PartyRelationship", new[] { "PartyIdTo" });
            DropIndex("dbo.PartyQualification", new[] { "FKPQPartyQualificationTypeId" });
            DropIndex("dbo.PartyQualification", new[] { "FKPQPartyID" });
            DropIndex("dbo.PartyGroup", new[] { "FKPGPartyID" });
            DropIndex("dbo.Party", new[] { "FKPPartyType" });
            DropIndex("dbo.PartyAddress", new[] { "PartyAddressDistrict" });
            DropIndex("dbo.PartyAddress", new[] { "PartyAddressProvince" });
            DropIndex("dbo.PartyAddress", new[] { "FKPAPartyId" });
            DropIndex("dbo.District", new[] { "ProvinceCode" });
            DropIndex("dbo.Facility", new[] { "FKFProvinceCode" });
            DropIndex("dbo.Facility", new[] { "FKFDisctictCode" });
            DropIndex("dbo.Facility", new[] { "FKFFacilityTypeID" });
            DropIndex("dbo.Refer", new[] { "ReferWardTo" });
            DropIndex("dbo.Refer", new[] { "ReferTo" });
            DropIndex("dbo.Refer", new[] { "ReferFrom" });
            DropIndex("dbo.DataSetSection", new[] { "FKDSSDataSetID" });
            DropIndex("dbo.DataSetSectionElement", new[] { "FKDSSEDataSetSectionID" });
            DropIndex("dbo.DataElement", new[] { "FKDEDataSetClassficationID" });
            DropIndex("dbo.DataElement", new[] { "FKDEDataSetSectionElementID" });
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.ElementValues");
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
            DropTable("dbo.PurposeType");
            DropTable("dbo.Service");
            DropTable("dbo.PersonRoleType");
            DropTable("dbo.PersonRole");
            DropTable("dbo.PersonOccupation");
            DropTable("dbo.PersonEducation");
            DropTable("dbo.Province");
            DropTable("dbo.PersonAddress");
            DropTable("dbo.PersonInfo");
            DropTable("dbo.PartyType");
            DropTable("dbo.SkillType");
            DropTable("dbo.PartySkills");
            DropTable("dbo.RoleType");
            DropTable("dbo.PartyRole");
            DropTable("dbo.PartyRelationshipType");
            DropTable("dbo.PartyRelationship");
            DropTable("dbo.PartyQualificationType");
            DropTable("dbo.PartyQualification");
            DropTable("dbo.PartyGroup");
            DropTable("dbo.Party");
            DropTable("dbo.PartyAddress");
            DropTable("dbo.District");
            DropTable("dbo.Facility");
            DropTable("dbo.Refer");
            DropTable("dbo.DataSetTbl");
            DropTable("dbo.DataSetSection");
            DropTable("dbo.DataSetSectionElement");
            DropTable("dbo.DataElement");
            DropTable("dbo.DataClassfication");
        }
    }
}
