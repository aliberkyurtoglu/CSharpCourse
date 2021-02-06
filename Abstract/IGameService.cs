using System.Collections.Generic;
using GameProject.Core;

namespace GameProject.Abstract
{
    public interface IGameService:ICrudService<IGame>
    {
        void Add(List<IGame> games);
    }
}