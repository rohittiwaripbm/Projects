using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Policy;

namespace IenumerableCollections
{  

    public class ListClass
    {
        private static List<Product>ProductList = new List<Product>();
        public static IEnumerable<Product> DisplayList()
        {
            return ProductList.AsEnumerable();
        }
        public static void AddItems(string Username)
        {
            bool Check = true;  
            int counter = 0;
            do
            {
                Console.WriteLine("Enter Product Details ");
                Console.WriteLine();
                Product product = new Product();
                product.Username = Username;
                Console.WriteLine("Enter Product Id");
                product.ProductId = Validations.NumberBrandChecker(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Product Name");
                product.ProductName = Validations.StringChecker(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Product Price");
                product.ProductPrice = Validations.DecimalChecker(Console.ReadLine()); 
                Console.WriteLine();
                ProductList.Add(product);
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
        public static void SavetoFile()
        {
            List<Product> products = ProductList;
            IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            Stream stream1 = new FileStream("C:\\Users\\rohit\\Desktop\\New folder (3)\\products.txt", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            formatter.Serialize(stream1, products);
            stream1.Close();

        }
        public static void ReadFromFile()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("C:\\Users\\rohit\\Desktop\\New folder (3)\\products.txt", FileMode.Open, FileAccess.Read);
            List<Product> products = (List<Product>)formatter.Deserialize(stream);
            stream.Close();
            foreach(Product product in products )
            {
                Console.WriteLine(product.ProductName); Console.WriteLine(product.ProductPrice);
                Console.WriteLine(product.Username);
            }
        }
        private static int GetIndex(int id)
        {
            int counter = 0, index = 0;
            foreach (Product product in ProductList)
            {
                if (product.ProductId == id)
                {
                    index = counter;
                    break;
                }
                counter++;
            }
            return index;
        }
        private static bool CheckafterDelete(int id)
        {
            bool check = ContainsProductId(id);
            if (check)
            {
                int counter = GetIndex(id);

                if (ProductList[counter].DeleteStatus)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        private static bool ContainsProductId(int id)
        {
            foreach(var i in ProductList)
            {
                if(i.ProductId == id)
                {
                    return true;
                    
                }
            }
            return false;
        }
        public static void CanUpdate(int id, string Username)
        {
            bool Deleted = CheckafterDelete(id);
            bool check = ContainsProductId(id);
            int counter1 = ProductList.Count-1, index1 = 0;
            if (check && Deleted == true)
            {
                Product p = new Product();
                //Finding last updated product in the list;
                int Last_updated = ProductList.Count - 1;
                for (int i = Last_updated; i>0; i--)
                {
                   if (ProductList[i].ProductId == id)
                    {
                        index1 = counter1;
                        break;
                    }
                    counter1--;
                }
                
                ProductList[index1].ProductEndDate = DateTime.Now;
                p.ProductStartDate= (DateTime)ProductList[index1].ProductEndDate;
                ProductList[index1].Updated = false ;
                p.ProductId = id;
                p.Username = Username;
                Console.WriteLine("Enter Product name");
                p.ProductName = Validations.StringChecker(Console.ReadLine());
                Console.WriteLine("Enter Product Price");
                p.ProductPrice = Validations.DecimalChecker(Console.ReadLine()); 
                ProductList.Add(p);
            }
            else
            {
                Console.WriteLine("Product not Present");
            }
        }
        public static void CanDelete(int id, string Username)
        {
            bool Delete = ContainsProductId(id);
            bool Check = CheckafterDelete(id);
            if (Delete && Check == true)
            {
                int index = GetIndex(id);
                foreach (var i in ProductList)
                {

                    if (i.ProductId == id)
                    {
                        i.DeleteStatus = true;
                        i.ProductDeleteDate = DateTime.Now;
                        i.DeleteProductUsername = Username;
                    }
                }
                Console.WriteLine("Product Deleted Successfully");
            }
            else
            {
                Console.WriteLine("Product not found");
            }
        }
    }
}
