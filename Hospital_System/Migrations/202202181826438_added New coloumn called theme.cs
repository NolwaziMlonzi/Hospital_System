namespace Hospital_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedNewcoloumncalledtheme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Theme", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "Theme");
        }
    }
}
