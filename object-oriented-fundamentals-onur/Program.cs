using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting;
using System.Text;

namespace object_oriented_fundamentals_onur
{
    class Program
    {
        static Program()
        {
            Console.WriteLine("Static Constructor...");
        }

        Program()
        {
            Console.WriteLine("Instance Constructor...");
        }
        
        static void Main(string[] args)
        {
            // Program program = new Program();
            // Boxing();

            // StringBuilder
            StringBuilder sb = new StringBuilder("This is SttringBuilder");
            Console.WriteLine(sb);
            sb.AppendLine("Today we discuss about collections...");
            Console.WriteLine(sb);
            sb.Remove(5, 10);
            Console.WriteLine(sb);

            Employ employ = new Employ();
            Console.WriteLine("Enter Employ No: ");
            employ.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name: ");
            employ.name = Console.ReadLine();
            Console.WriteLine("Enter department: ");
            employ.dept = Console.ReadLine();
            Console.WriteLine("Enter designation: ");
            employ.desig = Console.ReadLine();
            Console.WriteLine("Enter basic: ");
            employ.basic = Convert.ToInt32(Console.ReadLine());

            StringBuilderTest obj = new StringBuilderTest();
            Console.WriteLine(obj.Validate(employ));
            Console.WriteLine();
            
            
        }

        private static void Boxing()
        {
            int x = 12;
            double y = 12.5;
            string name = "Vikas";

            // Boxing
            object ob1 = x;
            object ob2 = y;
            object ob3 = name;

            // Unboxing
            int x1 = (Int32) ob1;
            double y1 = (Double) ob2;
            string s1 = (String) ob3;
        }
    }
}
