using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter W(To write the student details) or R(To read the student details)");
            String a;
            a = Convert.ToString(Console.ReadLine());
            String W = "W";
            //W = Convert.ToString(Console.ReadLine());
            if (a == W)
            {
                student ajay = new student();
                ajay.setstudent();
                ajay.getstudent();
            }
            else
            {
                staticstudent s = new staticstudent();
                s.getstaticstudent();
            }
        }
        public void getstaticstudent()
        {
            Console.WriteLine("Student details are: {0}, {1}, {2}, {3}", 1, "Ajay", "Kumar", "ajaykumar@gmail.com");
            Console.ReadKey();
        }
    }
}