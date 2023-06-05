using BinManagementMVC.Controllers.AddItem;
using BinManagementMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BinManagementMVC.Controllers.RemoveItem
{
    public class RemoveItemHandler : IHandle
    {
        public ObjectResult Handle(IRequest request, Repository repository)
        {
            try
            {
                RemoveItemRequest req = (RemoveItemRequest)request;
                string result = repository.RemoveItem(req.ItemId, req.BinId);
                RemoveItemResponse res = new RemoveItemResponse(result);
                if (result.Equals("Failed"))
                { return new BadRequestObjectResult(res); }
                else
                { return new OkObjectResult(res); }
            }
            catch (NotImplementedException ex)
            {
                return new NotFoundObjectResult(ex.Message);
            }
        }
    }
}
