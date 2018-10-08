using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks from the math: ");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks from the physics: ");
            int phys = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the marks from the chemistry: ");
            int chem = int.Parse(Console.ReadLine());

            if ((math >= 65) || (phys>=55) ||  (chem>=50))
            {
                Console.WriteLine("The students is admitted");
                Console.ReadKey();

            }else if((math+chem) >=140){
                Console.WriteLine("The students is admitted");
                Console.ReadKey();

            }else if((math + phys) >= 140)
            {
                Console.WriteLine("The students is admitted");
                Console.ReadKey();

            }else if((math + phys + chem) >= 180)
            {
                Console.WriteLine("The students is admitted");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("The students is not admitted");
                Console.ReadKey();
            }

        }
    }
}
