using System;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class Game:IGame
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
    }
}