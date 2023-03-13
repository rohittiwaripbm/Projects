using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_task2
{
    public class Person
    {
        public string Name { get; set; }
        public string Dob { get; set; }
        public char Gender { get; set; }
        public char Marital_status { get; set; }
        public string mob_number { get; set; }
        public string vehicle_number { get; set; }

        public override string ToString()
        {
            if (Gender == 'f')
            {
                if (Marital_status == 'm')
                {
                    //Console.WriteLine("|  Person Name :  Mrs. " + Name + " ");
                    Name = "Mrs. " + Name;
                }
                else
                {
                    //Console.WriteLine("|  Person Name :  Ms. " + Name + " ");
                    Name = "Ms. " + Name;
                }
            }
            else
            {
                //Console.WriteLine("|  Person Name :  Mr. " + Name + "  ");
                Name = "Mr. " + Name;
            }
            string result;
            result = " Name : " + Name + "\n Age : " + Dob + "\n Mobile Number :" + mob_number +
                "\n Vehicle Belongs to : " + vehicle_number;
            return result;
        }
    }
}
