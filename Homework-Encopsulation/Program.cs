using Homework_Encopsulation.Controllers;
using Homework_Encopsulation.Models;

//UserController userController = new();
//userController.GetAll();
//userController.GetById();
//AccountController accountController = new AccountController();
//accountController.Login();
User1 user1 = new User1("Arif", "Abiyev", 30, "password123");
Console.WriteLine("Current Password: " + user1.GetPassword());
user1.SetPassword("newPassword456");
Console.WriteLine("New Password: " + user1.GetPassword());
Console.ReadLine();