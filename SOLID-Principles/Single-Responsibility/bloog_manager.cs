using System;

class Blog {
    public string Title { get; set; }
    public string Author { get; set; }
    public string Content { get; set; }
}

class PostServices {
      public void createPost(Blog blog){
          Console.WriteLine("Title: " + blog.Title);
          Console.WriteLine("Author: " + blog.Author);
          Console.WriteLine("Content: " + blog.Content);
      }
}
class PostRepository {
      public void savePost(Blog blog){
          Console.WriteLine("Title: " + blog.Title);
          Console.WriteLine("Author: " + blog.Author);
          Console.WriteLine("Content: " + blog.Content);
      }
}
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