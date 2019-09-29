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
        static void PrintSubscriber(Subscriber subscriber)
        {
            Console.WriteLine("Phone number: " + subscriber.PhoneNumber);
            Console.WriteLine("Tariff: " + subscriber.CurrentTariff);
            Console.WriteLine("Cost per minute: " + subscriber.MinuteTalkCost);
            Console.WriteLine("Balance: " + subscriber.Balance);

            Console.WriteLine("Call history:");
            string[] callHistory = subscriber.CallHistory;

            if (callHistory.Count() == 0)
                Console.WriteLine("    empty");
            else
                foreach (var item in callHistory)
                    Console.WriteLine("    " + item);

            Console.WriteLine("Active services:");
            string[] activeServices = subscriber.ActiveServices;
            Console.Write("    ");

            if (activeServices.Count() == 0)
                Console.WriteLine("none");
            else
            {
                for (int i = 0; i < activeServices.Count() - 1; i++)
                    Console.Write(activeServices[i] + ", ");
                Console.Write(activeServices[activeServices.Count() - 1]);
            }
            Console.WriteLine();
        }

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

            Console.WriteLine();

            // Instantiating objects that pass the test
            subscriber1 = new Subscriber();
            subscriber2 = new Subscriber("0669539811", Subscriber.TariffName.Premium);

            // Properties test
            Console.WriteLine("Subscriber 1:");
            PrintSubscriber(subscriber1);

            Console.WriteLine("Subscriber 2:");
            PrintSubscriber(subscriber2);

            Console.WriteLine();

            // Tariff change test
            subscriber1.ChangeTariff(Subscriber.TariffName.Premium);
            Console.WriteLine("Subscriber 1:");
            PrintSubscriber(subscriber1);

            subscriber2.ChangeTariff(Subscriber.TariffName.Premium_plus);
            Console.WriteLine("Subscriber 2:");
            PrintSubscriber(subscriber2);

            Console.WriteLine();

            // Balance replenish test
            Console.WriteLine("Adding 150 to subscriber1's balance...");
            subscriber1.ReplenishBalance(150.0f);
            Console.WriteLine("Subscriber1's balance: {0}\n", subscriber1.Balance);

            Console.WriteLine("Adding 300 to subscriber2's balance...");
            subscriber2.ReplenishBalance(300.0f);
            Console.WriteLine("Subscriber2's balance: {0}\n", subscriber2.Balance);

            Console.WriteLine();

            // Calling test
            Console.WriteLine("Subscriber1 calls 0503232201 for 6 minutes...");
            subscriber1.MakeCall("0503232201", 6);

            PrintSubscriber(subscriber1);

            Console.WriteLine("Subscriber2 makes 5 different calls...");
            subscriber2.MakeCall("6577432865", 1);
            subscriber2.MakeCall("7389459347", 3);
            subscriber2.MakeCall("0189271347", 21);
            subscriber2.MakeCall("6484884689", 2);
            subscriber2.MakeCall("1234567890", 15);

            PrintSubscriber(subscriber2);
        }
    }
}
