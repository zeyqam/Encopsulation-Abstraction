using Homework_Encopsulation.Helpers.Constans;
using Homework_Encopsulation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Encopsulation.Controllers
{
    internal class UserController
    {
        private readonly UserService _userService;
        public UserController()
        {
            _userService = new UserService();
        }
        public void GetAll()
        {
            var users = _userService.GetAll();
            foreach (var user in users)
            {
                string result = $"{user.fullname}-{user.age}-{user.email}   ";
                Console.WriteLine(result);
            }
        }
        public void GetById()
        {
            Console.WriteLine("enter user id");
        UserId: string strId = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(strId, out id);
            if (isCorrectId)
            {
                var user = _userService.GetById(_userService.GetAll(), id);
                if (user == null)
                {
                    Console.WriteLine(ResponseMessages.NotFound);
                    return;
                }
                string result = $"{user.fullname}-{user.age}-{user.email}";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(ResponseMessages.IncorrectNumberFormat);
                goto UserId;
            }



        }
    }
}
