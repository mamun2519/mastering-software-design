using System;




class EmailService {
      public void sendEmail(Blog blog){
          Console.WriteLine("Title: " + blog.Title);
          Console.WriteLine("Author: " + blog.Author);
          Console.WriteLine("Content: " + blog.Content);
      }
}
class Program
{
    public static void Main(string[] args)
    {

     
        Blog blog = new Blog{ Title = "My Blog", Author = "Juboraj Islam Mamun", Content = "This is my blog" };
        PostServices postServices = new PostServices();
        postServices.createPost(blog);
        PostRepository postRepository = new PostRepository();
        postRepository.savePost(blog);
        EmailService emailService = new EmailService();
        emailService.sendEmail(blog);
    }
}