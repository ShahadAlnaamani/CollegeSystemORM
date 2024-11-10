using CollegeSystem.Repositories;
using Fluent.Infrastructure.FluentModel;

namespace CollegeSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new CollegeDbContext();

            CoursesRepository courseRepo = new CourseRepository(dbContext);  
            DepartmentsRepository deptRepo = new DepartmentsRepository(dbContext);  
            ExamsRepository examRepo = new ExamsRepository(dbContext);
            Faculty_MobileRepository FMobileRepo = new Faculty_MobileRepository(dbContext);
            FacultyRepository facultyRepo = new FacultyRepository(dbContext);
            HostelsRepository hostelsRepo = new HostelsRepository(dbContext);
            Student_PhonesRepository stPhoneRepo = new Student_PhonesRepository(dbContext);
            StudentsRepository studentsRepo = new StudentsRepository(dbContext);
            SubjectsRepository subjectsRepo = new SubjectsRepository(dbContext);


        }
    }
}
