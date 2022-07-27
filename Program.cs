using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public int divide(int a, int b)
        {
            return a / b;
        }

        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Please Enter two numbers\n");
            string s1=Console.ReadLine();
            string s2 = Console.ReadLine();
            a= Convert.ToInt32(s1);
            b= Convert.ToInt32(s2);
            Console.WriteLine("Enter operator\n");
            string s3 = Console.ReadLine();
            char ch=Convert.ToChar(s3);
            Program ob = new Program();
            switch (ch)
            {
                case '+' :
                    Console.WriteLine(ob.add(a,b));
                    break;
                case '-' :
                    Console.WriteLine(ob.subtract(a, b));
                    break ;
                case '*' :
                    Console.WriteLine(ob.multiply(a,b));
                    break;
                case '/' :
                    Console.WriteLine(ob.divide(a,b));
                    break;
                    default : Console.WriteLine("Invalid Operator\n");
                    break;
            }

            Console.ReadLine();

           
        }
    }
}
