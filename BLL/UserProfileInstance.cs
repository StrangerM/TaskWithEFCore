using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask5.Models;

namespace TestTask5.BLL
{
    public class UserProfileInstance : IRepository
    {
        public bool WorkWithInstance(string role)
        {
            if (role == "1")
            {
                while (true)
                {
                    Console.WriteLine("Please type phone number in format: 977519222");
                    Console.Write("=====>");
                    string result = "0" + Console.ReadLine();
                    if (result.Length == 10 && Int32.TryParse(result, out _))
                    {
                        SearchCellNumb(result);
                    }
                    else
                    {
                        Console.WriteLine("Please type phone number in correct format like: - 977519222");
                        Console.WriteLine("Try again");
                        continue;
                    }
                    return true;
                }
            }
            return true;
        }
        public void SearchCellNumb( string cellPhone)
        {
            using (UserContext db = new UserContext())
            {
                var listOfNumbers = db.UserProfile.Where(x => x.CellPhone == cellPhone).ToList();
                
                if(listOfNumbers.Count == 0)
                {
                    Console.WriteLine("-->There are no Users with such cellNumber");
                }
                else 
                {
                    var temp = db.User.Select(x => x);
                    var listOfUsers = temp.ToList().Where(x => listOfNumbers.Any(y => y.UserId == x.Id));
                    int quantity = listOfUsers.Count();
                    Console.WriteLine("-->I found {0} users with this number", quantity);
                    foreach(var item in listOfUsers)
                        Console.WriteLine("-->{0} {1}", item.Name, cellPhone);
                }
               
            }

        }


    }

}
