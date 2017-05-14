namespace Njinx.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedProfileImage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserProfiles", "ProfileImage", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserProfiles", "ProfileImage");
        }
    }
}
