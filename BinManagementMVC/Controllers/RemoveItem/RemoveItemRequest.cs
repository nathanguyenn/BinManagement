using BinManagementMVC.Models;

namespace BinManagementMVC.Controllers.RemoveItem
{
    public class RemoveItemRequest : IRequest
    {
        public string ItemId { get; set; }
        public string BinId { get; set; }
    }
}
