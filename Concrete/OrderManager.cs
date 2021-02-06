using System;
using System.Collections.Generic;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        private List<IOrder> _orders = new List<IOrder>();

        public void Add(IOrder order)
        {
            _orders.Add(order);
            List<IGame> games = new List<IGame>();

            Console.WriteLine("Satın alınan oyunlar");
            order.Games.ForEach(game =>
            {
                game.Price -= order.Campaign.Discount;
                games.Add(game);
                Console.WriteLine("Oyun: " + game.Name + " | Fiyat: " + game.Price);
            });


            Console.WriteLine(order.Player.Username + " adlı kullanıcı " + order.Campaign.Name + " kampanyası ile " +
                              games.Count + " adet oyun satın aldı");
            Console.WriteLine("-----------------");
        }

        public void Update(IOrder order)
        {
        }

        public void Delete(IOrder order)
        {
            throw new System.NotImplementedException();
        }

        public List<IOrder> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IOrder GetById(int orderId)
        {
            throw new System.NotImplementedException();
        }
    }
}