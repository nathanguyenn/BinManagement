using Microsoft.AspNetCore.Mvc;

namespace BinManagementMVC.Controllers.RemoveItem
{
    public class RemoveItemResponse : ObjectResult

    {
        public RemoveItemResponse(object? value) : base(value)
        {
        }
        public string Message { get; set; }
    }
}
