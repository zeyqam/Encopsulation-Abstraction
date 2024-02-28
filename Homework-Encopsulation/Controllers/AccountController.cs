using Homework_Encopsulation.Helpers.Constans;
using Homework_Encopsulation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Encopsulation.Controllers
{
    internal class AccountController
    {
        private readonly AccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }
        public void Login()
        {
            Console.WriteLine("Add your email:");
            Email: string email=Console.ReadLine();
            if(!email.Contains("@"))
            {
                Console.WriteLine(ResponseMessages.IncorrectEmail);
                goto Email;
            }

            Console.WriteLine("Add your password:");
            string password=Console.ReadLine();

            var response = _accountService.Login(email, password);
            if (response)
            {
                Console.WriteLine(ResponseMessages.LoginSuccess);
            }
            else
            {
                Console.WriteLine(ResponseMessages.LoginFailed);
            }
        }
    }
}
