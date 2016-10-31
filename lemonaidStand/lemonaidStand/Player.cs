using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidStand
{
    public class Player // open/closed principle is open to add more function to a player.
    {
        public Stand stand;
        public Wallet wallet;
        public Recipe recipe;

        public Player()
        {
            
            stand = new Stand();
            wallet = new Wallet();
            recipe = new Recipe();

       

        }
       

        
    }
    }

