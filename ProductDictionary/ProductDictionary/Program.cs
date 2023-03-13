
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProductDictionary
{
    internal class Program
    {
        public static Dictionary<string, Product> ProductDictionary = new Dictionary<string, Product>();
        static DataContainer BrandIds = new DataContainer();
        
        public static  void AddItems()
        {
            bool Check = true;
            int counter = 0;
            do
            {
                //Write a code for product id
                Product ProductInformation = new Product();
                Console.WriteLine("Enter Product {0}  Details ", ProductDictionary.Count + 1);
                Console.WriteLine();
                Console.WriteLine("Enter Brand Id");
                int BrandId = NumberBrandChecker(Console.ReadLine());
                ProductInformation.SetBrandId(BrandId);
                string productId = ProductId(ProductDictionary.Count);
                ProductInformation.SetProductId(productId);
                Console.WriteLine();
                Console.WriteLine("Enter Product Name");
                string Pname = NullStringChecker(Console.ReadLine());
                ProductInformation.SetProductName(Pname);
                Console.WriteLine();
                Console.WriteLine("Enter Manufacturing Date");
                DateTime ManufacturingDate = DateChecker(Console.ReadLine());
                ProductInformation.SetManufacturingDate(ManufacturingDate);
                Console.WriteLine();
                Console.WriteLine("Continue Adding Product");
                
                ProductDictionary.Add(productId, ProductInformation);
                counter++;
                Console.WriteLine("Want to add another Product ? press n for No");
                string choice = Console.ReadLine();
                choice = choice.ToLower();
                if (choice == "n")
                {
                    Check = false;
                    Console.WriteLine("Thanks for using this app");

                }

            } while (Check);
            
        }

        public static string ProductId(int Product)
        {

            if(ProductDictionary.ContainsKey(Product.ToString()))
            {
                return ProductId(Product + 1);
            }
            //what is Contain in dictionary
            
            //for (int i = 0; i < ProductDictionary.Count; i++)
            //{
            //    if (Product == ProductDictionary[i].GetProductId())
            //    {
            //        return ProductId(Product + 1);
            //    }

            //}

            return Product.ToString();

        }

        public static DateTime DateChecker(string strDate)
        {
            strDate = strDate.Trim();
            char[] seperator = { ',', ' ', '-', '_', '/', '.', '=' };
            string[] str = strDate.Split(seperator);
            if (str.Length > 3)
            {
                Console.WriteLine("Please Enter valid date");
                string date = Console.ReadLine();
                return DateChecker(date);
            }
            try
            {
                DateTime ManufacturingDate = DateTime.Parse(strDate);
                if (ManufacturingDate >= DateTime.Today)
                {
                    Console.WriteLine("You cannot set Manufacturing date same as today's date Or" +
                        "More than Today's date," +
                        "Please Enter a valid Date");
                    string Date = Console.ReadLine();
                    return DateChecker(Date);
                }
                else
                {
                    return ManufacturingDate;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Enter a Valid Date");
                string Date = Console.ReadLine();
                return DateChecker(Date);
            }
        }

        public static string NullStringChecker(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please Enter Product Name");
                string Rename = Console.ReadLine();
                return NullStringChecker(Rename);
            }
            else
            {
                if (name.Length > 100)
                {
                    Console.WriteLine("Product name Can't be greater than 100");
                    string Rename = Console.ReadLine();
                    return NullStringChecker(Rename);
                }
                return name[0].ToString().ToUpper() + name.Substring(1).ToLower();
            }
        }

        public static int NumberBrandChecker(string number)
        {
            int ConvertedNumber = NumberChecker(number);
            bool a = BrandIdChecker(ConvertedNumber);
            if (a)
            {
                return ConvertedNumber;
            }
            else
            {
                Console.WriteLine("Brand Id not present, Please Enter a valid Brand Id");
                string renumber = Console.ReadLine();
                return NumberBrandChecker(renumber);
            }

        }

        private static bool BrandIdChecker(int brandid)
        {
            List<int> list = BrandIds.Data;

            foreach (int i in list)
            {
                if (brandid == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static int NumberChecker(string strNumber)
        {
            int resultNumber;
            bool checker = int.TryParse(strNumber, out resultNumber);
            if (checker)
            {

                return resultNumber;

            }
            else
            {
                Console.WriteLine("Invalid Input, please enter Brand Id");
                string reEnter = Console.ReadLine();
                return NumberChecker(reEnter);
            }
        }
        public static void Display()
        {

            foreach(KeyValuePair<string, Product> p in ProductDictionary)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" +
                    "♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" + " ");
                Console.ForegroundColor = ConsoleColor.White;
                //How to call method from another class from Dictionary;
                //Console.WriteLine(p.Value);
                //Product pro = p.Value as Product;
                //pro.displayItems();
                //extra value in to string.
                Console.WriteLine(p.Value.ToString());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" +
                    "♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }

        static void Main(string[] args)
        {
            
            AddItems();
            SwitcheCases.UserChoice();
            


        }
    }
}
