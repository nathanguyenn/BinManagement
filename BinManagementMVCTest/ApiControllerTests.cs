using BinManagementMVC.Controllers.AddItem;
using BinManagementMVC.Controllers;
using BinManagementMVC.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Web.Http;
using Microsoft.Extensions.Logging;
using ApiController = BinManagementMVC.Controllers.ApiController;
using Moq;
using Microsoft.AspNetCore.Mvc;
using BinManagementMVC.Repositories;
using BinManagementMVC.Controllers.ChangeQuantity;
using BinManagementMVC.Controllers.RemoveItem;

namespace BinManagementMVCTest
{
    public class ApiControllerTests : IClassFixture<WebApplicationFactory<Program>>
    {    
        ILogger<ApiController> _logger;
        ApiController _controller; 
        public ApiControllerTests()
        {
            var mock = new Mock<ILogger<ApiController>>();
            _logger = mock.Object;
            _controller  = new ApiController(_logger);
        }

        [Fact]
        public async Task TestAddItem()
        {
            // Arrange
            var binId = "ItemId";
            Item item = new Item() { Id = binId, Description = "test description", Quantity = 3 };
            AddItemRequest request = new AddItemRequest() { BinId = "testBinId", item = item };
            NotImplementedException ex = new NotImplementedException();
            Mock<Repository> test = new Mock<Repository>();
            test.Setup(x => x.AddItem(item, binId)).Returns(ex.Message);
            

            // Act
            var response = _controller.AddItem(request, new CancellationToken());

            // Assert
            Assert.IsType<NotFoundObjectResult>(response);
            Assert.NotEqual(new OkObjectResult(null), response);
        }


        [Fact]
        public async Task TestChangeQuantity()
        {
            // Arrange
            var binId = "binId";;
            var itemId = "testItemId";
            var quantity = 3;
            ChangeQuantityRequest request = new ChangeQuantityRequest() { BinId = binId, Quantity = quantity, ItemId = itemId };
            NotImplementedException ex = new NotImplementedException();
            Mock<Repository> test = new Mock<Repository>();
            test.Setup(x => x.ChangeQuantity(itemId, binId, quantity)).Returns(ex.Message);


            // Act
            var response = _controller.ChangeQuantity(request, new CancellationToken());

            // Assert
            Assert.IsType<NotFoundObjectResult>(response);
            Assert.NotEqual(new OkObjectResult(null), response);
        }


        [Fact]
        public async Task TestRemoveItem()
        {
            // Arrange
            var binId = "binId"; ;
            var itemId = "testItemId";
            RemoveItemRequest request = new RemoveItemRequest() { BinId = binId, ItemId = itemId };
            NotImplementedException ex = new NotImplementedException();
            Mock<Repository> test = new Mock<Repository>();
            test.Setup(x => x.RemoveItem(itemId, binId)).Returns(ex.Message);


            // Act
            var response = _controller.RemoveItem(request, new CancellationToken());

            // Assert
            Assert.IsType<NotFoundObjectResult>(response);
            Assert.NotEqual(new OkObjectResult(null), response);
        }
    }
}
