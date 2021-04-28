using GameMarketSimulation.Abstract;
using GameMarketSimulation.Entities;
using GameMarketSimulation.Concrete;
using GameMarketSimulation.Adapters;
using System;
using System.Collections.Generic;

namespace GameMarketSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User(1, "Vuqar", "Rahimli", new DateTime(1998, 4, 13), "654681351"); // creating new customer

            CustomerManager customerManager = new CustomerManager(new MernisServiceAdapter()); // registering if values are real
            customerManager.Register(user1);
            customerManager.Update(user1); // updating customer
            customerManager.Delete(user1); // deleting customer from system


            // creating new products
            Product product1 = new Game(1, "Mafia 2", new DateTime(2021, 1, 15), 30.99, "Bestseller");
            Product product2 = new Game(2, "Witcher 3", new DateTime(2021, 3, 10), 50.99, "Bestseller");
            Product product3 = new Game(3, "Skyrim", new DateTime(2021, 4, 1), 21.99, "Bestseller");
            Product product4 = new Game(4, "Total Overdose", new DateTime(2021, 2, 24), 15.89, "Bestseller");
            Product product5 = new Game(4, "Erzurum", new DateTime(2021, 1, 24), 30, "Bestseller");


            // creating a campaign
            Campaign campaign = new Campaign();
            campaign.DiscountRate = 100; // defining discount rate

            //----------------------------------------------------------------------------------------------------------
            // HATALI gibi gözüken kısım


            campaign.products = new List<Product>() { product2, product5 }; // applying campaign to certain products

            CampaignManager campaignManager = new DiscountManager(new DiscountCheck()); // checking if products have discount on them to calculate the discount
            campaignManager.AddCampaign(campaign); // adding campaigns


            // bu kısım biraz saçma oldu ama daha iyi nasıl yaparım, discount calcualate methodunu başka yere mi taşımam lazım,
            // tam kestiremedim, çok fazla class oluşturdum sanki.

            // bu yaptığım ne gibi sorunlara yol aça bilir?

            // esas campaign manager ve discount manager classlarında bozdum sanırım, daha iyi nasıl yapabilirim?


            //---------------------------------------------------------------------------------------------------------------------------------

            SaleManager saleManager = new SaleManager();

            saleManager.Sell(product1, campaign, user1);
            saleManager.Sell(product2, campaign, user1);
            saleManager.Sell(product3, campaign, user1);
            saleManager.Sell(product4, campaign, user1);
            saleManager.Sell(product5, campaign, user1);


        }
    }
}
