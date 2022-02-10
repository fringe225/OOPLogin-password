using System;

namespace OOPlesson
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("UserName daxil edin: ");
            string name= Console.ReadLine();
            Console.WriteLine("Password daxil edin: ");
            string password = Console.ReadLine();
            User user = new User(name,password);

            Console.WriteLine($"Username - {user.UserName}");
            Console.WriteLine($"Password - {user.Password}");
          


        }
    }
}
