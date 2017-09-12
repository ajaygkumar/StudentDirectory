using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDirectory
{
    class student
    {

        int id;
        string firstname;
        string lastname;
        string emailid;
        public void setstudent()
        { 
            Console.WriteLine("Enter the Student ID:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First Name:");
            firstname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Last Name:");
            lastname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Email ID:");
            emailid = Convert.ToString(Console.ReadLine());
        }
        public void getstudent()
        {
            Console.WriteLine("Student details are: {0}, {1}, {2}, {3}", id, firstname, lastname, emailid);
            Console.ReadKey();
        }
    }
}
