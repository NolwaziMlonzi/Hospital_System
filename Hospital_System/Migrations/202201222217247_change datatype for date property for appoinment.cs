namespace Hospital_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatatypefordatepropertyforappoinment : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointment", "date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Appointment", "date", c => c.Int(nullable: false));
        }
    }
}
