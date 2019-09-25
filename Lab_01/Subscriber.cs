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

        private TariffName currentTariff;

        public string CurrentTariff { get { return currentTariff.ToString().Replace('_', ' '); } }

        public float MinuteTalkCost { get { return tariffMinuteCost[currentTariff]; } }
    }
}
