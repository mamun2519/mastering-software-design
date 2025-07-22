using System;

//bed code
class User
{
    public string CheckUserType(int code)
    {
        if (code == 1)
        {
            return "Student";
        }
        else if (code == 2)
        {
            return "Teacher";
        }
        else if (code == 3)
        {
            return "Admin";
        }
        else
        {
            return "Unknown";
        }
    }
}
// good code

class GoodUser {

        
        public string CheckUserType(int code){
                    return code switch
                    {
                        1 => "Student",
                        2 => "Teacher",
                        3 => "Admin",
                        _ => "Unknown"
                    };
        }
}

class Program
{
    public static void Main(string[] args)
    {
    // bed code
    User user = new User();
            Console.WriteLine(user.CheckUserType(1));

            // good code
            GoodUser goodUser = new GoodUser();
            Console.WriteLine(goodUser.CheckUserType(1));

    }
}