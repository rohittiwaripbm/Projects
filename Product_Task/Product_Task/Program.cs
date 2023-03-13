using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;

namespace Product_Task
{



    internal class Program
    {
        
        public static List<Product> productList = new List<Product>();
        static  ProductIdList pIdList = new ProductIdList();
        

        public static int ProductId(int Product)
        {
            
            for(int i=0; i<productList.Count; i++)
            {
                if (Product == productList[i].GetProductId())
                {
                    return ProductId(Product + 1);
                }

            }

            return  Product;
            
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
        public static bool BrandIdChecker(int brandId)
        {
            
            List<int> list = pIdList.list;

            foreach (int i in list)
            {
                if (brandId == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static string NullStringChecker(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please Enter Product Name");
                string Rename = Console.ReadLine();
                return NullStringChecker(Rename);
            }
            else
            {
                if(name.Length>100)
                {
                    Console.WriteLine("Product name Can't be greater than 100");
                    string Rename = Console.ReadLine();
                    return NullStringChecker(Rename);
                }
                return name[0].ToString().ToUpper()+name.Substring(1).ToLower();
            }
        }
        public static  int NumberChecker(string strNumber)
        {
            
            int resultNumber;
            bool checker = int.TryParse(strNumber, out resultNumber);
            if (checker)
            {
                
                return resultNumber;

            }
            else
            {
                Console.WriteLine("Invalid Input, please enter valid Input");
                string reEnter = Console.ReadLine();
                return NumberChecker(reEnter);
            }
        }

        public static string UserChoice(string name)
        {
            name= name.Trim();
            if(name.Length>100)
            {
                Console.WriteLine("Invalid Input");
                string newName = Console.ReadLine();
                return UserChoice(newName);
            }
            name = name.ToLower();
            return name;
            
        }

        public static DateTime DateChecker(string strDate)
        {
            strDate = strDate.Trim();
            char[] seperator = {',', ' ', '-', '_', '/', '.', '='};
            string[] str = strDate.Split(seperator);
            if (str.Length > 3) {
                Console.WriteLine("Please Enter valid date");
                string date = Console.ReadLine();
                return DateChecker(date);
            }
            try
            {
                DateTime ManufacturingDate = DateTime.Parse(strDate);
                if(ManufacturingDate >= DateTime.Today) {
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
            catch(Exception)
            {
                Console.WriteLine("Please Enter a Valid Date");
                string Date = Console.ReadLine();
                return DateChecker(Date) ;
            }
            
        }

        public static void Display()
        {
            foreach (Product Product1 in productList)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" +
                    "♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" + " ");
                Console.ForegroundColor = ConsoleColor.White;
                //Console.WriteLine(Product1);
                Product1.displayItems();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" +
                    "♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥♥" + " ");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void AddProducts()
        {
            bool Check = true;
            int counter = 0;
            do
            {
                //Write a code for product id
                Product ProductInformation = new Product();
                Console.WriteLine("Enter Product {0}  Details ", productList.Count + 1);
                Console.WriteLine();
                Console.WriteLine("Enter Brand Id");
                int BrandId = NumberBrandChecker(Console.ReadLine());
                ProductInformation.SetBrandId(BrandId);
                
                ProductInformation.SetProductId(ProductId(productList.Count));
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
                productList.Add(ProductInformation);
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
        
        static void Main(string[] args)
        {
            AddProducts();
            SwitcheCases.UserChoice();
            
            Console.ReadLine();
        }
    }
}
