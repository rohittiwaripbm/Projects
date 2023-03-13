using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableCollections
{
    public class TakingUsernamePassword
    {
        


        public static void Sendusernamepassword()
        {
            bool choice = true;
            
            do
            {
                Console.WriteLine(" Enter Username");
                string username = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(" Enter Password");
                string password = Console.ReadLine();
                CheckUsers Cuser = new CheckUsers();
                bool Check = Cuser.CheckExistingUsers(username, password);
                if (Check)
                {
                    Console.WriteLine("User Varified");
                    choice = false;
                    UserChoices.UserChoice(username);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid User please enter a valid username and password");
                    Console.WriteLine();
                }
            } while (choice);

        }
    }
}
