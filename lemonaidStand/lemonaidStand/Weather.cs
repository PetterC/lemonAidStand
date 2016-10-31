using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidStand
{
   public  class Weather
    {
  
       public int temperature;
       public string weather;
       public string sunny;
       public string cloudy;
       public string rainy;
       public double oddForCustomer;
        public List<string> weatherConditions; 

        public Weather()
        {
            weatherConditions = new List<string>() { "sunny", "cloudy", "rainy" };
            sunny = "sunny";
            cloudy = "cloudy";
            rainy = "rainy";
        }
        public void GetWeatherForecast()
        {
            Random randomTemperature = new Random();
            temperature = randomTemperature.Next(45, 99);
            weather = weatherConditions[randomTemperature.Next(0, 3)];

            if (temperature > 80 && weather == sunny)

            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[0]);
                Console.WriteLine("If temputure greater then 80 degrees and sunny the chances are high lemonaid.");
                oddForCustomer = 1;
            }
      

            else if (this.temperature >= 70 && weather == sunny)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[0]);
                Console.WriteLine("If temputure above 70 degrees and sunny the chances are good to sell lemonaid.");
                oddForCustomer = .7;

            }
            
            else if (this.temperature < 69 && weather == sunny)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[0]);
                Console.WriteLine("If temputure less then 70 degrees and sunny the chances are slim to sell lemonaid.");
                oddForCustomer = .5;

            }
            else if (this.temperature > 80 && weather == cloudy)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[1]);
                Console.WriteLine("If temputure greater then 80 degrees and cloudy the chances of customer are good to sell lemonaid.");
                oddForCustomer = .9;

            }
            else if (this.temperature >= 70 && weather == cloudy)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[1]);
                Console.WriteLine("If temputure above 70 degrees and cloudy the chances are good to sell lemonaid.");
                oddForCustomer = .7;

            }
            else if (this.temperature < 69 && weather == cloudy)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[1]);
                Console.WriteLine("If temputure less then 70 degrees and cloudy the chances are slim to sell lemonaid.");
                oddForCustomer = .4;

            }
            else if (this.temperature > 80 && weather == rainy)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[2]);
                Console.WriteLine("If temputure greater then 80 degrees and rainy the chances are low to sell lemonaid.");
                oddForCustomer = .4;

            }
            else if (this.temperature >= 70 && weather == rainy)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[2]);
                Console.WriteLine("If temputure around 70 degrees and rainy the chances are low to sell lemonaid.");
                oddForCustomer = .3;

            }
            else if (this.temperature < 69 && weather == rainy)
            {
                Console.WriteLine(temperature);
                Console.WriteLine(weatherConditions[2]);
                Console.WriteLine("If temputure less then 70 degrees and rainy the chances are low to sell lemonaid.");
                oddForCustomer = .1;

            }
              
        }
        }

            
    }

