using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();

            Question2.question2();
            Question3.question3();
            Question4.question4();
            Question5.question5();
        }
        
    }
    public class Question2
    {

        public static void question2()
        {
            int a = 76;
            int b = 34;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadLine();

        }
    }
    public class Question3
    {
        public static void question3()
        {
            Console.WriteLine("Input a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input a number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 * num2);
            Console.ReadLine();
        }
    }
    public class Question4
    {
        public static void question4()
        {
            string fname;
            string lname;
            Console.WriteLine("Input first name");
            fname = Console.ReadLine();
            Console.WriteLine("Input last name");
            lname = Console.ReadLine();
            Console.WriteLine(fname + " " + lname);
            Console.ReadLine();



        }
    }
    public class Question5
    {
        public static void question5()
        {
        }
    }
}
