using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace BinManagementMVC.Controllers.AddItem
{
    public class AddItemResponse : ObjectResult

    {
        public AddItemResponse(object? value) : base(value)
        {
        }
        public string Message { get; set; }
    }
}
