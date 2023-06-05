using Microsoft.AspNetCore.Mvc;

namespace BinManagementMVC.Controllers.ChangeQuantity
{
    public class ChangeQuantityResponse : ObjectResult

    {
        public ChangeQuantityResponse(object? value) : base(value)
        {
        }
        public string Message { get; set; }
    }
}
