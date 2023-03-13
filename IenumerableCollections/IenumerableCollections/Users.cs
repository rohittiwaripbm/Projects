using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableCollections
{
    [Serializable]
    public class Users
    {
        public string UserName;
        public string Password;
        public bool IsAdmin = false;
        public bool IsLoggedIn = false;
    }
}