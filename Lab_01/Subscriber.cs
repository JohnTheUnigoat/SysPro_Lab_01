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
    class Subscriber
    {
        public enum TariffName { Standard, Premium, Premium_plus, Ultimate };

        static private Dictionary<TariffName, float> tariffMinuteCost = new Dictionary<TariffName, float>()
        {
            [TariffName.Standard] = 5.0f,
            [TariffName.Premium] = 2.0f,
            [TariffName.Premium_plus] = 1.0f,
            [TariffName.Ultimate] = 0.0f
        };

        public enum ServiceName { Additional_data, Data_sharing, Calls_abroad, Music_for_beeps };

        static private Dictionary<ServiceName, float> servicePricing = new Dictionary<ServiceName, float>()
        {
            [ServiceName.Additional_data] = 25.0f,
            [ServiceName.Data_sharing] = 35.0f,
            [ServiceName.Calls_abroad] = 65.0f,
            [ServiceName.Music_for_beeps] = 15.0f
        };

        private TariffName currentTariff;

        private HashSet<ServiceName> activeServices;

        public string CurrentTariff { get { return currentTariff.ToString().Replace('_', ' '); } }

        public float MinuteTalkCost { get { return tariffMinuteCost[currentTariff]; } }

        public string PhoneNumber { get; private set; }

        public float Balance { get; private set; }

        public Subscriber(string phoneNumber = "0000000000", TariffName tariff = TariffName.Standard)
        {
            if (phoneNumber.Length != 10)
                throw new ArgumentException("A phone number should be exactly 10 digits long!");

            if (!phoneNumber.All(symbol => char.IsDigit(symbol)))
                throw new ArgumentException("A phone number can only contain digits!");

            currentTariff = tariff;

            PhoneNumber = phoneNumber;

            Balance = 0.0f;
        }
    }
}
