using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask5.Models;

namespace TestTask5.BLL
{

    public class UserInstance : IRepository
    {
        public bool WorkWithInstance(string role)
        {
            if (role == "2")
            {
                while (true)
                {
                    Console.WriteLine("--->Enter user Name:");
                    Console.Write("=====>");
                    string userName = Console.ReadLine();
                    if (string.IsNullOrEmpty(userName))
                    {
                        Console.WriteLine("Name can not be empty.");
                        Console.WriteLine("Try again.");
                        continue;
                    }
                    Console.WriteLine("--->Enter User Login:");
                    Console.Write("=====>");
                    string userLogin = Console.ReadLine();
                    if (string.IsNullOrEmpty(userLogin))
                    {
                        Console.WriteLine("User Login can not be empty.");
                        Console.WriteLine("Try again.");
                        continue;
                    }
                    string password = CreateRandomPassword();
                    StoreUserInDB(userName, userLogin, password);
                    Console.WriteLine("--->user pass:{0}", password);
                    return true;
                }

            }
            return true;
        }
        private static string CreateRandomPassword(int length = 9)
        {

            string validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
            Random random = new Random();

            char[] chars = new char[length];
            for (int i = 0; i < length; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }

        public void StoreUserInDB(string userName, string userLogin, string password)
        {
            using (UserContext db = new UserContext()) 
            {
                User user = new User { Login = userLogin, Name = userName, Password = password };
                db.User.Add(user);
                db.SaveChanges();
            }
            
                Console.WriteLine("--->User created successfylly!");
        }
    }

}
