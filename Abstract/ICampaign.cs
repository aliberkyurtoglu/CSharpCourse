namespace GameProject.Abstract
{
    public interface ICampaign
    {
        public int CampaignId { get; set; }
        public string Name { get; set; }
        public double Discount { get; set; }
    }
}