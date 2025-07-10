using System;





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