using System;
using System.Collections.Generic;






// interfaces










// services interfaces







public class CourseController {
        ICourseService courseService;

        public CourseController (ICourseService courseService ){
                    this.courseService = courseService;
        }
        public void AddCourse(Course course){
                courseService.AddCourse(course);
        }
        public void RemoveCourse(Course course){
                courseService.RemoveCourse(course);
        }
        public void UpdateCourse(Course course){
                courseService.UpdateCourse(course);
        }
        public IList<Course> GetAllCourses(){
                return courseService.GetAllCourses();
        }
}

class Program
{


    public static void Main(string[] args)
    {

       // Create instances of repositories and services
        Database db = new Database();
            IStudentRepository studentRepository = new StudentRepository(db);
            ITrainerRepository trainerRepository = new TrainerRepository(db);
            ICourseRepository courseRepository = new CourseRepository(db);
// Create instances of services
            IStudentService studentService = new StudentService(studentRepository);
            ITrainerService trainerService = new TrainerService(trainerRepository);
            ICourseService courseService = new CourseService(courseRepository);
// Create instances of controllers
            StudentController studentController = new StudentController(studentService);
            TrainerController trainerController = new TrainerController(trainerService);
            CourseController courseController = new CourseController(courseService);
// Add a student
            Student student = new Student { StudentId = 1, Name = "John Doe", Email = "john.doe@example.com" };
            studentController.AddStudent(student);
            Console.WriteLine("Student added successfully!");

            // get all students
            IList<Student> students = studentController.GetAllStudents();
            foreach (Student s in students){
                    Console.WriteLine(s.Name);
            }
           
          

    }
}