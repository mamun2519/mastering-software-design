using System;
using System.Collections.Generic;






// interfaces










// services interfaces



public class CourseService : ICourseService {
        ICourseRepository courseRepository;
        public CourseService (ICourseRepository courseRepository){
                this.courseRepository = courseRepository;
        }
        public void AddCourse(Course course){
                courseRepository.AddCourse(course);
        }
        public void RemoveCourse(Course course){
                courseRepository.RemoveCourse(course);
        }
        public void UpdateCourse(Course course){
                courseRepository.UpdateCourse(course);
        }
        public IList<Course> GetAllCourses(){
                return courseRepository.GetAllCourses();
        }
}

// controllers
public class StudentController {
        IStudentService studentService;
        public StudentController(IStudentService studentService ){
                    this.studentService = studentService;
        }
        public void AddStudent(Student student){
                studentService.AddStudent(student);
        }
        public void RemoveStudent(Student student){
                studentService.RemoveStudent(student);
        }
        public void UpdateStudent(Student student){
                studentService.UpdateStudent(student);
        }
        public IList<Student> GetAllStudents(){
                return studentService.GetAllStudents();
        }
}

public class TrainerController {
        ITrainerService trainerService;
        public TrainerController (ITrainerService trainerService ){
                    this.trainerService = trainerService;
        }
        public void AddTrainer(Trainer trainer){
                trainerService.AddTrainer(trainer);
        }
        public void RemoveTrainer(Trainer trainer){
                trainerService.RemoveTrainer(trainer);
        }
        public void UpdateTrainer(Trainer trainer){
                trainerService.UpdateTrainer(trainer);
        }
        public IList<Trainer> GetAllTrainers(){
                return trainerService.GetAllTrainers();
        }
}

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