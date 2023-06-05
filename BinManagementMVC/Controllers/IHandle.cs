using BinManagementMVC.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace BinManagementMVC.Controllers
{
    public interface IHandle
    {
        public ObjectResult Handle(IRequest request, Repository repository);
    }
}
