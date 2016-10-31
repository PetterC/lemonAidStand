using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidStand
{
    class Game
    {

        public Player player;
        public Store store;
        public Day day;
        public int countOfDays = 7;
        public Rules instrutions;
        public Cost cost;
        public Inventory inventory;
        public Stand stand;
        public Weather weather;

        public Game()
        {
           
            player = new Player();
            store = new Store();
            
        }
    
        public double GetPriceOfPitcher()
        {
            double totalPrice = (store.bottleWaterPrice * player.recipe.bottleWaterQuantity) + (store.sugarCubePrice * player.recipe.sugarCubeQuantity) + (store.lemonPrice * player.recipe.lemonQuantity) + (store.iceCubePrice * player.recipe.iceCubeQuantity);
            Console.WriteLine("Price of one pitcher is {0}", totalPrice);
            return totalPrice;
        }
      
        public void DeductingWallet(double priceOfPitcher, int numberOfPitchers)
        {
            player.wallet.cash -= priceOfPitcher * numberOfPitchers;
            Console.WriteLine(player.wallet.cash);
            

        }
        public string GetPlayerName()
        {
            Console.WriteLine("Enter Player Name");
            string response = Console.ReadLine();
            return response;
        }
        public void AddPlayer(string userResponse)
        {
            AddPlayer(userResponse);
        }
        public void RunGame()
        {
            instrutions = new Rules();
            GetPlayerName();
            for(int i = 0; i < countOfDays; i++)
            {
               weather = new Weather();
               inventory = new Inventory();
               weather.GetWeatherForecast();
               double priceOfPitcher = GetPriceOfPitcher();
               int PitcherAmount = store.GetLemonaid();
               DeductingWallet(priceOfPitcher, PitcherAmount);
               day.GetCustomerToBuy();

            }
           

        }

    }
        

               
        }
               
        

    





        
       
    

