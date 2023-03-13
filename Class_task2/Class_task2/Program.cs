using System;
using System.Collections.Generic;

namespace Class_task2
{
   
    internal class Program
    {
        public static string DobError(string message)
        {
            string newMessage = "";
            char[] seperator = { '!', '@', '#', ',', '.', '/', '-', '=', '*', '&', '^', '%', ';', '$' , '`' };
            string[] dateSeperator = message.Split(seperator);
            foreach(string s in dateSeperator)
            {
                newMessage = newMessage + s + " "; 
            }
            //Console.WriteLine(newMessage);
            DateTime date;
            try
            {
               date = DateTime.Parse(newMessage);
                DateTime TodayDate = DateTime.Today;

                TimeSpan tp = TodayDate - date;

                int age = (tp.Days / 365);
                return age.ToString();
            }
            catch
            {
                Console.WriteLine("Invalid date, plese Enter a valid date : ");
                string ReDate = Console.ReadLine();
                return DobError(ReDate);
            }
        }


        public static string NamingError(string User_name)
        {
            User_name= User_name.Trim();
            int continue_counter = 0;
            string first_name, last_name, full_name;
            //string name = "roHit tiwari";
            if (User_name.Length<=0)
            {
                Console.WriteLine("Invalid or empty Name, Please Enter  Name again ");
                string name1 = Console.ReadLine();
                return NamingError(name1);
            }
            int Space_counter1=0, Space_counter2=0,counter =0;
            for(int i = 0; i<User_name.Length; i++)
            {
                if (User_name[i]== ' ')
                {
                    Space_counter1++;

                }
                else
                {
                    if (Space_counter1 > 0)
                    {
                        counter++;
                        Space_counter2 = Space_counter1;
                        Space_counter1 = 0;
                        if(counter>2)
                        {
                            break;
                        }
                    }
                }
            }
            if(counter<2)
            {
                if(!User_name.Contains(" "))
                {
                    full_name = (char.ToUpper(User_name[0])).ToString()+ User_name.Substring(1);
                    return full_name;
                }
                //Console.WriteLine("Continue spaces");
                string[] splited_name1 = User_name.Split(' ');
                string[] first_name1 = new string[2];
                
                foreach(string i in splited_name1)
                {
                    if(i.Length>0)
                    {
                        first_name1[continue_counter] = i;
                        continue_counter++;

                    }
                }
                first_name = first_name1[0];
                last_name = first_name1[1];
                full_name = (char.ToUpper(first_name[0]).ToString() + first_name.Substring(1).ToLower()) + " "
                + (char.ToUpper(last_name[0]).ToString() + last_name.Substring(1).ToLower());

                return full_name;

            }

            else
            {

                string[] splited_name = User_name.Split(' ');
                if (splited_name.Length > 2)
                {
                    Console.WriteLine("Please Enter First and Last Name only ");
                    string name1 = Console.ReadLine();
                    return NamingError(name1);

                }



                first_name = splited_name[0];
                last_name = splited_name[1];
                full_name = (char.ToUpper(first_name[0]).ToString() + first_name.Substring(1).ToLower()) + " "
                    + (char.ToUpper(last_name[0]).ToString() + last_name.Substring(1).ToLower());
                //Console.WriteLine(full_name);
                return full_name;

            }



        }

        public static string GenderError(string User_gender)
        {
            
            if(User_gender.Length ==  1)
            {
                User_gender = User_gender.ToLower();
                if (User_gender != "f" && User_gender != "m")
                {
                    Console.WriteLine("Please Enter a valid input m / f");
                    string input_gender = Console.ReadLine();
                    return GenderError(input_gender);
                }
                else
                {
                    return User_gender;
                }


            }

            else
            {
                Console.WriteLine("Please Enter Valid gender m/f");
                string gender = Console.ReadLine();
                return GenderError(gender);

            }

            

        }

        public static string MaritalError(string user_status)
        {
            if (user_status.Length == 1)
            {
                user_status = user_status.ToLower();
                if (user_status != "m" && user_status != "u")
                {
                    Console.WriteLine("Please Enter a valid input m / u");
                    string input_gender = Console.ReadLine();
                    return GenderError(input_gender);
                }
                else
                {
                    return user_status;
                }
            }
            else
            {
                Console.WriteLine("Please Enter Valid Marital status m / u");
                string status = Console.ReadLine();
                return MaritalError(status);

            }

            
        }
        

