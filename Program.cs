using System;
using System.Collections.Generic;
using GameProject.Abstract;
using GameProject.Concrete;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayer addedPlayer = AddPlayer(new PlayerManager());
            List<IGame> addedGames = AddGame(new GameManager());
            ICampaign addedCampaign = AddCampaign(new CampaignManager());
            IOrder addedOrder = AddOrder(new OrderManager(), addedPlayer, addedGames, addedCampaign);
        }

        static IPlayer AddPlayer(IPlayerService playerManager)
        {
            IPlayer player = new Player()
            {
                PlayerId = 1, Firstname = "Ali Berk", Lastname = "Yurtoğlu", IdentificationNumber = "72097085222",
                Username = "aliberkyurtoglu", Password = "9823718abc", BirthDate = new DateTime(1998, 07, 28)
            };
            playerManager.Add(player);

            return player;
        }

        static List<IGame> AddGame(IGameService gameManager)
        {
            List<IGame> games = new List<IGame>()
            {
                new Game()
                {
                    GameId = 1, Name = "Red Dead Redemption 2", Price = 229.99, ReleaseDate = new DateTime(2018, 08, 12)
                },
                new Game() {GameId = 2, Name = "GTA 5", Price = 49.99, ReleaseDate = new DateTime(2014, 01, 28)},
            };
            gameManager.Add(games);

            return games;
        }

        static ICampaign AddCampaign(ICampaignService campaignManager)
        {
            ICampaign campaign = new Campaign()
            {
                CampaignId = 1, Name = "Yaz İndirimi", Discount = 29.99
            };
            campaignManager.Add(campaign);

            return campaign;
        }

        static IOrder AddOrder(IOrderService orderManager, IPlayer player, List<IGame> games, ICampaign campaign)
        {
            IOrder order = new Order()
            {
                OrderId = 1, Player = player, Games = games, Campaign = campaign
            };
            orderManager.Add(order);

            return order;
        }
    }
}