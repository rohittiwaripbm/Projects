using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IenumerableCollections
{
    public class Validations
    {
        public static int  NumberBrandChecker(string number)
        {
            int a = NumberChecker(number);
            bool b = BrandChecker(a);
            if(b)
            {
                Console.WriteLine("Brand Id not available, please Enter a new Brand Id");
                string number1 = Console.ReadLine();
                return NumberBrandChecker(number1);
            }
            else
            {
                return a;
            }
        }
        public static int NumberChecker(string number)
        {
            bool Check = int.TryParse(number, out int result);
            if(Check) { 
                return result;
            }
            else
            {
                Console.WriteLine("Please Enter a Valid Input");
                string number1 = Console.ReadLine();
                return NumberChecker(number1);
            }
        }

        public static bool BrandChecker(int number)
        {
            bool check = false;
            foreach(var i in ListClass.DisplayList())
            {
                if(i.ProductId== number)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        public static string StringChecker(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please Enter a valid input");
                string number = Console.ReadLine();
                return StringChecker(number);
            }
            else
            {
                return name[0].ToString().ToUpper()+name.Substring(1);
            }
        }

        public static decimal DecimalChecker(string number) 
        { 
            bool check = decimal.TryParse(number, out decimal result);
            if (check)
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please Enter a valid Input");
                string decimal1 = Console.ReadLine();
                return DecimalChecker(decimal1);
            }
        }
    }
}
