namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdf : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DataSetSectionElement", "FKDSSEDataSetSectionID", "dbo.DataSetSection");
            DropColumn("dbo.DataSetSectionElement", "FKDSSEDataelementID");
            RenameColumn(table: "dbo.DataSetSectionElement", name: "DataElement_DEID", newName: "FKDSSEDataelementID");
            RenameColumn(table: "dbo.PartyRelationship", name: "PartyIdTo", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.PartyRelationship", name: "PartyIdFrom", newName: "PartyIdTo");
            RenameColumn(table: "dbo.PartyRelationship", name: "RoleTypeTo", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.PartyRelationship", name: "RoleTypeFrom", newName: "RoleTypeTo");
            RenameColumn(table: "dbo.PartyRelationship", name: "__mig_tmp__0", newName: "PartyIdFrom");
            RenameColumn(table: "dbo.PartyRelationship", name: "__mig_tmp__1", newName: "RoleTypeFrom");
            RenameIndex(table: "dbo.DataSetSectionElement", name: "IX_DataElement_DEID", newName: "IX_FKDSSEDataelementID");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_PartyIdFrom", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_RoleTypeFrom", newName: "__mig_tmp__1");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_PartyIdTo", newName: "IX_PartyIdFrom");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_RoleTypeTo", newName: "IX_RoleTypeFrom");
            RenameIndex(table: "dbo.PartyRelationship", name: "__mig_tmp__0", newName: "IX_PartyIdTo");
            RenameIndex(table: "dbo.PartyRelationship", name: "__mig_tmp__1", newName: "IX_RoleTypeTo");
            AddForeignKey("dbo.DataSetSectionElement", "FKDSSEDataSetSectionID", "dbo.DataSetSection", "DSSID");
            DropColumn("dbo.DataElement", "FKDEDataSetSectionElementID");
            DropColumn("dbo.DataElement", "DataSetSectionElement_DSSEId");
            DropTable("dbo.sysdiagrams");
        }
        
        public override void Down()
        {
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
            
            AddColumn("dbo.DataElement", "DataSetSectionElement_DSSEId", c => c.Int());
            AddColumn("dbo.DataElement", "FKDEDataSetSectionElementID", c => c.Int());
            DropForeignKey("dbo.DataSetSectionElement", "FKDSSEDataSetSectionID", "dbo.DataSetSection");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_RoleTypeTo", newName: "__mig_tmp__1");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_PartyIdTo", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_RoleTypeFrom", newName: "IX_RoleTypeTo");
            RenameIndex(table: "dbo.PartyRelationship", name: "IX_PartyIdFrom", newName: "IX_PartyIdTo");
            RenameIndex(table: "dbo.PartyRelationship", name: "__mig_tmp__1", newName: "IX_RoleTypeFrom");
            RenameIndex(table: "dbo.PartyRelationship", name: "__mig_tmp__0", newName: "IX_PartyIdFrom");
            RenameIndex(table: "dbo.DataSetSectionElement", name: "IX_FKDSSEDataelementID", newName: "IX_DataElement_DEID");
            RenameColumn(table: "dbo.PartyRelationship", name: "RoleTypeFrom", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.PartyRelationship", name: "PartyIdFrom", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.PartyRelationship", name: "RoleTypeTo", newName: "RoleTypeFrom");
            RenameColumn(table: "dbo.PartyRelationship", name: "__mig_tmp__1", newName: "RoleTypeTo");
            RenameColumn(table: "dbo.PartyRelationship", name: "PartyIdTo", newName: "PartyIdFrom");
            RenameColumn(table: "dbo.PartyRelationship", name: "__mig_tmp__0", newName: "PartyIdTo");
            RenameColumn(table: "dbo.DataSetSectionElement", name: "FKDSSEDataelementID", newName: "DataElement_DEID");
            AddColumn("dbo.DataSetSectionElement", "FKDSSEDataelementID", c => c.Int());
            AddForeignKey("dbo.DataSetSectionElement", "FKDSSEDataSetSectionID", "dbo.DataSetSection", "DSSID", cascadeDelete: true);
        }
    }
}
