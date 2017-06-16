namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testt : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.PartyAddress", "FKPAPartyId", "dbo.Party");
            //DropForeignKey("dbo.PartyQualification", "FKPQPartyQualificationTypeId", "dbo.PartyQualificationType");
            //DropForeignKey("dbo.PartyQualification", "FKPQPartyID", "dbo.Party");
            //DropForeignKey("dbo.PartyRelationship", "RoleTypeFrom", "dbo.PartyRole");
            //DropForeignKey("dbo.PartyRelationship", "RoleTypeTo", "dbo.PartyRole");
            //DropForeignKey("dbo.PartyRole", "FKPRRoleTypeId", "dbo.RoleType");
            //DropForeignKey("dbo.PartyRelationship", "PartyIdFrom", "dbo.Party");
            //DropForeignKey("dbo.PartyRelationship", "PartyIdTo", "dbo.Party");
            //DropForeignKey("dbo.PartyRole", "FKPRPartyID", "dbo.Party");
            //DropForeignKey("dbo.PartySkills", "FKPSPartyId", "dbo.Party");
            //DropForeignKey("dbo.PersonAddress", "FKPAMRID", "dbo.PersonInfo");
            //DropForeignKey("dbo.PersonEducation", "FKPEMRID", "dbo.PersonInfo");
            //DropForeignKey("dbo.PersonOccupation", "FKPOMRID", "dbo.PersonInfo");
            //DropForeignKey("dbo.PersonRole", "FKPRPersonRoleTypeID", "dbo.PersonRoleType");
            //DropForeignKey("dbo.PersonRole", "FKPRMRID", "dbo.PersonInfo");
            //DropForeignKey("dbo.PersonInfo", "FKPIPartyID", "dbo.Party");
            //DropForeignKey("dbo.Service", "FKSPartyID", "dbo.Party");
            //DropForeignKey("dbo.PartyGroup", "FKPGPartyID", "dbo.Party");
            //DropIndex("dbo.PartyAddress", new[] { "FKPAPartyId" });
            //DropIndex("dbo.PartyQualification", new[] { "FKPQPartyID" });
            //DropIndex("dbo.PartyQualification", new[] { "FKPQPartyQualificationTypeId" });
            //DropIndex("dbo.PartyRelationship", new[] { "PartyIdTo" });
            //DropIndex("dbo.PartyRelationship", new[] { "PartyIdFrom" });
            //DropIndex("dbo.PartyRole", new[] { "FKPRPartyID" });
            //DropIndex("dbo.PartyRole", new[] { "FKPRRoleTypeId" });
            //DropIndex("dbo.PartySkills", new[] { "FKPSPartyId" });
            //DropIndex("dbo.PersonInfo", new[] { "FKPIPartyID" });
            //DropIndex("dbo.PersonAddress", new[] { "FKPAMRID" });
            //DropIndex("dbo.PersonEducation", new[] { "FKPEMRID" });
            //DropIndex("dbo.PersonOccupation", new[] { "FKPOMRID" });
            //DropIndex("dbo.PersonRole", new[] { "FKPRPersonRoleTypeID" });
            //DropIndex("dbo.PersonRole", new[] { "FKPRMRID" });
            //DropIndex("dbo.Service", new[] { "FKSPartyID" });
            //RenameColumn(table: "dbo.Party", name: "FKPPartyType", newName: "PartyTypeID");
            //RenameIndex(table: "dbo.Party", name: "IX_FKPPartyType", newName: "IX_PartyTypeID");
            //DropPrimaryKey("dbo.AllElements");
            //DropPrimaryKey("dbo.allelementsv");
            //DropPrimaryKey("dbo.Party");
            //DropPrimaryKey("dbo.PersonRole");
            //CreateTable(
            //    "dbo.Person",
            //    c => new
            //        {
            //            PartyID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 350, unicode: false),
            //            FatherName = c.String(maxLength: 350, unicode: false),
            //            Gender = c.Int(),
            //            MaritalStatus = c.Int(),
            //            PhoneNumber = c.String(maxLength: 55, unicode: false),
            //            DateOfBirth = c.DateTime(),
            //            BloodGroup = c.Int(),
            //            SocialSecurityNumber = c.String(maxLength: 60, unicode: false),
            //            PassportNumber = c.String(maxLength: 60, unicode: false),
            //        })
            //    .PrimaryKey(t => t.PartyID)
            //    .ForeignKey("dbo.Party", t => t.PartyID)
            //    .Index(t => t.PartyID);
            
            //CreateTable(
            //    "dbo.Organization",
            //    c => new
            //        {
            //            PartyID = c.Int(nullable: false),
            //            Name = c.String(maxLength: 50),
            //        })
            //    .PrimaryKey(t => t.PartyID)
            //    .ForeignKey("dbo.Party", t => t.PartyID)
            //    .Index(t => t.PartyID);
            
            //CreateTable(
            //    "dbo.PersonQualification",
            //    c => new
            //        {
            //            PartyQualificationId = c.Int(nullable: false, identity: true),
            //            PartyID = c.Int(),
            //            PersonQualificationTypeId = c.Int(),
            //            PartyQualificationDescription = c.String(maxLength: 500),
            //            PartyQualificationDescriptionLocal = c.String(maxLength: 500),
            //            Title = c.String(maxLength: 150, unicode: false),
            //            TitleLocal = c.String(maxLength: 250),
            //            StartDate = c.DateTime(),
            //            ThruDate = c.DateTime(),
            //        })
            //    .PrimaryKey(t => t.PartyQualificationId)
            //    .ForeignKey("dbo.Person", t => t.PartyID)
            //    .ForeignKey("dbo.PersonQualificationType", t => t.PersonQualificationTypeId)
            //    .Index(t => t.PartyID)
            //    .Index(t => t.PersonQualificationTypeId);
            
            //CreateTable(
            //    "dbo.PersonQualificationType",
            //    c => new
            //        {
            //            PersonQualificationTypeID = c.Int(nullable: false, identity: true),
            //            QualificationType = c.String(maxLength: 250, unicode: false),
            //            QualificationTypeLocal = c.String(maxLength: 250),
            //            PartyQualificationTypeDescription = c.String(maxLength: 500),
            //        })
            //    .PrimaryKey(t => t.PersonQualificationTypeID);
            
            //CreateTable(
            //    "dbo.Employee",
            //    c => new
            //        {
            //            PersonRoleID = c.Int(nullable: false),
            //            EmployeeID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PersonRoleID)
            //    .ForeignKey("dbo.PersonRole", t => t.PersonRoleID)
            //    .Index(t => t.PersonRoleID);
            
            //CreateTable(
            //    "dbo.Patient",
            //    c => new
            //        {
            //            PersonRoleID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.PersonRoleID)
            //    .ForeignKey("dbo.PersonRole", t => t.PersonRoleID)
            //    .Index(t => t.PersonRoleID);
            
            //CreateTable(
            //    "dbo.PatientVisit",
            //    c => new
            //        {
            //            VisitID = c.Int(nullable: false, identity: true),
            //            FromDate = c.DateTime(storeType: "date"),
            //            ThruDate = c.DateTime(storeType: "date"),
            //            PersonRoleID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.VisitID)
            //    .ForeignKey("dbo.Patient", t => t.PersonRoleID)
            //    .Index(t => t.PersonRoleID);
            
            //CreateTable(
            //    "dbo.User",
            //    c => new
            //        {
            //            PersonRoleID = c.Int(nullable: false),
            //            Enabled = c.Boolean(),
            //            StartDate = c.DateTime(storeType: "date"),
            //            ThruDate = c.DateTime(storeType: "date"),
            //        })
            //    .PrimaryKey(t => t.PersonRoleID)
            //    .ForeignKey("dbo.PersonRole", t => t.PersonRoleID)
            //    .Index(t => t.PersonRoleID);
            
            //CreateTable(
            //    "dbo.sysdiagrams",
            //    c => new
            //        {
            //            diagram_id = c.Int(nullable: false, identity: true),
            //            name = c.String(nullable: false, maxLength: 128),
            //            principal_id = c.Int(nullable: false),
            //            version = c.Int(),
            //            definition = c.Binary(),
            //        })
            //    .PrimaryKey(t => t.diagram_id);
            
            //AddColumn("dbo.PartySkills", "PartyID", c => c.Int());
            //AddColumn("dbo.PartyType", "PartyType", c => c.String(maxLength: 500, unicode: false));
            //AddColumn("dbo.PersonRole", "PartyID", c => c.Int());
            //AddColumn("dbo.PersonRole", "RoleTypeId", c => c.Int());
            //AddColumn("dbo.Service", "VisitID", c => c.Int());
            //AlterColumn("dbo.AllElements", "DataSetShortName", c => c.String(nullable: false, maxLength: 150, fixedLength: true));
            //AlterColumn("dbo.AllElements", "DataSetSectionShortName", c => c.String(nullable: false, maxLength: 150, unicode: false));
            //AlterColumn("dbo.AllElements", "DataSetSectionElementShortName", c => c.String(nullable: false, maxLength: 150, unicode: false));
            //AlterColumn("dbo.AllElements", "DataSetName", c => c.String(maxLength: 250, fixedLength: true));
            //AlterColumn("dbo.AllElements", "DataSetFor", c => c.String(maxLength: 100, unicode: false));
            //AlterColumn("dbo.AllElements", "DataSetSectionName", c => c.String(maxLength: 250, unicode: false));
            //AlterColumn("dbo.AllElements", "DataSetSectionElementName", c => c.String(maxLength: 250, unicode: false));
            //AlterColumn("dbo.AllElements", "DataElement", c => c.String(maxLength: 150, unicode: false));
            //AlterColumn("dbo.allelementsv", "DataSetShortName", c => c.String(nullable: false, maxLength: 150, fixedLength: true));
            //AlterColumn("dbo.allelementsv", "DataSetSectionShortName", c => c.String(nullable: false, maxLength: 150, unicode: false));
            //AlterColumn("dbo.allelementsv", "DataSetSectionElementShortName", c => c.String(nullable: false, maxLength: 150, unicode: false));
            //AlterColumn("dbo.allelementsv", "DataSetName", c => c.String(maxLength: 250, fixedLength: true));
            //AlterColumn("dbo.allelementsv", "DataSetFor", c => c.String(maxLength: 100, unicode: false));
            //AlterColumn("dbo.allelementsv", "DataSetSectionName", c => c.String(maxLength: 250, unicode: false));
            //AlterColumn("dbo.allelementsv", "DataSetSectionElementName", c => c.String(maxLength: 250, unicode: false));
            //AlterColumn("dbo.allelementsv", "DataElement", c => c.String(maxLength: 150, unicode: false));
            //AlterColumn("dbo.Party", "PartyID", c => c.Int(nullable: false));
            //AlterColumn("dbo.Party", "ThruDate", c => c.DateTime(storeType: "date"));
            //AlterColumn("dbo.PersonAddress", "FKPAMRID", c => c.Int());
            //AlterColumn("dbo.PersonEducation", "FKPEMRID", c => c.Int());
            //AlterColumn("dbo.PersonOccupation", "FKPOMRID", c => c.Int());
            //AlterColumn("dbo.PersonRole", "PersonRoleID", c => c.Int(nullable: false, identity: true));
            //AddPrimaryKey("dbo.AllElements", new[] { "DSId", "DataSetShortName", "DSSID", "DataSetSectionShortName", "DSSEId", "DataSetSectionElementShortName", "DEID" });
            //AddPrimaryKey("dbo.allelementsv", new[] { "DSId", "DataSetShortName", "DSSID", "DataSetSectionShortName", "DSSEId", "DataSetSectionElementShortName", "DEID" });
            //AddPrimaryKey("dbo.Party", "PartyID");
            //AddPrimaryKey("dbo.PersonRole", "PersonRoleID");
            //CreateIndex("dbo.PersonAddress", "FKPAMRID");
            //CreateIndex("dbo.PartySkills", "PartyID");
            //CreateIndex("dbo.PersonEducation", "FKPEMRID");
            //CreateIndex("dbo.PersonOccupation", "FKPOMRID");
            //CreateIndex("dbo.PersonRole", "PartyID");
            //CreateIndex("dbo.PersonRole", "RoleTypeId");
            //CreateIndex("dbo.Service", "VisitID");
            //AddForeignKey("dbo.PartySkills", "PartyID", "dbo.Person", "PartyID");
            //AddForeignKey("dbo.PersonAddress", "FKPAMRID", "dbo.Person", "PartyID");
            //AddForeignKey("dbo.PersonEducation", "FKPEMRID", "dbo.Person", "PartyID");
            //AddForeignKey("dbo.PersonOccupation", "FKPOMRID", "dbo.Person", "PartyID");
            //AddForeignKey("dbo.PartyRelationship", "RoleTypeTo", "dbo.PersonRole", "PersonRoleID");
            //AddForeignKey("dbo.PartyRelationship", "RoleTypeFrom", "dbo.PersonRole", "PersonRoleID");
            //AddForeignKey("dbo.Service", "VisitID", "dbo.PatientVisit", "VisitID");
            //AddForeignKey("dbo.PersonRole", "PartyID", "dbo.Person", "PartyID");
            //AddForeignKey("dbo.PersonRole", "RoleTypeId", "dbo.RoleType", "RoleTypeId");
            //AddForeignKey("dbo.PartyGroup", "FKPGPartyID", "dbo.Party", "PartyID");
            //DropColumn("dbo.Party", "PartyDescription");
            //DropColumn("dbo.Party", "PartyDescriptionLocal");
            //DropColumn("dbo.RoleType", "RoleTypeLocal");
            //DropColumn("dbo.RoleType", "StartDate");
            //DropColumn("dbo.RoleType", "EndDate");
            //DropColumn("dbo.PartySkills", "FKPSPartyId");
            //DropColumn("dbo.PartyType", "PartyTypeDescription");
            //DropColumn("dbo.PartyType", "PartyTypeDescriptionLocal");
            //DropColumn("dbo.PartyType", "StartDate");
            //DropColumn("dbo.PartyType", "ThruDate");
            //DropColumn("dbo.PartyType", "FKPartyRoleID");
            //DropColumn("dbo.PersonRole", "FKPRPersonRoleTypeID");
            //DropColumn("dbo.PersonRole", "FKPRMRID");
            //DropColumn("dbo.Service", "FKSPartyID");
            //DropTable("dbo.PartyQualification");
            //DropTable("dbo.PartyQualificationType");
            //DropTable("dbo.PartyRole");
            //DropTable("dbo.PersonInfo");
            //DropTable("dbo.PersonRoleType");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.MRID);
            
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
                .PrimaryKey(t => t.PartyRoleID);
            
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
                .PrimaryKey(t => t.PartyQualificationId);
            
            AddColumn("dbo.Service", "FKSPartyID", c => c.Int());
            AddColumn("dbo.PersonRole", "FKPRMRID", c => c.Decimal(precision: 18, scale: 0, storeType: "numeric"));
            AddColumn("dbo.PersonRole", "FKPRPersonRoleTypeID", c => c.Int());
            AddColumn("dbo.PartyType", "FKPartyRoleID", c => c.Int());
            AddColumn("dbo.PartyType", "ThruDate", c => c.DateTime());
            AddColumn("dbo.PartyType", "StartDate", c => c.DateTime());
            AddColumn("dbo.PartyType", "PartyTypeDescriptionLocal", c => c.String(maxLength: 500));
            AddColumn("dbo.PartyType", "PartyTypeDescription", c => c.String(maxLength: 500, unicode: false));
            AddColumn("dbo.PartySkills", "FKPSPartyId", c => c.Int());
            AddColumn("dbo.RoleType", "EndDate", c => c.DateTime());
            AddColumn("dbo.RoleType", "StartDate", c => c.DateTime());
            AddColumn("dbo.RoleType", "RoleTypeLocal", c => c.String(maxLength: 255));
            AddColumn("dbo.Party", "PartyDescriptionLocal", c => c.String(maxLength: 350));
            AddColumn("dbo.Party", "PartyDescription", c => c.String(maxLength: 350, unicode: false));
            DropForeignKey("dbo.PartyGroup", "FKPGPartyID", "dbo.Party");
            DropForeignKey("dbo.User", "PersonRoleID", "dbo.PersonRole");
            DropForeignKey("dbo.PersonRole", "RoleTypeId", "dbo.RoleType");
            DropForeignKey("dbo.PersonRole", "PartyID", "dbo.Person");
            DropForeignKey("dbo.Patient", "PersonRoleID", "dbo.PersonRole");
            DropForeignKey("dbo.PatientVisit", "PersonRoleID", "dbo.Patient");
            DropForeignKey("dbo.Service", "VisitID", "dbo.PatientVisit");
            DropForeignKey("dbo.PartyRelationship", "RoleTypeFrom", "dbo.PersonRole");
            DropForeignKey("dbo.PartyRelationship", "RoleTypeTo", "dbo.PersonRole");
            DropForeignKey("dbo.Employee", "PersonRoleID", "dbo.PersonRole");
            DropForeignKey("dbo.PersonQualification", "PersonQualificationTypeId", "dbo.PersonQualificationType");
            DropForeignKey("dbo.PersonQualification", "PartyID", "dbo.Person");
            DropForeignKey("dbo.PersonOccupation", "FKPOMRID", "dbo.Person");
            DropForeignKey("dbo.PersonEducation", "FKPEMRID", "dbo.Person");
            DropForeignKey("dbo.PersonAddress", "FKPAMRID", "dbo.Person");
            DropForeignKey("dbo.PartySkills", "PartyID", "dbo.Person");
            DropForeignKey("dbo.Person", "PartyID", "dbo.Party");
            DropForeignKey("dbo.Organization", "PartyID", "dbo.Party");
            DropIndex("dbo.User", new[] { "PersonRoleID" });
            DropIndex("dbo.Service", new[] { "VisitID" });
            DropIndex("dbo.PatientVisit", new[] { "PersonRoleID" });
            DropIndex("dbo.Patient", new[] { "PersonRoleID" });
            DropIndex("dbo.Employee", new[] { "PersonRoleID" });
            DropIndex("dbo.PersonRole", new[] { "RoleTypeId" });
            DropIndex("dbo.PersonRole", new[] { "PartyID" });
            DropIndex("dbo.PersonQualification", new[] { "PersonQualificationTypeId" });
            DropIndex("dbo.PersonQualification", new[] { "PartyID" });
            DropIndex("dbo.PersonOccupation", new[] { "FKPOMRID" });
            DropIndex("dbo.PersonEducation", new[] { "FKPEMRID" });
            DropIndex("dbo.PartySkills", new[] { "PartyID" });
            DropIndex("dbo.Organization", new[] { "PartyID" });
            DropIndex("dbo.Person", new[] { "PartyID" });
            DropIndex("dbo.PersonAddress", new[] { "FKPAMRID" });
            DropPrimaryKey("dbo.PersonRole");
            DropPrimaryKey("dbo.Party");
            DropPrimaryKey("dbo.allelementsv");
            DropPrimaryKey("dbo.AllElements");
            AlterColumn("dbo.PersonRole", "PersonRoleID", c => c.Decimal(nullable: false, precision: 18, scale: 0, identity: true, storeType: "numeric"));
            AlterColumn("dbo.PersonOccupation", "FKPOMRID", c => c.Decimal(precision: 18, scale: 0, storeType: "numeric"));
            AlterColumn("dbo.PersonEducation", "FKPEMRID", c => c.Decimal(precision: 18, scale: 0, storeType: "numeric"));
            AlterColumn("dbo.PersonAddress", "FKPAMRID", c => c.Decimal(precision: 18, scale: 0, storeType: "numeric"));
            AlterColumn("dbo.Party", "ThruDate", c => c.DateTime());
            AlterColumn("dbo.Party", "PartyID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.allelementsv", "DataElement", c => c.String(maxLength: 150));
            AlterColumn("dbo.allelementsv", "DataSetSectionElementName", c => c.String(maxLength: 250));
            AlterColumn("dbo.allelementsv", "DataSetSectionName", c => c.String(maxLength: 250));
            AlterColumn("dbo.allelementsv", "DataSetFor", c => c.String(maxLength: 100));
            AlterColumn("dbo.allelementsv", "DataSetName", c => c.String(maxLength: 250));
            AlterColumn("dbo.allelementsv", "DataSetSectionElementShortName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.allelementsv", "DataSetSectionShortName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.allelementsv", "DataSetShortName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.AllElements", "DataElement", c => c.String(maxLength: 150));
            AlterColumn("dbo.AllElements", "DataSetSectionElementName", c => c.String(maxLength: 250));
            AlterColumn("dbo.AllElements", "DataSetSectionName", c => c.String(maxLength: 250));
            AlterColumn("dbo.AllElements", "DataSetFor", c => c.String(maxLength: 100));
            AlterColumn("dbo.AllElements", "DataSetName", c => c.String(maxLength: 250));
            AlterColumn("dbo.AllElements", "DataSetSectionElementShortName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.AllElements", "DataSetSectionShortName", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.AllElements", "DataSetShortName", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.Service", "VisitID");
            DropColumn("dbo.PersonRole", "RoleTypeId");
            DropColumn("dbo.PersonRole", "PartyID");
            DropColumn("dbo.PartyType", "PartyType");
            DropColumn("dbo.PartySkills", "PartyID");
            DropTable("dbo.sysdiagrams");
            DropTable("dbo.User");
            DropTable("dbo.PatientVisit");
            DropTable("dbo.Patient");
            DropTable("dbo.Employee");
            DropTable("dbo.PersonQualificationType");
            DropTable("dbo.PersonQualification");
            DropTable("dbo.Organization");
            DropTable("dbo.Person");
            AddPrimaryKey("dbo.PersonRole", "PersonRoleID");
            AddPrimaryKey("dbo.Party", "PartyID");
            AddPrimaryKey("dbo.allelementsv", new[] { "DSId", "DataSetShortName", "DSSID", "DataSetSectionShortName", "DSSEId", "DataSetSectionElementShortName", "DEID" });
            AddPrimaryKey("dbo.AllElements", new[] { "DSId", "DataSetShortName", "DSSID", "DataSetSectionShortName", "DSSEId", "DataSetSectionElementShortName", "DEID" });
            RenameIndex(table: "dbo.Party", name: "IX_PartyTypeID", newName: "IX_FKPPartyType");
            RenameColumn(table: "dbo.Party", name: "PartyTypeID", newName: "FKPPartyType");
            CreateIndex("dbo.Service", "FKSPartyID");
            CreateIndex("dbo.PersonRole", "FKPRMRID");
            CreateIndex("dbo.PersonRole", "FKPRPersonRoleTypeID");
            CreateIndex("dbo.PersonOccupation", "FKPOMRID");
            CreateIndex("dbo.PersonEducation", "FKPEMRID");
            CreateIndex("dbo.PersonAddress", "FKPAMRID");
            CreateIndex("dbo.PersonInfo", "FKPIPartyID");
            CreateIndex("dbo.PartySkills", "FKPSPartyId");
            CreateIndex("dbo.PartyRole", "FKPRRoleTypeId");
            CreateIndex("dbo.PartyRole", "FKPRPartyID");
            CreateIndex("dbo.PartyRelationship", "PartyIdFrom");
            CreateIndex("dbo.PartyRelationship", "PartyIdTo");
            CreateIndex("dbo.PartyQualification", "FKPQPartyQualificationTypeId");
            CreateIndex("dbo.PartyQualification", "FKPQPartyID");
            CreateIndex("dbo.PartyAddress", "FKPAPartyId");
            AddForeignKey("dbo.PartyGroup", "FKPGPartyID", "dbo.Party", "PartyID");
            AddForeignKey("dbo.Service", "FKSPartyID", "dbo.Party", "PartyID");
            AddForeignKey("dbo.PersonInfo", "FKPIPartyID", "dbo.Party", "PartyID");
            AddForeignKey("dbo.PersonRole", "FKPRMRID", "dbo.PersonInfo", "MRID");
            AddForeignKey("dbo.PersonRole", "FKPRPersonRoleTypeID", "dbo.PersonRoleType", "PersonRoleTypeID");
            AddForeignKey("dbo.PersonOccupation", "FKPOMRID", "dbo.PersonInfo", "MRID");
            AddForeignKey("dbo.PersonEducation", "FKPEMRID", "dbo.PersonInfo", "MRID");
            AddForeignKey("dbo.PersonAddress", "FKPAMRID", "dbo.PersonInfo", "MRID");
            AddForeignKey("dbo.PartySkills", "FKPSPartyId", "dbo.Party", "PartyID");
            AddForeignKey("dbo.PartyRole", "FKPRPartyID", "dbo.Party", "PartyID");
            AddForeignKey("dbo.PartyRelationship", "PartyIdTo", "dbo.Party", "PartyID");
            AddForeignKey("dbo.PartyRelationship", "PartyIdFrom", "dbo.Party", "PartyID");
            AddForeignKey("dbo.PartyRole", "FKPRRoleTypeId", "dbo.RoleType", "RoleTypeId");
            AddForeignKey("dbo.PartyRelationship", "RoleTypeTo", "dbo.PartyRole", "PartyRoleID");
            AddForeignKey("dbo.PartyRelationship", "RoleTypeFrom", "dbo.PartyRole", "PartyRoleID");
            AddForeignKey("dbo.PartyQualification", "FKPQPartyID", "dbo.Party", "PartyID");
            AddForeignKey("dbo.PartyQualification", "FKPQPartyQualificationTypeId", "dbo.PartyQualificationType", "PartyQualificationTypeID");
            AddForeignKey("dbo.PartyAddress", "FKPAPartyId", "dbo.Party", "PartyID");
        }
    }
}
