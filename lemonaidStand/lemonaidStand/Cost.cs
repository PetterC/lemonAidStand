using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidStand
{
    class Cost
    {
        double cupCost;

        public Cost()
        {
            cupCost = 0;

        }
        public string GetCupPrice()
        {
            Console.WriteLine("Enter how much you want to charge pre cup cost, {0}");
            string response = Console.ReadLine();
            return response;
        }

    }
}
