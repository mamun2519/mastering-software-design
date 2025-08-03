using System;
using System.Collections.Generic;






// interfaces










// services interfaces
class Program
{


    public static void Main(string[] args)
    {

       // Create instances of repositories and services
        
// Create instances of services
   
// Create instances of controllers
           
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