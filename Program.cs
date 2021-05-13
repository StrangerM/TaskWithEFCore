using System;
using TestTask5.BLL;

namespace TestTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======console app=======");
            Console.WriteLine("-->Hello!");
            IRepository userProf = new UserProfileInstance();
            IRepository user = new UserInstance();

            while (true)
            {
                Console.WriteLine("-->1 -search user, 2 - create new");
                Console.WriteLine("-->What do You want to do?");
                Console.Write("=====>");

                string role = Console.ReadLine();

                userProf.WorkWithInstance(role);
                user.WorkWithInstance(role);

            }
        }

    }
}

