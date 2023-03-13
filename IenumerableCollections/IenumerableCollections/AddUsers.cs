using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableCollections
{
    public class AddUsers
    {
        public static List<Users> UserList = new List<Users>();

         public AddUsers() {
            Users user1= new Users();
            user1.UserName = "user1";
            user1.Password = "123";
            user1.IsAdmin= true;
            UserList.Add(user1);

            Users user2 = new Users();
            user2.UserName = "user2";
            user2.Password = "123";
            user2.IsAdmin = false;
            UserList.Add(user2);

            Users user3 = new Users();
            user3.UserName = "user3";
            user3.Password = "123";
            user3.IsAdmin = true;
            UserList.Add(user3);

            Users user4 = new Users();
            user4.UserName = "user4";
            user4.Password = "123";
            user4.IsAdmin = false;
            UserList.Add(user4);

            Users user5 = new Users();
            user5.UserName = "user5";
            user5.Password = "123";
            user5.IsAdmin = true;
            UserList.Add(user5);

        }

        public static void AddUser()
        {
            bool check = true;
            do
            {
                Users users = new Users();
                Console.WriteLine("Enter User Name");
                users.UserName= Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Enter user password");
                users.Password= Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Make user Admin ? y/n");
                string admin = Console.ReadLine();
                if(admin == "y")
                {
                    users.IsAdmin= true;
                }
                else
                {
                    users.IsAdmin= false;
                }
                UserList.Add(users);
                Console.WriteLine();
                Console.WriteLine("Add another user ? y/n");
                string choice = Console.ReadLine();
                
                if(choice ==  "n"){
                    check= false;
                }
            } while (check);
        }
        
    }
}
