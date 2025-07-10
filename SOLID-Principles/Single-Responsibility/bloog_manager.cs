using System;





class Program
{
    public static void Main(string[] args)
    {

     
        postServices.createPost(blog);
        PostRepository postRepository = new PostRepository();
        postRepository.savePost(blog);
        EmailService emailService = new EmailService();
        emailService.sendEmail(blog);
    }
}