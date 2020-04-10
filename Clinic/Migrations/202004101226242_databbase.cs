namespace Clinic.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databbase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        Date = c.String(),
                        AppointmentType_Id = c.Int(),
                        Patient_PatientId = c.Int(),
                    })
                .PrimaryKey(t => t.AppointmentId)
                .ForeignKey("dbo.AppointmentTypes", t => t.AppointmentType_Id)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .Index(t => t.AppointmentType_Id)
                .Index(t => t.Patient_PatientId);
            
            CreateTable(
                "dbo.AppointmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AppointmentTypeForPatient = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        PatientId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Phone = c.String(),
                        IsExamined = c.Boolean(nullable: false),
                        Address = c.String(),
                        Order = c.Int(nullable: false),
                        Age = c.Double(nullable: false),
                        GenderId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsEntered = c.Boolean(nullable: false),
                        Assistant_AssistantId = c.Int(),
                        Doctor_DoctorId = c.Int(),
                    })
                .PrimaryKey(t => t.PatientId)
                .ForeignKey("dbo.Genders", t => t.GenderId, cascadeDelete: true)
                .ForeignKey("dbo.Assistants", t => t.Assistant_AssistantId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId)
                .Index(t => t.GenderId)
                .Index(t => t.Assistant_AssistantId)
                .Index(t => t.Doctor_DoctorId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GenderType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Assistants",
                c => new
                    {
                        AssistantId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Phone = c.String(),
                        Salary = c.Single(nullable: false),
                        Gender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.AssistantId)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .Index(t => t.Gender_Id);
            
            CreateTable(
                "dbo.Clinics",
                c => new
                    {
                        ClinicId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ClinicId);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        DoctorId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Phone = c.String(),
                        Position = c.String(),
                        DOB = c.String(),
                        Qualification = c.String(),
                        Gender_Id = c.Int(),
                    })
                .PrimaryKey(t => t.DoctorId)
                .ForeignKey("dbo.Genders", t => t.Gender_Id)
                .Index(t => t.Gender_Id);
            
            CreateTable(
                "dbo.Prescriptions",
                c => new
                    {
                        PrescriptionId = c.Int(nullable: false, identity: true),
                        DescriptionOfTheCase = c.String(),
                        Clinic_ClinicId = c.Int(),
                        Doctor_DoctorId = c.Int(),
                        Patient_PatientId = c.Int(),
                    })
                .PrimaryKey(t => t.PrescriptionId)
                .ForeignKey("dbo.Clinics", t => t.Clinic_ClinicId)
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId)
                .ForeignKey("dbo.Patients", t => t.Patient_PatientId)
                .Index(t => t.Clinic_ClinicId)
                .Index(t => t.Doctor_DoctorId)
                .Index(t => t.Patient_PatientId);
            
            CreateTable(
                "dbo.Medicines",
                c => new
                    {
                        MedicineId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ConcentrationOfTheDrug = c.Int(nullable: false),
                        StartDate = c.String(),
                        FinishDate = c.String(),
                        Quantity = c.Int(nullable: false),
                        TimesPerDay = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Prescription_PrescriptionId = c.Int(),
                    })
                .PrimaryKey(t => t.MedicineId)
                .ForeignKey("dbo.Prescriptions", t => t.Prescription_PrescriptionId)
                .Index(t => t.Prescription_PrescriptionId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Premission = c.String(),
                        UserId = c.Int(nullable: false),
                        PermissionPnl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DoctorClinics",
                c => new
                    {
                        Doctor_DoctorId = c.Int(nullable: false),
                        Clinic_ClinicId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Doctor_DoctorId, t.Clinic_ClinicId })
                .ForeignKey("dbo.Doctors", t => t.Doctor_DoctorId, cascadeDelete: true)
                .ForeignKey("dbo.Clinics", t => t.Clinic_ClinicId, cascadeDelete: true)
                .Index(t => t.Doctor_DoctorId)
                .Index(t => t.Clinic_ClinicId);
            
            CreateTable(
                "dbo.UserPermissions",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Permissions_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Permissions_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Permissions", t => t.Permissions_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Permissions_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserPermissions", "Permissions_Id", "dbo.Permissions");
            DropForeignKey("dbo.UserPermissions", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Prescriptions", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Medicines", "Prescription_PrescriptionId", "dbo.Prescriptions");
            DropForeignKey("dbo.Prescriptions", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Prescriptions", "Clinic_ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.Patients", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Doctors", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.DoctorClinics", "Clinic_ClinicId", "dbo.Clinics");
            DropForeignKey("dbo.DoctorClinics", "Doctor_DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Patients", "Assistant_AssistantId", "dbo.Assistants");
            DropForeignKey("dbo.Assistants", "Gender_Id", "dbo.Genders");
            DropForeignKey("dbo.Patients", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Appointments", "Patient_PatientId", "dbo.Patients");
            DropForeignKey("dbo.Appointments", "AppointmentType_Id", "dbo.AppointmentTypes");
            DropIndex("dbo.UserPermissions", new[] { "Permissions_Id" });
            DropIndex("dbo.UserPermissions", new[] { "User_Id" });
            DropIndex("dbo.DoctorClinics", new[] { "Clinic_ClinicId" });
            DropIndex("dbo.DoctorClinics", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.Medicines", new[] { "Prescription_PrescriptionId" });
            DropIndex("dbo.Prescriptions", new[] { "Patient_PatientId" });
            DropIndex("dbo.Prescriptions", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.Prescriptions", new[] { "Clinic_ClinicId" });
            DropIndex("dbo.Doctors", new[] { "Gender_Id" });
            DropIndex("dbo.Assistants", new[] { "Gender_Id" });
            DropIndex("dbo.Patients", new[] { "Doctor_DoctorId" });
            DropIndex("dbo.Patients", new[] { "Assistant_AssistantId" });
            DropIndex("dbo.Patients", new[] { "GenderId" });
            DropIndex("dbo.Appointments", new[] { "Patient_PatientId" });
            DropIndex("dbo.Appointments", new[] { "AppointmentType_Id" });
            DropTable("dbo.UserPermissions");
            DropTable("dbo.DoctorClinics");
            DropTable("dbo.Users");
            DropTable("dbo.Permissions");
            DropTable("dbo.Medicines");
            DropTable("dbo.Prescriptions");
            DropTable("dbo.Doctors");
            DropTable("dbo.Clinics");
            DropTable("dbo.Assistants");
            DropTable("dbo.Genders");
            DropTable("dbo.Patients");
            DropTable("dbo.AppointmentTypes");
            DropTable("dbo.Appointments");
        }
    }
}
