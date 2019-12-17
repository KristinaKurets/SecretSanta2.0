using SecretSanta_2._0.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SecretSanta_2._0.Interfaces
{
    interface IUserService
    {
        Task AddUser(Person user);
    }
}
