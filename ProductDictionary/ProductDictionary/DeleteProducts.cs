using ProductDictionary;
using System;
using System.Collections.Generic;


namespace ProductDictionary
{
    public class DeleteProduct
    {
        public static void DeleteProductMethod()
        {
            Console.WriteLine("Enter Product Id");
            int DprodutId = Program.NumberChecker(Console.ReadLine());
            Console.WriteLine();

            bool CanDelete = false;
            int counter = 0;
            if(Program.ProductDictionary.ContainsKey(DprodutId.ToString()))
            {
                CanDelete = true;

            }
            if (CanDelete)
            {
                Program.ProductDictionary.Remove(DprodutId.ToString());
                
                Console.WriteLine("Product Deleted Successfully");

            }
            else
            {
                Console.WriteLine("Product Id not Present");
            }
        }
    }
}
