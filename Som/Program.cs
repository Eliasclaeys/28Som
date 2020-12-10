using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Som
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bereken de som van de gegeven getallen tot dat de gebruiker 0 invoert
            /*
             */

            int getal, som;
            som = 0; 

            Console.Write("Geef een getal in ");
            getal = int.Parse(Console.ReadLine());

            while(getal != 0)
            {
                som = som + getal;

                Console.Write("Geef een getal in ");
                 getal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"De Som van de getallen {som}");
            Console.ReadLine();

        }
    }

}