        public static string MobileError(string user_number)
        {
            string save_number = "(";
            if(user_number.Length !=10)
            {
                Console.WriteLine("Invalid Mobile number, Please Enter a Valid Mobile number ");
                string number = Console.ReadLine();
                return MobileError(number);
            }
            else
            {
                
                
                bool Number_int = true;
                for(int i =0; i<user_number.Length;i++)
                {
                   
                    Number_int = int.TryParse(user_number[i].ToString(), out int result);
                    if (Number_int ==  false) {
                        Console.WriteLine("Plese Enter a Valid Mobile number");
                        string number = Console.ReadLine();
                        return MobileError(number);

                    }
                    if (int.Parse(user_number[0].ToString()) <= 5)
                    {
                        Console.WriteLine("Number cannot start with {0}, Please " +
                            "Enter a valid mobile number ", user_number[0].ToString());
                        string number = Console.ReadLine();
                        return MobileError(number);
                    }
                    save_number = save_number + user_number[i].ToString();
                    if (i==2)
                    {
                        save_number = save_number + ")";
                    }
                    if(i==5)
                    {
                        save_number = save_number + "-";
                    }

                    
                }


                return save_number;

            }


            //user_number = string.Format("({0}){1}-{2}", user_number.Substring(0, 3), user_number.Substring(3, 3),
             //   user_number.Substring(6));

           
        }

        public static string VehicleNumberPlate(string user_vehicle_number) {
            
            Dictionary<string, string> States = new Dictionary<string, string>{ { "RJ", "Rajasthan"},
                                                                                {"MH", "Maharashtra"},
                                                                                {"TN", "Tamil Nadu" },
                                                                                {"HR", "Haryana"},
                                                                                {"DL", "Delhi"},
                                                                                {"JK", "Jammu & Kashmir" } };

            if(user_vehicle_number.Length!=13)
            {
                Console.WriteLine("Invalid Number Plate, Please enter again");
                string number = Console.ReadLine();
                return VehicleNumberPlate(number);



            }
            else
            {
                for(int i = 0; i<4; i++)
                {
                    bool lastFourDigits = int.TryParse(user_vehicle_number[((user_vehicle_number.Length - 1) - i)].ToString(), out int result);
                    if(lastFourDigits ==  false)
                    {
                        Console.WriteLine("Invalid Number Plate, Please enter again");
                        string number = Console.ReadLine();
                        return VehicleNumberPlate(number);
                    }
                }
                string first_number = user_vehicle_number[0].ToString() + user_vehicle_number[1].ToString();
                first_number = first_number.ToUpper();
                bool Check = States.ContainsKey(first_number);
                if (Check)
                {
                    
                    return States[first_number];
                }
                else
                {
                    Console.WriteLine("Please Enter a valid Vehicle Number ");
                    string number = Console.ReadLine();
                    return VehicleNumberPlate(number);
                }

               
                
            }
            

        }
        static void Main(string[] args)
        {

            


            List<Person> list = new List<Person>();
            bool user_choice = true;
            

            do
            {
                Person person = new Person();
                Console.WriteLine("     Please Enter " + (list.Count+1) + " Person Details");
                
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------------------------");
                Console.WriteLine("Enter Name here");
                person.Name = NamingError(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Enter Date of Birth") ;
                person.Dob = DobError(Console.ReadLine());
                Console.WriteLine() ;
                Console.WriteLine("Please Enter  Gender :  M - Male /F - Female");
                person.Gender = char.Parse(GenderError(Console.ReadLine()));
                Console.WriteLine();
                Console.WriteLine("Please Enter Marital Status : M - Married / U - Unmarried ");
                person.Marital_status = char.Parse(MaritalError(Console.ReadLine())) ;
                Console.WriteLine() ;
                Console.WriteLine("Enter  Mobile number");
                person.mob_number= MobileError(Console.ReadLine()) ;
                Console.WriteLine() ;
                Console.WriteLine("Please Enter  Vehicle Nuber Plate");
                person.vehicle_number= VehicleNumberPlate(Console.ReadLine()) ;

                list.Add(person);
               
                //Console.WriteLine(person);

                Console.WriteLine();
                Console.WriteLine("Want to Add Another person ? press n for No");
                string choice = Console.ReadLine();
                choice = choice.ToLower() ;
                if (choice == "n")
                {
                    user_choice = false;
                    Console.WriteLine("Thanks for using this app");

                }
                

            } while (user_choice);

            foreach (var item in list)
            {

                //Console.WriteLine("----------------------------------");
                //if(item.Gender=='f')
                //{
                //     if(item.Marital_status == 'm')
                //    {
                //        Console.WriteLine("|  Person Name :  Mrs. " + item.Name + " ");
                //    }
                //     else
                //    {
                //        Console.WriteLine("|  Person Name :  Ms. " + item.Name + " ");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("|  Person Name :  Mr. " + item.Name + "  ");
                //}

                //Console.WriteLine("|  Date of Birth :" + item.Dob + "  ");
                //Console.WriteLine("|Mobile Number :   " + item.mob_number + "  ");

                //Console.WriteLine("|Vehicle Belongs to :  " + item.vehicle_number + " ");

                Console.WriteLine("----------------------------------");
                Console.WriteLine();

                Console.WriteLine(item);

                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                Console.WriteLine();


            }

            Console.ReadLine();

        }
    }
}
