namespace Hospital_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointment",
                c => new
                    {
                        appointmentID = c.Int(nullable: false),
                        patientID = c.Int(nullable: false),
                        date = c.String(),
                        Room = c.Int(nullable: false),
                        doctorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.appointmentID);
            
            CreateTable(
                "dbo.Doctor",
                c => new
                    {
                        doctorID = c.Int(nullable: false),
                        doctorFullName = c.String(),
                        doctorPhysicalAddress = c.String(),
                        doctorPhoneNumber = c.String(),
                        qualification = c.String(),
                        gender = c.String(),
                    })
                .PrimaryKey(t => t.doctorID);
            
            CreateTable(
                "dbo.Patient",
                c => new
                    {
                        patientID = c.Int(nullable: false),
                        patientFullName = c.String(),
                        patientAge = c.Int(nullable: false),
                        patientGender = c.String(),
                        patientPhysicalAddress = c.String(),
                        date = c.String(),
                        patientContactNumber = c.String(),
                        patientRoomNumber = c.String(),
                    })
                .PrimaryKey(t => t.patientID);
            
            CreateTable(
                "dbo.Permission",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Add = c.Boolean(nullable: false),
                        Edit = c.Boolean(nullable: false),
                        Delete = c.Boolean(nullable: false),
                        View = c.Boolean(nullable: false),
                        Module = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        roleID = c.Int(nullable: false, identity: true),
                        roleName = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.roleID);
            
            CreateTable(
                "dbo.Room",
                c => new
                    {
                        roomID = c.Int(nullable: false),
                        RoomNumber = c.String(),
                        roomType = c.String(),
                    })
                .PrimaryKey(t => t.roomID);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        userID = c.Int(nullable: false),
                        userName = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        role = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.userID);
            
            CreateTable(
                "dbo.AppointmentDoctor",
                c => new
                    {
                        Appointment_appointmentID = c.Int(nullable: false),
                        Doctor_doctorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Appointment_appointmentID, t.Doctor_doctorID })
                .ForeignKey("dbo.Appointment", t => t.Appointment_appointmentID, cascadeDelete: true)
                .ForeignKey("dbo.Doctor", t => t.Doctor_doctorID, cascadeDelete: true)
                .Index(t => t.Appointment_appointmentID)
                .Index(t => t.Doctor_doctorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppointmentDoctor", "Doctor_doctorID", "dbo.Doctor");
            DropForeignKey("dbo.AppointmentDoctor", "Appointment_appointmentID", "dbo.Appointment");
            DropIndex("dbo.AppointmentDoctor", new[] { "Doctor_doctorID" });
            DropIndex("dbo.AppointmentDoctor", new[] { "Appointment_appointmentID" });
            DropTable("dbo.AppointmentDoctor");
            DropTable("dbo.User");
            DropTable("dbo.Room");
            DropTable("dbo.Role");
            DropTable("dbo.Permission");
            DropTable("dbo.Patient");
            DropTable("dbo.Doctor");
            DropTable("dbo.Appointment");
        }
    }
}
