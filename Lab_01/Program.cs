using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lab 01, variant 5 - Mobile subscriber information
// Ivan Hudzinskyi, Alexandr Korotetskyi, Regina Miroshnichenko
// KIUKI-17-4

namespace Lab_01
{
    class Program
    {
        static void Main()
        {
            Subscriber subscriber1;
            Subscriber subscriber2;
            Subscriber subscriber3;
            Subscriber subscriber4;

            // Constructor test
            try { subscriber1 = new Subscriber(); }
            catch(ArgumentException e)
            {
                Console.WriteLine("Error creating subscriber1!");
                Console.WriteLine(e.GetType() + " " + e.Message);
                Console.WriteLine();
            }

            try { subscriber2 = new Subscriber("0669539811", Subscriber.TariffName.Premium); }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error creating subscriber2!");
                Console.WriteLine(e.GetType() + " " + e.Message);
                Console.WriteLine();
            }

            try { subscriber3 = new Subscriber("798436"); }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error creating subscriber3!");
                Console.WriteLine(e.GetType() + " " + e.Message);
                Console.WriteLine();
            }

            try { subscriber4 = new Subscriber("06695398q1"); }
            catch (ArgumentException e)
            {
                Console.WriteLine("Error creating subscriber4!");
                Console.WriteLine(e.GetType() + " " + e.Message);
                Console.WriteLine();
            }
        }
    }
}
