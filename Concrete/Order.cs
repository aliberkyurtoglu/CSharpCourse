using System.Collections.Generic;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class Order:IOrder
    {
        public int OrderId { get; set; }
        public IPlayer Player { get; set; }
        public List<IGame> Games { get; set; }
        public ICampaign Campaign { get; set; }
    }
}