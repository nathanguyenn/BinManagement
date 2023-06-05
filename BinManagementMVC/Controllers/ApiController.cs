using BinManagementMVC.Controllers.AddItem;
using BinManagementMVC.Controllers.ChangeQuantity;
using BinManagementMVC.Controllers.RemoveItem;
using BinManagementMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BinManagementMVC.Controllers
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        private Repository _repository = new Repository();
        private readonly ILogger<ApiController> _logger;

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [Route("/AddItem")]
        [HttpPost]
        public ObjectResult AddItem([FromBody] AddItemRequest request, CancellationToken token)
        {
            return new AddItemHandler().Handle(request, _repository);
        }

        [Route("/ChangeQuantity")]
        [HttpPost]
        public ObjectResult ChangeQuantity([FromBody] ChangeQuantityRequest request, CancellationToken token)
        {
            return new ChangeQuantityHandler().Handle(request, _repository);
        }

        [Route("/RemoveItem")]
        [HttpPost]
        public ObjectResult RemoveItem([FromBody] RemoveItemRequest request, CancellationToken token)
        {
            return new RemoveItemHandler().Handle(request, _repository);
        }
    }
}