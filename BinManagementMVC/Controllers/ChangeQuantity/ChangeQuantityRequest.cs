using System.ComponentModel.DataAnnotations;

namespace BinManagementMVC.Controllers.ChangeQuantity
{
    public class ChangeQuantityRequest : IRequest
    {
        [Required]
        public string ItemId { get; set; }
        [Required]
        public string BinId { get; set; }
        [Required]
        public long Quantity { get; set; }
    }
}
