namespace SaveEmployee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrationAfterGIT : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classrooms",
                c => new
                    {
                        ClassroomId = c.Int(nullable: false, identity: true),
                        ClassRoomDepartmentCode = c.String(),
                        ClassRoomCourseCode = c.String(),
                        ClassRoomRoomNo = c.String(),
                        ClassRoomWeekDay = c.String(),
                        ClassRoomStartsAt = c.Time(nullable: false, precision: 7),
                        ClassRoomEndssAt = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ClassroomId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseCode = c.String(nullable: false, maxLength: 50),
                        CourseName = c.String(nullable: false),
                        CourseCredit = c.Double(nullable: false),
                        CourseDescription = c.String(),
                        CourseDepartmentCode = c.String(nullable: false),
                        CourseSemester = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CourseCode);
            
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        CourseStudentID = c.Int(nullable: false, identity: true),
                        CourseStudentRegNo = c.String(nullable: false),
                        CourseStudentCourse = c.String(nullable: false),
                        CourseStudentRegDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CourseStudentID);
            
            CreateTable(
                "dbo.CourseTeachers",
                c => new
                    {
                        CourseTeacherID = c.Int(nullable: false, identity: true),
                        CourseTeacherDepartmentCode = c.String(nullable: false),
                        CourseTeacherEmail = c.String(nullable: false),
                        CourseTeacherCourseCode = c.String(nullable: false),
                        CourseTeacherCourseCredit = c.Double(),
                        CourseTeacherTeacherName = c.String(),
                    })
                .PrimaryKey(t => t.CourseTeacherID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentCode = c.String(nullable: false, maxLength: 7),
                        DepartmentName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentCode);
            
            CreateTable(
                "dbo.StudentResults",
                c => new
                    {
                        StudentResultRegNo = c.String(nullable: false, maxLength: 128),
                        StudentResultCourse = c.String(),
                        StudentResultGrade = c.String(),
                    })
                .PrimaryKey(t => t.StudentResultRegNo);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentRegNo = c.String(nullable: false, maxLength: 128),
                        StudentName = c.String(nullable: false),
                        StudentContact = c.String(nullable: false),
                        StudentAddress = c.String(nullable: false),
                        StudentDepartmentCode = c.String(nullable: false),
                        StudentEmail = c.String(nullable: false),
                        StudeRegDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentRegNo);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherEmail = c.String(nullable: false, maxLength: 128),
                        TeacherDesignation = c.String(nullable: false),
                        TeacherCredit = c.Double(nullable: false),
                        TeacherName = c.String(nullable: false),
                        TeacherContact = c.String(nullable: false),
                        TeacherAddress = c.String(nullable: false),
                        TeacherDepartmentCode = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherEmail);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
            DropTable("dbo.StudentResults");
            DropTable("dbo.Departments");
            DropTable("dbo.CourseTeachers");
            DropTable("dbo.CourseStudents");
            DropTable("dbo.Courses");
            DropTable("dbo.Classrooms");
        }
    }
}
