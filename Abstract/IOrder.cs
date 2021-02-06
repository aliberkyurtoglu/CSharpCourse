using System.Collections.Generic;

namespace GameProject.Abstract
{
    public interface IOrder
    {
        public int OrderId { get; set; }
        public IPlayer Player { get; set; }
        public List<IGame> Games { get; set; }
        public ICampaign Campaign { get; set; }
    }
}