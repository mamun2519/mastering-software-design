using System;
using System.Collections.Generic;






// interfaces





// repositories
public class StudentRepository : IStudentRepository {
        Database db;
        public StudentRepository(Database db){
                this.db = db;
        }

        public void AddStudent(Student student){
                db.Students.Add(student);
        }
        public void RemoveStudent(Student student){
                db.Students.Remove(student);
        }
        public void UpdateStudent(Student student){
                db.Students[db.Students.IndexOf(student)] = student;
        }
        public IList<Student> GetAllStudents(){
                return db.Students;
        }
}

public class TrainerRepository : ITrainerRepository {
        Database db;
        public TrainerRepository(Database db){
                this.db = db;
        }
        public void AddTrainer(Trainer trainer){
                db.Trainers.Add(trainer);
        }
        public void RemoveTrainer(Trainer trainer){
                db.Trainers.Remove(trainer);
        }
        public void UpdateTrainer(Trainer trainer){
                db.Trainers[db.Trainers.IndexOf(trainer)] = trainer;
        }
        public IList<Trainer> GetAllTrainers(){
                return db.Trainers;
        }
}

public class CourseRepository : ICourseRepository {
        Database db;
        public CourseRepository(Database db){
                this.db = db;
        }
        public void AddCourse(Course course){
                db.Courses.Add(course);
        }
        public void RemoveCourse(Course course){
                db.Courses.Remove(course);
        }
        public void UpdateCourse(Course course){
                db.Courses[db.Courses.IndexOf(course)] = course;
        }
        public IList< Course> GetAllCourses(){
                return db.Courses;
        }
}


// services interfaces
public interface IStudentService {
        void AddStudent(Student student);
        void RemoveStudent(Student student);
        void UpdateStudent(Student student);
        IList<Student> GetAllStudents();
}
public interface ITrainerService {
        void AddTrainer(Trainer trainer);
        void RemoveTrainer(Trainer trainer);
        void UpdateTrainer(Trainer trainer);
        IList<Trainer> GetAllTrainers();
}

public interface ICourseService {
        void AddCourse(Course course);
        void RemoveCourse(Course course);
        void UpdateCourse(Course course);
        IList<Course> GetAllCourses();
}

// services
public class StudentService : IStudentService {
        IStudentRepository studentRepository;
        public StudentService (IStudentRepository studentRepository){
                this.studentRepository = studentRepository;
        }

        public void AddStudent(Student student){
                studentRepository.AddStudent(student);
        }
        public void RemoveStudent(Student student){
                studentRepository.RemoveStudent(student);
        }
        public void UpdateStudent(Student student){
                studentRepository.UpdateStudent(student);
        }
        public IList<Student> GetAllStudents(){
                return studentRepository.GetAllStudents();
        }
}

public class TrainerService : ITrainerService {
        ITrainerRepository trainerRepository;
        public TrainerService (ITrainerRepository trainerRepository){
                this.trainerRepository = trainerRepository;
        }
        public void AddTrainer(Trainer trainer){
                trainerRepository.AddTrainer(trainer);
        }
        public void RemoveTrainer(Trainer trainer){
                trainerRepository.RemoveTrainer(trainer);
        }
        public void UpdateTrainer(Trainer trainer){
                trainerRepository.UpdateTrainer(trainer);
        }
        public IList<Trainer> GetAllTrainers(){
                return trainerRepository.GetAllTrainers();
        }
}

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