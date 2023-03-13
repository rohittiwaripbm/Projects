using System;
using System.Linq;
namespace IenumerableCollections
{
    public class UserChoices
    {
        public static void UserChoice(string Username)
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine(" Welcome {0}",Username);
            Console.ForegroundColor = ConsoleColor.White;
            //AddUsers user = new AddUsers();
            bool choice = true;
            do
            {
                Console.WriteLine(" Please Select an Option\n 1. Add " +
                    "Product  \n 2. Update Product \n 3. Delete Product \n 4. " +
                    "Display Active Products  \n 5. Display All products \n 6. Get Product JanamKundali" +
                    "" + "\n 7. Add New User \n 8. Logout \n 9. save \n 10. Display");
                int User_Choice = Validations.NumberChecker(Console.ReadLine());
                if (User_Choice == 1)
                {
                    ListClass.AddItems(Username);
                    Console.WriteLine();
                }
                else if (User_Choice == 2)
                {
                    Console.WriteLine("Enter Product Id");
                    int ProductId = Validations.NumberChecker(Console.ReadLine());
                    ListClass.CanUpdate(ProductId, Username);
                    Console.WriteLine();
                }
                else if (User_Choice == 3)
                {
                    Console.WriteLine("Enter Product Id");
                    int ProductId = Validations.NumberChecker(Console.ReadLine());
                    ListClass.CanDelete(ProductId, Username);
                    Console.WriteLine();
                }
                else if (User_Choice == 4)
                {

                    if (ListClass.DisplayList().Count() > 0)
                    {
                        DisplayAll.PrintWithoutDelete();
                    }
                    else
                    {
                        Console.WriteLine("No products to Display");
                    }

                    Console.WriteLine();
                }
                else if (User_Choice == 5)
                {
                    if (ListClass.DisplayList().Count() > 0)
                    {
                        DisplayAll.PrintaAll();
                    }
                    else
                    {
                        Console.WriteLine("No Products to Display");
                    }
                    Console.WriteLine();
                }
                else if (User_Choice == 6)
                {
                    Console.WriteLine("Enter Product Id");
                    int ProductId = Validations.NumberChecker(Console.ReadLine());

                    DisplayAll.DisplaySingleProducts(ProductId);
                    Console.WriteLine();
                }
                else if (User_Choice == 7)
                {
                    bool check = false;
                    foreach(var i in AddUsers.UserList)
                    {
                        if(i.UserName == Username)
                        {
                            if(i.IsAdmin == true)
                            {
                                check = true;
                                break;
                                
                            }
                        }
                    }
                    if(check)
                    {
                        AddUsers.AddUser();
                        Console.WriteLine("User Added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("You can not add new user " +
                                    "because you are not admin");
                    }
                    
                }
                else if (User_Choice == 8)
                {
                    foreach(var i in AddUsers.UserList)
                    {
                        if(i.UserName == Username)
                        {
                            i.IsLoggedIn = false;
                            Console.WriteLine("Successfully Logged Out");
                            Console.Clear();
                            TakingUsernamePassword.Sendusernamepassword();
                           
                        }
                    }
                }
                else if(User_Choice == 9)
                {
                    ListClass.SavetoFile();
                }
                else if(User_Choice == 10)
                {
                    ListClass.ReadFromFile();
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Input");
                    Console.WriteLine();
                }

            } while (choice);
        }
    }
}
