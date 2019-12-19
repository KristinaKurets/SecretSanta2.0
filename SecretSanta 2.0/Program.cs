using Microsoft.EntityFrameworkCore;
using SecretSanta_2._0.Interfaces;
using SecretSanta_2._0.Models;
using SecretSanta_2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SecretSanta_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, it's a Secret Santa app! What do you want to do? \n1 - Create new user\n2 - See the full list of participants");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    CreateUser();
                    break;
                case 2:
                    HuiPoimi();
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

        static void HuiPoimi()
        {
            using (var context = new SSContext())
            {
                var rnd = new Random();
                var user = new Person();
                var toList = context.Persons.OrderBy(x => Guid.NewGuid()).ToList();
                foreach (var person in toList)
                {
                    Console.WriteLine($"{person.Id} - {person.Name}");
                }

                int counter = 0;
                foreach (var person in context.Persons)
                {
                    person.PresentReceiver = toList[counter];
                    Console.WriteLine($"{person.Name} gives a present to {person.PresentReceiver.Name}");
                    counter++;
                }
                context.SaveChanges();

                
            }
        }
    }
}
