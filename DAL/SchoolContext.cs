using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Course>().ToTable("Course");

            modelBuilder.Entity<Student>().HasData(
                new Student
                {   StudentID = 1,
                    FirstMidName = "Carson",
                    LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01")
                },
                new Student
                {
                    StudentID = 2,
                    FirstMidName = "Meredith",
                    LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {   StudentID = 3,
                    FirstMidName = "Arturo",
                    LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01")
                },
                new Student
                {   StudentID = 4,
                    FirstMidName = "Gytis",
                    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {StudentID = 5,
                    FirstMidName = "Yan",
                    LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {StudentID = 6,
                    FirstMidName = "Peggy",
                    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01")
                },
                new Student
                {StudentID = 7,
                    FirstMidName = "Laura",
                    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01")
                },
                new Student
                {StudentID = 8,
                    FirstMidName = "Nino",
                    LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01")
                }
            );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {   
                    InstructorID = 1,
                    FirstMidName = "Kim",
                    LastName = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11")
                },
                new Instructor
                {
                    InstructorID = 2,
                    FirstMidName = "Fadi",
                    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06")
                },
                new Instructor
                {InstructorID = 3,
                    FirstMidName = "Roger",
                    LastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01")
                },
                new Instructor
                {InstructorID = 4,
                    FirstMidName = "Candace",
                    LastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15")
                },
                new Instructor
                {   InstructorID = 5,
                    FirstMidName = "Roger",
                    LastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12")
                }
                );

            modelBuilder.Entity<Department>().HasData(
                new Department
                {   
                    DepartmentID = 1,
                    Name = "English",
                    Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = 1
                },
                new Department
                {
                    DepartmentID = 2,
                    Name = "Mathematics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = 2
                },
                new Department
                {
                    DepartmentID = 3,
                    Name = "Engineering",
                    Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = 3
                },
                new Department
                {
                    DepartmentID = 4,
                    Name = "Economics",
                    Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID = 4
                }
                );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseID = 1050, Title = "Chemistry", Credits = 3,DepartmentID = 3, Instructors = new List<Instructor>() },
                new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3, DepartmentID = 4,Instructors = new List<Instructor>() },
                new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3, DepartmentID = 4,Instructors = new List<Instructor>() },
                new Course { CourseID = 1045, Title = "Calculus", Credits = 4, DepartmentID = 2,Instructors = new List<Instructor>() },
                new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4, DepartmentID = 2,Instructors = new List<Instructor>() },
                new Course { CourseID = 2021, Title = "Composition", Credits = 3, DepartmentID = 1,Instructors = new List<Instructor>() },
                new Course { CourseID = 2042, Title = "Literature", Credits = 4,DepartmentID =  1,Instructors = new List<Instructor>() }
            );

            modelBuilder.Entity<OfficeAssignment>().HasData(
                    new OfficeAssignment
                    {
                        InstructorID = 1,
                        Location = "Smith 17"
                    },
                new OfficeAssignment
                {
                    InstructorID = 2,
                    Location = "Gowan 27"
                },
                new OfficeAssignment
                {
                    InstructorID = 3,
                    Location = "Thompson 304"
                }
                );

            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { EnrollmentID = 1, StudentID = 1, CourseID = 1050, Grade = Grade.A },
                new Enrollment { EnrollmentID = 2, StudentID = 1, CourseID = 4022, Grade = Grade.C },
                new Enrollment { EnrollmentID = 3, StudentID = 1, CourseID = 4041, Grade = Grade.B },
                new Enrollment { EnrollmentID = 4, StudentID = 2, CourseID = 1045, Grade = Grade.B },
                new Enrollment { EnrollmentID = 5, StudentID = 2, CourseID = 3141, Grade = Grade.B },
                new Enrollment { EnrollmentID = 6, StudentID = 2, CourseID = 2021, Grade = Grade.B },
                new Enrollment { EnrollmentID = 7, StudentID = 3, CourseID = 1050 },
                new Enrollment { EnrollmentID = 8, StudentID = 3, CourseID = 4022, Grade = Grade.B },
                new Enrollment { EnrollmentID = 9, StudentID = 4, CourseID = 1050, Grade = Grade.B },
                new Enrollment { EnrollmentID = 10, StudentID = 5, CourseID = 2021, Grade = Grade.B },
                new Enrollment { EnrollmentID = 11, StudentID = 6, CourseID = 2042, Grade = Grade.B }
            );
        }
    }
}
