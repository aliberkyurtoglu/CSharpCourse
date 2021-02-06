using System;
using System.Collections.Generic;
using System.Linq;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        private List<IGame> _games = new List<IGame>();

        public void Add(IGame game)
        {
            _games.Add(game);
            Console.WriteLine("Oyun eklendi: " + game.Name);
            Console.WriteLine("-----------------");
        }
        public void Add(List<IGame> games)
        {
            foreach (IGame game in games)
            {
                _games.Add(game);
                Console.WriteLine("Oyun eklendi: " + game.Name);
            }
            Console.WriteLine("-----------------");
        }
        
        public void Update(IGame game)
        {
            Console.WriteLine("Oyuncu güncelleme");
            IGame gameToUpdate = _games.Find(p => p.GameId == game.GameId);
            if (gameToUpdate != null)
            {
                Console.WriteLine(gameToUpdate.Name + " adlı oyun güncellendi");
                Console.WriteLine(gameToUpdate.Name + " => " + game.Name);
                Console.WriteLine(gameToUpdate.Price + " => " + game.Price);
                Console.WriteLine(gameToUpdate.ReleaseDate + " => " + game.ReleaseDate);

                gameToUpdate.Name = game.Name;
                gameToUpdate.Price = game.Price;
                gameToUpdate.ReleaseDate = game.ReleaseDate;
                Console.WriteLine("-----------------");
            }
        }

        public void Delete(IGame game)
        {
            _games.Remove(game);
        }

        public List<IGame> GetAll()
        {
            Console.WriteLine("Tüm oyunlar");
            foreach (IGame game in _games)
            {
                Console.WriteLine("Oyun Adı: " + game.Name);
            }

            Console.WriteLine("-----------------");
            return _games.ToList();
        }

        public IGame GetById(int gameId)
        {
            IGame game = _games.Find(g => g.GameId == gameId);
            if (game != null)
            {
                Console.WriteLine("Oyun Adı: " + game.Name);
                Console.WriteLine("Fiyat: " + game.Price);
                Console.WriteLine("Çıkış Tarihi: " + game.ReleaseDate);
            }

            Console.WriteLine("-----------------");

            return game;
        }
    }
}