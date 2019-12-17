using SecretSanta_2._0.Interfaces;
using SecretSanta_2._0.Models;
using SecretSanta_2._0.Services;
using System;

namespace SecretSanta_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, it's a Secret Santa app! What do you want to do? \n1 - Create new user");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    CreateUser();
                    break;
            }
        }
        static void CreateUser()
        {
            while (true)
            {
                Console.WriteLine("Do you want to create new user? Press y/n");
                string answer = Console.ReadLine();
                if (answer != "y") break;
                else
                {
                    var newUser = new Person();
                    Console.WriteLine("Enter your name (in english)");
                    newUser.Name = Console.ReadLine();
                    IUserService userService = new UserService();
                    userService.AddUser(newUser);
                    Console.WriteLine("Ok, I listed you.");
                }

            }
        }
    }
}
