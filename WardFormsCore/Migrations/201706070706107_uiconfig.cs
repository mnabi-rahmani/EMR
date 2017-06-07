namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uiconfig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DataSetUIconfig",
                c => new
                    {
                        DSUIID = c.Int(nullable: false, identity: true),
                        data_row = c.Int(nullable: false),
                        data_col = c.Int(nullable: false),
                        data_sizex = c.Int(nullable: false),
                        data_sizey = c.Int(nullable: false),
                        DataElementStatus = c.Boolean(),
                        DSSEId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DSUIID)
                .ForeignKey("dbo.DataSetSectionElement", t => t.DSSEId, cascadeDelete: true)
                .Index(t => t.DSSEId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DataSetUIconfig", "DSSEId", "dbo.DataSetSectionElement");
            DropIndex("dbo.DataSetUIconfig", new[] { "DSSEId" });
            DropTable("dbo.DataSetUIconfig");
        }
    }
}
