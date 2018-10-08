using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I wanna calculate something for you, please input the first digit: ");
            int x;
           if(int.TryParse(Console.ReadLine(), out x)) {

                if ((x > 10) || (x < 0))
                {
                    Console.WriteLine("Sorry, i support only digits from 0 to 10 :( ");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Thank's and another digit please! ");
                    int y;

                  if(int.TryParse(Console.ReadLine(), out y))
                    {
                        if(y>10 || y < 0)
                        {
                            Console.WriteLine("Sorry, i support only digits from 0 to 10 :( ");
                            Console.ReadKey();
                        }
                        else
                        {
                            int c = x * y;
                            Console.WriteLine("Here you are: " + c);
                            Console.ReadKey(); 
                        }

                    }
                    else
                    {
                        Console.WriteLine("Sorry, i don't know how to multiply chars :( ");
                        Console.ReadKey();
                    }
                    

                }



            }
            else
            {
                Console.WriteLine("Sorry, i don't know how to multiply chars :( ");
                Console.ReadKey();
            }
            
               
            
        }
    }
}
