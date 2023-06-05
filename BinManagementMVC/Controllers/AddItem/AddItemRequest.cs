using BinManagementMVC.Models;

namespace BinManagementMVC.Controllers.AddItem
{
    public class AddItemRequest : IRequest
    {
        public Item item { get; set; }
        public string BinId { get; set; }
    }
}
