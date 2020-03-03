using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŠimetićNikProvjeraZnanjaZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            string unos;
            int a;
            int b;
            

            Console.WriteLine("Upisite nekoliko znakova: ");
            unos = Console.ReadLine();
            a = Convert.ToInt32(unos.Substring(0,3));
            b = Convert.ToInt32(unos.Substring(unos.Length -3, 3));
            if (unos.Length < 7) {
                Console.WriteLine("Upisali ste:" + unos);
            }
            else
            {
                Console.WriteLine("Ispis je:" + a + b );
                }
            Console.ReadKey();
            }
            
         }
    }

