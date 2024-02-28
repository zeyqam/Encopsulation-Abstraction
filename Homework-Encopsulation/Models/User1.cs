using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Encopsulation.Models
{
    internal class User1
    {
        public string name;
        public string surname;
        public int age;
        private string password;


        public User1(string name, string surname, int age, string password)
        {
            name = name;
            surname = surname;
            age = age;
            password = password;
        }


        public void SetPassword(string newPassword)
        {
            password = newPassword;
        }
        public string GetPassword()
        {
            return password;
        }
    }
}
