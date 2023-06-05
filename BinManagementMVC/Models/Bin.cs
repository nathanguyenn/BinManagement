namespace BinManagementMVC.Models
{
    public class Bin
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public Item Items { get; set; }
        
    }
}
