using System;


}
class User
{
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
}

class UserService
{
    public void register(User user)
    {
        // register user
        Console.WriteLine("User registered", user.name);
    }
}


