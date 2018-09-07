namespace EatForHealth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValidationUserName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String());
        }
    }
}
