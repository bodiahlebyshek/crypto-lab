using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int cases; 
            do
            {
               
                Console.WriteLine("1) NOD");
                Console.WriteLine("2) Simple var");
                Console.WriteLine("0) Exit");
                cases = Convert.ToInt32(Console.ReadLine());
              

                switch (cases)
                {
                    case 1:
                        {
                            Console.WriteLine("                            ");
                            Console.WriteLine("A");
                            var a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("B");
                            var b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("C or press 0 to start program");
                            var c = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("                            ");
                            if (c != 0)
                            {
                                Console.WriteLine("NOD {0}, {1}, {2} = {3}", a, b, c, NOD(NOD(a, b), c));
                                Console.WriteLine("                            ");
                            }
                            else
                            {
                                Console.WriteLine("NOD {0} and {1} = {2}", a, b, NOD(a, b));
                                Console.WriteLine("                            ");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("                            ");
                            Console.WriteLine("Lower limit: ");
                            int d = int.Parse(Console.ReadLine());
                            Console.WriteLine("Upper limit: ");
                            int e = int.Parse(Console.ReadLine());
                            Console.WriteLine("                            ");
                            int count = 0;
                            for (int i = d; i <= e; i++)
                            {
                                if (SimpleVar(i))
                                {
                                    count++;
                                    Console.Write(i.ToString() + "\n");

                                }
                            }
                            Console.WriteLine("Count: " + count);
                            Console.WriteLine("                            ");
                            break;
                        }
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                }
            } while (cases != 0);

            
        }


        private static int NOD(int a, int b)
        {
            while (b != 0)
            {
                var n = b;
                b = a % b;
                a = n;
            }
            return a;
        }

        private static bool SimpleVar(int N)
        {
            for (int i = 2; i <= (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

    }
}
