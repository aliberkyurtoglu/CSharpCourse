using System;
using System.Collections.Generic;
using System.Linq;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        private readonly List<IPlayer> _players = new List<IPlayer>();

        public void Add(IPlayer player)
        {
            _players.Add(player);
            Console.WriteLine("Oyuncu kaydoldu: " + player.Username);
            Console.WriteLine("-----------------");
        }

        public void Update(IPlayer player)
        {
            Console.WriteLine("Oyuncu güncelleme");
            IPlayer playerToUpdate = _players.Find(p => p.PlayerId == player.PlayerId);
            if (playerToUpdate != null)
            {
                Console.WriteLine(playerToUpdate.Username + " kullanıcı adlı oyuncu profilini güncelledi");
                Console.WriteLine(playerToUpdate.Firstname + " => " + player.Firstname);
                Console.WriteLine(playerToUpdate.Lastname + " => " + player.Lastname);
                Console.WriteLine(playerToUpdate.Username + " => " + player.Username);
                Console.WriteLine(playerToUpdate.Password + " => " + player.Password);
                
                playerToUpdate.Firstname = player.Firstname;
                playerToUpdate.Lastname = player.Lastname;
                playerToUpdate.Username = player.Username;
                playerToUpdate.Password = player.Password;
                Console.WriteLine("-----------------");
            }
        }

        public void Delete(IPlayer player)
        {
            _players.Remove(player);
        }

        public List<IPlayer> GetAll()
        {
            Console.WriteLine("Tüm oyuncular");
            foreach (IPlayer player in _players)
            {
                Console.WriteLine("Kullanıcı Adı: " + player.Username);
                Console.WriteLine("Adı Soyadı: " + player.Firstname + " " + player.Lastname);
            }
            Console.WriteLine("-----------------");
            return _players.ToList();
        }

        public IPlayer GetById(int playerId)
        {
            IPlayer player = _players.Find(p => p.PlayerId == playerId);
            //Console.WriteLine(playerId + " idsine sahip kullanıcı listelendi: " + player?.Username);
            return player;
        }
    }
}