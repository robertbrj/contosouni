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
                {
                    FirstMidName = "Carson",
                    LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01")
                },
                new Student
                {
                    FirstMidName = "Meredith",
                    LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {
                    FirstMidName = "Arturo",
                    LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01")
                },
                new Student
                {
                    FirstMidName = "Gytis",
                    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {
                    FirstMidName = "Yan",
                    LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01")
                },
                new Student
                {
                    FirstMidName = "Peggy",
                    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01")
                },
                new Student
                {
                    FirstMidName = "Laura",
                    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01")
                },
                new Student
                {
                    FirstMidName = "Nino",
                    LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01")
                }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseID = 1050, Title = "Chemistry", Credits = 3 },
                new Course { CourseID = 4022, Title = "Microeconomics", Credits = 3 },
                new Course { CourseID = 4041, Title = "Macroeconomics", Credits = 3 },
                new Course { CourseID = 1045, Title = "Calculus", Credits = 4 },
                new Course { CourseID = 3141, Title = "Trigonometry", Credits = 4 },
                new Course { CourseID = 2021, Title = "Composition", Credits = 3 },
                new Course { CourseID = 2042, Title = "Literature", Credits = 4 }
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
