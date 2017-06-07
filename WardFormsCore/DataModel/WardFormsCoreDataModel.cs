namespace WardFormsCore.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WardFormsCoreDataModel : DbContext
    {
        public WardFormsCoreDataModel()
            : base("name=WardFormsCoreDataModel")
        {
        }

        public virtual DbSet<AllElement> AllElements { get; set; }
        public virtual DbSet<allelementsv> allelementsvs { get; set; }


        public virtual DbSet<DataSetUIconfig> datasetUIconfig { get; set; }
        public virtual DbSet<DataClassfication> DataClassfications { get; set; }
        public virtual DbSet<DataElement> DataElements { get; set; }
        public virtual DbSet<DataSetSection> DataSetSections { get; set; }
        public virtual DbSet<DataSetSectionElement> DataSetSectionElements { get; set; }
        public virtual DbSet<DataSetTbl> DataSetTbls { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<ElementValue> ElementValues { get; set; }
        public virtual DbSet<Facility> Facilities { get; set; }
        public virtual DbSet<FacilityContactMechanisim> FacilityContactMechanisims { get; set; }
        public virtual DbSet<FacilityContactMechanisimPurpose> FacilityContactMechanisimPurposes { get; set; }
        public virtual DbSet<FacilityContent> FacilityContents { get; set; }
        public virtual DbSet<FacilityGroup> FacilityGroups { get; set; }
        public virtual DbSet<FacilityGroupMember> FacilityGroupMembers { get; set; }
        public virtual DbSet<FacilityGroupRole> FacilityGroupRoles { get; set; }
        public virtual DbSet<FacilityGroupType> FacilityGroupTypes { get; set; }
        public virtual DbSet<FacilityLocationGeoPiont> FacilityLocationGeoPionts { get; set; }
        public virtual DbSet<FacilityParty> FacilityParties { get; set; }
        public virtual DbSet<FacilityRole> FacilityRoles { get; set; }
        public virtual DbSet<FacilityType> FacilityTypes { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<PartyAddress> PartyAddresses { get; set; }
        public virtual DbSet<PartyGroup> PartyGroups { get; set; }
        public virtual DbSet<PartyQualification> PartyQualifications { get; set; }
        public virtual DbSet<PartyQualificationType> PartyQualificationTypes { get; set; }
        public virtual DbSet<PartyRelationship> PartyRelationships { get; set; }
        public virtual DbSet<PartyRelationshipType> PartyRelationshipTypes { get; set; }
        public virtual DbSet<PartyRole> PartyRoles { get; set; }
        public virtual DbSet<PartySkill> PartySkills { get; set; }
        public virtual DbSet<PartyType> PartyTypes { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonEducation> PersonEducations { get; set; }
        public virtual DbSet<PersonInfo> PersonInfoes { get; set; }
        public virtual DbSet<PersonOccupation> PersonOccupations { get; set; }
        public virtual DbSet<PersonRole> PersonRoles { get; set; }
        public virtual DbSet<PersonRoleType> PersonRoleTypes { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<PurposeType> PurposeTypes { get; set; }
        public virtual DbSet<Refer> Refers { get; set; }
        public virtual DbSet<RoleType> RoleTypes { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<SkillType> SkillTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataClassfication>()
                .Property(e => e.DataClassfication1)
                .IsUnicode(false);

            modelBuilder.Entity<DataClassfication>()
                .Property(e => e.DataClassficationFor)
                .IsUnicode(false);

            modelBuilder.Entity<DataClassfication>()
                .HasMany(e => e.DataElements)
                .WithOptional(e => e.DataClassfication)
                .HasForeignKey(e => e.FKDEDataSetClassficationID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DataElement>()
                .Property(e => e.DataElement1)
                .IsUnicode(false);

            modelBuilder.Entity<DataElement>()
                .HasMany(e => e.DataSetSectionElements)
                .WithOptional(e => e.DataElement)
                .HasForeignKey(e => e.FKDSSEDataelementID);

            modelBuilder.Entity<DataElement>()
                .HasMany(e => e.ElementValues)
                .WithOptional(e => e.DataElement)
                .HasForeignKey(e => e.FKEVDataElementID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DataSetSection>()
                .Property(e => e.DataSetSectionShortName)
                .IsUnicode(false);

            modelBuilder.Entity<DataSetSection>()
                .Property(e => e.DataSetSectionName)
                .IsUnicode(false);

            modelBuilder.Entity<DataSetSection>()
                .HasMany(e => e.DataSetSectionElements)
                .WithOptional(e => e.DataSetSection)
                .HasForeignKey(e => e.FKDSSEDataSetSectionID);

            modelBuilder.Entity<DataSetSectionElement>()
                .Property(e => e.DataSetSectionElementShortName)
                .IsUnicode(false);

            modelBuilder.Entity<DataSetSectionElement>()
                .Property(e => e.DataSetSectionElementName)
                .IsUnicode(false);

            modelBuilder.Entity<DataSetTbl>()
                .Property(e => e.DataSetShortName)
                .IsFixedLength();

            modelBuilder.Entity<DataSetTbl>()
                .Property(e => e.DataSetName)
                .IsFixedLength();

            modelBuilder.Entity<DataSetTbl>()
                .Property(e => e.DataSetFor)
                .IsUnicode(false);

            modelBuilder.Entity<DataSetTbl>()
                .HasMany(e => e.DataSetSections)
                .WithOptional(e => e.DataSetTbl)
                .HasForeignKey(e => e.FKDSSDataSetID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<DataSetTbl>()
                .HasMany(e => e.Refers)
                .WithOptional(e => e.DataSetTbl)
                .HasForeignKey(e => e.ReferWardTo);

            modelBuilder.Entity<DataSetTbl>()
                .HasMany(e => e.Services)
                .WithOptional(e => e.DataSetTbl)
                .HasForeignKey(e => e.FKSWardID);

            modelBuilder.Entity<District>()
                .Property(e => e.District1)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .HasMany(e => e.Facilities)
                .WithOptional(e => e.District)
                .HasForeignKey(e => e.FKFDisctictCode);

            modelBuilder.Entity<District>()
                .HasMany(e => e.PartyAddresses)
                .WithOptional(e => e.District)
                .HasForeignKey(e => e.PartyAddressDistrict);

            modelBuilder.Entity<District>()
                .HasMany(e => e.PersonAddresses)
                .WithOptional(e => e.District1)
                .HasForeignKey(e => e.District);

            modelBuilder.Entity<Facility>()
                .Property(e => e.FacilityName)
                .IsUnicode(false);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityContactMechanisims)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.FKFCMFacilityID);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityContents)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.FKFCFacilityID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityGroups)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.FKFGFacilityID);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityLocationGeoPionts)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.FKFLGPFacilityID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityParties)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.FKFPFacilityID);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.FacilityRoles)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.FKFRFacilityID);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.Refers)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.ReferTo);

            modelBuilder.Entity<Facility>()
                .HasMany(e => e.Services)
                .WithOptional(e => e.Facility)
                .HasForeignKey(e => e.FKSFacillityID);

            modelBuilder.Entity<FacilityContactMechanisim>()
                .HasMany(e => e.FacilityContactMechanisimPurposes)
                .WithOptional(e => e.FacilityContactMechanisim)
                .HasForeignKey(e => e.FKFCMPFCMID);

            modelBuilder.Entity<FacilityContactMechanisimPurpose>()
                .Property(e => e.ContactPurposeType)
                .IsUnicode(false);

            modelBuilder.Entity<FacilityContent>()
                .Property(e => e.FacilityContent1)
                .IsUnicode(false);

            modelBuilder.Entity<FacilityGroup>()
                .Property(e => e.FacilityGroup1)
                .IsUnicode(false);

            modelBuilder.Entity<FacilityGroup>()
                .HasMany(e => e.FacilityGroupMembers)
                .WithOptional(e => e.FacilityGroup)
                .HasForeignKey(e => e.FKFGMFacilityID);

            modelBuilder.Entity<FacilityGroup>()
                .HasMany(e => e.FacilityGroupRoles)
                .WithOptional(e => e.FacilityGroup)
                .HasForeignKey(e => e.FKFGRFacilityGroupID);

            modelBuilder.Entity<FacilityGroupType>()
                .Property(e => e.FacilityGroupType1)
                .IsUnicode(false);

            modelBuilder.Entity<FacilityGroupType>()
                .HasMany(e => e.FacilityGroups)
                .WithOptional(e => e.FacilityGroupType)
                .HasForeignKey(e => e.FKFGFacilityGroupTypeID);

            modelBuilder.Entity<FacilityLocationGeoPiont>()
                .Property(e => e.Lat)
                .IsUnicode(false);

            modelBuilder.Entity<FacilityLocationGeoPiont>()
                .Property(e => e.Lan)
                .IsUnicode(false);

            modelBuilder.Entity<FacilityType>()
                .Property(e => e.FacilityType1)
                .IsUnicode(false);

            modelBuilder.Entity<FacilityType>()
                .HasMany(e => e.Facilities)
                .WithRequired(e => e.FacilityType)
                .HasForeignKey(e => e.FKFFacilityTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.PartyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartyAddresses)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.FKPAPartyId);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartyGroups)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.FKPGPartyID);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartyQualifications)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.FKPQPartyID);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartyRelationships)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.PartyIdFrom);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartyRelationships1)
                .WithOptional(e => e.Party1)
                .HasForeignKey(e => e.PartyIdTo);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartyRoles)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.FKPRPartyID);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PartySkills)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.FKPSPartyId);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.PersonInfoes)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.FKPIPartyID);

            modelBuilder.Entity<Party>()
                .HasMany(e => e.Services)
                .WithOptional(e => e.Party)
                .HasForeignKey(e => e.FKSPartyID);

            modelBuilder.Entity<PartyGroup>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<PartyQualification>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<PartyQualificationType>()
                .Property(e => e.QualificationType)
                .IsUnicode(false);

            modelBuilder.Entity<PartyQualificationType>()
                .HasMany(e => e.PartyQualifications)
                .WithOptional(e => e.PartyQualificationType)
                .HasForeignKey(e => e.FKPQPartyQualificationTypeId);

            modelBuilder.Entity<PartyRelationship>()
                .Property(e => e.PartyRelationshipDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PartyRelationship>()
                .Property(e => e.RelationshipName)
                .IsUnicode(false);

            modelBuilder.Entity<PartyRelationshipType>()
                .Property(e => e.PartyRelationshipTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PartyRole>()
                .Property(e => e.PartyRoleDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PartyRole>()
                .HasMany(e => e.PartyRelationships)
                .WithOptional(e => e.PartyRole)
                .HasForeignKey(e => e.RoleTypeFrom);

            modelBuilder.Entity<PartyRole>()
                .HasMany(e => e.PartyRelationships1)
                .WithOptional(e => e.PartyRole1)
                .HasForeignKey(e => e.RoleTypeTo);

            modelBuilder.Entity<PartySkill>()
                .Property(e => e.Skill)
                .IsUnicode(false);

            modelBuilder.Entity<PartyType>()
                .Property(e => e.PartyTypeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PartyType>()
                .HasMany(e => e.Parties)
                .WithOptional(e => e.PartyType)
                .HasForeignKey(e => e.FKPPartyType);

            modelBuilder.Entity<PersonAddress>()
                .Property(e => e.AddressType)
                .IsUnicode(false);

            modelBuilder.Entity<PersonAddress>()
                .Property(e => e.FKPAMRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PersonEducation>()
                .Property(e => e.FKPEMRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PersonInfo>()
                .Property(e => e.MRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PersonInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PersonInfo>()
                .Property(e => e.FatherName)
                .IsUnicode(false);

            modelBuilder.Entity<PersonInfo>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PersonInfo>()
                .Property(e => e.SocialSecurityNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PersonInfo>()
                .Property(e => e.PassportNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PersonInfo>()
                .HasMany(e => e.PersonAddresses)
                .WithOptional(e => e.PersonInfo)
                .HasForeignKey(e => e.FKPAMRID);

            modelBuilder.Entity<PersonInfo>()
                .HasMany(e => e.PersonEducations)
                .WithOptional(e => e.PersonInfo)
                .HasForeignKey(e => e.FKPEMRID);

            modelBuilder.Entity<PersonInfo>()
                .HasMany(e => e.PersonOccupations)
                .WithOptional(e => e.PersonInfo)
                .HasForeignKey(e => e.FKPOMRID);

            modelBuilder.Entity<PersonInfo>()
                .HasMany(e => e.PersonRoles)
                .WithOptional(e => e.PersonInfo)
                .HasForeignKey(e => e.FKPRMRID);

            modelBuilder.Entity<PersonOccupation>()
                .Property(e => e.FKPOMRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PersonRole>()
                .Property(e => e.PersonRoleID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PersonRole>()
                .Property(e => e.FKPRMRID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PersonRoleType>()
                .Property(e => e.PersonRoleType1)
                .IsUnicode(false);

            modelBuilder.Entity<PersonRoleType>()
                .HasMany(e => e.PersonRoles)
                .WithOptional(e => e.PersonRoleType)
                .HasForeignKey(e => e.FKPRPersonRoleTypeID);

            modelBuilder.Entity<Province>()
                .Property(e => e.Province1)
                .IsUnicode(false);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Districts)
                .WithOptional(e => e.Province)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Province>()
                .HasMany(e => e.Facilities)
                .WithOptional(e => e.Province)
                .HasForeignKey(e => e.FKFProvinceCode);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.PartyAddresses)
                .WithOptional(e => e.Province)
                .HasForeignKey(e => e.PartyAddressProvince);

            modelBuilder.Entity<Province>()
                .HasMany(e => e.PersonAddresses)
                .WithOptional(e => e.Province1)
                .HasForeignKey(e => e.Province);

            modelBuilder.Entity<PurposeType>()
                .Property(e => e.Purpose)
                .IsUnicode(false);

            modelBuilder.Entity<PurposeType>()
                .HasMany(e => e.Services)
                .WithOptional(e => e.PurposeType)
                .HasForeignKey(e => e.Purpose);

            modelBuilder.Entity<RoleType>()
                .Property(e => e.RoleType1)
                .IsUnicode(false);

            modelBuilder.Entity<RoleType>()
                .HasMany(e => e.PartyRoles)
                .WithOptional(e => e.RoleType)
                .HasForeignKey(e => e.FKPRRoleTypeId);

            modelBuilder.Entity<Service>()
                .HasMany(e => e.Refers)
                .WithOptional(e => e.Service)
                .HasForeignKey(e => e.ReferFrom);

            modelBuilder.Entity<SkillType>()
                .Property(e => e.SkillDescription)
                .IsUnicode(false);

            modelBuilder.Entity<SkillType>()
                .HasMany(e => e.PartySkills)
                .WithOptional(e => e.SkillType)
                .HasForeignKey(e => e.FKPSSkillTypeId);
        }
    }
}
