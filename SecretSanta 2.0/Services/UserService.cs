using SecretSanta_2._0.Interfaces;
using SecretSanta_2._0.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta_2._0.Services
{
    public class UserService : IUserService
    {
        public async Task AddUser(Person user)
        {
            using (var context = new SSContext())
            {
                context.FromList.Add(user);
                context.ToList.Add(user);
                await context.SaveChangesAsync();
            }
        }
    }
}
