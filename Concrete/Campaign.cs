using GameProject.Abstract;

namespace GameProject.Concrete
{
    public class Campaign : ICampaign
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}