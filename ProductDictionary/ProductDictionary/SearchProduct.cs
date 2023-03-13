using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDictionary
{
    public class SearchProduct
    {
        public static bool SearchProduct1(string id)
        {
            

            if(Program.ProductDictionary.ContainsKey(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
