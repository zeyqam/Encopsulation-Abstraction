using Homework_Encopsulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Encopsulation.Services
{
    internal class UserService
    {
        public User[] GetAll()
        {
            return new User[]
            {
                new User()
                {

                    id = 1,
                    fullname ="Fatime Qayxanova",
                    age=22,
                    email="fatime@code.edu.az",
                    password="fatime123"
                },
                new User()
                {
                    id = 2,
                    fullname ="Fexriyye Tagiade",
                    age=21,
                    email="fexriyye@code.edu.az",
                    password="fexriyye123"
                },
                new User()
                {
                    id = 3,
                    fullname ="Emirastan Miriyev",
                    age=33,
                    email="fatime@code.edu.az",
                    password="emirastan123"
                }
            };
        }
        public User GetById(User[] users, int id)

        {
            return users.Where(m => m.id == id).FirstOrDefault();
        }



    }
}
