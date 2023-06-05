using BinManagementMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;
using System.Web.Http.Results;

namespace BinManagementMVC.Controllers.AddItem
{
    public class AddItemHandler : IHandle
    {
        public ObjectResult Handle(IRequest request, Repository repository)
        {
            try
            {
                AddItemRequest req = (AddItemRequest)request;
                string result = repository.AddItem(req.item, req.BinId);
                AddItemResponse res = new AddItemResponse(result);
                if(result.Equals("Failed"))
                { return new BadRequestObjectResult(res); }
                else
                {return new OkObjectResult(res);}
            }
            catch (NotImplementedException ex) 
            {
                return new NotFoundObjectResult(ex.Message);
            }
        }
    }
}
