using System;

namespace GameProject.Abstract
{
    public interface IGame
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }
    }
}