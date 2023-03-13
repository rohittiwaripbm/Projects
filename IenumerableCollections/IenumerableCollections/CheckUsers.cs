using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableCollections
{
    public class CheckUsers
    {
        public  bool CheckExistingUsers(string username, string password)
        {
            AddUsers users = new AddUsers();
            foreach (var i in AddUsers.UserList)
            {
                if(i.UserName == username && i.Password == password)
                {
                    i.IsLoggedIn= true;

                    return true;
                }
            }

            return false;
        }
    }
}
