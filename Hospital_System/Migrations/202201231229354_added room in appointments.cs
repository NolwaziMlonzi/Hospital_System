namespace Hospital_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedroominappointments : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Room", "Appointment_appointmentID", "dbo.Appointment");
            DropIndex("dbo.Room", new[] { "Appointment_appointmentID" });
            AddColumn("dbo.Appointment", "Room", c => c.Int(nullable: false));
            DropColumn("dbo.Appointment", "roomID");
            DropColumn("dbo.Room", "Appointment_appointmentID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Room", "Appointment_appointmentID", c => c.Int());
            AddColumn("dbo.Appointment", "roomID", c => c.Int(nullable: false));
            DropColumn("dbo.Appointment", "Room");
            CreateIndex("dbo.Room", "Appointment_appointmentID");
            AddForeignKey("dbo.Room", "Appointment_appointmentID", "dbo.Appointment", "appointmentID");
        }
    }
}
