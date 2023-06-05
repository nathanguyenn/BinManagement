using BinManagementMVC.Controllers.AddItem;
using BinManagementMVC.Models;

namespace BinManagementMVC.Repositories
{
    public class Repository
    {
        public virtual string AddItem(Item item, string BinId)
        {
            throw new NotImplementedException();
        }
        public virtual string ChangeQuantity(string ItemId, string BinId, long quantity)
        {
            throw new NotImplementedException();
        }
        public virtual string RemoveItem(string ItemId, string BinId)
        {
            throw new NotImplementedException();
        }
    }
}
