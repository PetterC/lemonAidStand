using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonaidStand
{ 
    public class Day  
    {
        public Player player;
        public Inventory inventory;
        List<string> DayOfTheWeek = new List<string>();
        List<Customer> customers = new List<Customer>();
        int customerCount = 40;
        int buyingCustomer =2;
        public Weather weather;
        Customer customer;
        private Wallet cash;
        private int pitcher;

        public Day()            
        {
            weather = new Weather();
            player = new Player();
            inventory = new Inventory();
        }
        public void CreateCustomers()
        {
            for(int i = 0; i < customerCount; i++)
            {
                Random randombuyingCustomer = new Random();
                buyingCustomer = randombuyingCustomer.Next(0, 2);
                Customer customer = new Customer(buyingCustomer);
                customers.Add(customer);
            }
        }
        public void GetCustomerToBuy()
        {
       foreach (Customer customer in customers)
            {
               if (customer.chanceTobuy > 1)
                {
                    double cups = 0;
                    player.wallet.cash -= cups;
                    inventory.cups -= pitcher;

                }


            }

            }  
        }
    }



    


        



       


        

    
