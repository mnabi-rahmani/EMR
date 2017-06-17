namespace WardFormsCore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class services : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ElementValues", "ServiceID", c => c.Int());
            DropColumn("dbo.ElementValues", "FKEVServiceID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ElementValues", "FKEVServiceID", c => c.Int());
            DropColumn("dbo.ElementValues", "ServiceID");
        }
    }
}
