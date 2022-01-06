using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Butica_Andrei_Lab12v1.Models;

namespace Butica_Andrei_Lab12v1.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
