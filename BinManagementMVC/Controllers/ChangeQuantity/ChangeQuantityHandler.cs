using BinManagementMVC.Controllers.AddItem;
using BinManagementMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BinManagementMVC.Controllers.ChangeQuantity
{
    public class ChangeQuantityHandler : IHandle
    {
        public ObjectResult Handle(IRequest request, Repository repository)
        {
            try
            {
                ChangeQuantityRequest req = (ChangeQuantityRequest)request;
                string result = repository.ChangeQuantity(req.ItemId, req.BinId, req.Quantity);
                ChangeQuantityResponse res = new ChangeQuantityResponse(result);
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
