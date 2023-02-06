using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattens
{
    class Program
    {
        static void Main(string[] args)
        {
           int no=int.Parse(Console.ReadLine());
          // pattern1(no);
          // pattern2(no);
          // patten3(no);
         //  Console.WriteLine(pattern4(no));
            //Console.WriteLine(pattern5(no));
           Console.WriteLine(c(no));
        
        }

        public static string pattern5(int n)
        {
            string temp = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j--)
                {
                    if (i - j == 1)
                    {
                        temp += " ";
                    }
                    temp += "#";
                }
                temp += "\n";

            } return temp;
        }




        public static string c(int n)
        {
            string temp = "";
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                for ( s = 1; s <= i -1; s++)
                {
                    temp += "  ";
                }
                    for (int c = s ; c <= n; c++)
                    {
                        temp += "# ";
                    }
                
                temp += "\n";
            }
            return temp;
        }



        public static string pattern4(int n)
        {
            
            string temp = "";
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= (n - i) + 1; j++)
                {
                    temp+="#";
                }
                temp+="\n";
            }
            return temp;
        }




        public static void patten3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        public static void pattern2(int n)
        {
            for (int r = 1; r <= n; r++)
            {
                if (r % 2 == 0)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <= n ; c++)
                {
                    Console.Write("# ");
                } Console.WriteLine();
            }

        }


        public static void pattern1(int n)
        {
            
          
            for (int r = 1; r <=n; r++)
            {
                for (int c = 1; c <= n; c++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("\n");
            }
            
        }
                   

        
        
    }
}
