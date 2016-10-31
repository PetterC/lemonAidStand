using lemonaidStand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidStand
{
    public class Wallet

    {
        public double cash;
     
        public Wallet()
        {
            cash = 25.00;

            
        }
            public void GetBalance()
        {
            if (cash < 0.00)
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        }
    }

