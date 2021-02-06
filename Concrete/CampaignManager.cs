using System;
using System.Collections.Generic;
using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        private List<ICampaign> _campaigns = new List<ICampaign>();

        public void Add(ICampaign item)
        {
            _campaigns.Add(item);
            Console.WriteLine("Kampanya eklendi: " + item.Name);
            Console.WriteLine("-----------------");
        }

        public void Update(ICampaign item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(ICampaign item)
        {
            throw new System.NotImplementedException();
        }

        public List<ICampaign> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ICampaign GetById(int itemId)
        {
            throw new System.NotImplementedException();
        }
    }
}