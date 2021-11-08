namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_sha512 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "AdminPassword", c => c.String(maxLength: 128));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Admins", "AdminPassword", c => c.String(maxLength: 50));
        }
    }
}
