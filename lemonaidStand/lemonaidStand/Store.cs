using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidStand
{
    public class Store // single resonsibility for lemonaid supply store.
    {
        public string store;
       public double bottleWaterPrice;
        public double sugarCubePrice;
        public double lemonPrice;
        public double iceCubePrice;
        Recipe recipe;
     
        public Store()

        {
            bottleWaterPrice = .50;
            sugarCubePrice = .10;
            lemonPrice = .25;
            iceCubePrice = .05;
        }

        public int GetLemonaid()
        {
            Console.WriteLine("Enter Amount How Many Pitcher You Need");
            int response = Convert.ToInt32(Console.ReadLine());
            return response;
        }
        
    }
}
