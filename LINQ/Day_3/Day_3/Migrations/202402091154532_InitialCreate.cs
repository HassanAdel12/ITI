namespace Day_3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DepartmentID = c.Int(nullable: false),
                        Name = c.String(),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Department", t => t.DepartmentID, cascadeDelete: true)
                .Index(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SchoolID = c.Int(nullable: false),
                        Name = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        NationalID = c.String(),
                        Code = c.Int(nullable: false),
                        Job = c.String(),
                        Phone = c.String(),
                        Qualification = c.String(),
                        QualificationDate = c.DateTime(nullable: false),
                        HiringDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.SchoolID, cascadeDelete: true)
                .Index(t => t.SchoolID);
            
            CreateTable(
                "dbo.TeacherTransfere",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TeacherID = c.Int(nullable: false),
                        FromSchoolID = c.Int(),
                        ToSchoolID = c.Int(),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teacher", t => t.TeacherID, cascadeDelete: true)
                .ForeignKey("dbo.School", t => t.FromSchoolID)
                .ForeignKey("dbo.School", t => t.ToSchoolID)
                .Index(t => t.TeacherID)
                .Index(t => t.FromSchoolID)
                .Index(t => t.ToSchoolID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeacherTransfere", "ToSchoolID", "dbo.School");
            DropForeignKey("dbo.TeacherTransfere", "FromSchoolID", "dbo.School");
            DropForeignKey("dbo.TeacherTransfere", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.Teacher", "SchoolID", "dbo.School");
            DropForeignKey("dbo.School", "DepartmentID", "dbo.Department");
            DropIndex("dbo.TeacherTransfere", new[] { "ToSchoolID" });
            DropIndex("dbo.TeacherTransfere", new[] { "FromSchoolID" });
            DropIndex("dbo.TeacherTransfere", new[] { "TeacherID" });
            DropIndex("dbo.Teacher", new[] { "SchoolID" });
            DropIndex("dbo.School", new[] { "DepartmentID" });
            DropTable("dbo.TeacherTransfere");
            DropTable("dbo.Teacher");
            DropTable("dbo.School");
            DropTable("dbo.Department");
        }
    }
}
