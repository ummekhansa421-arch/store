using Apps.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Core.Contracts
{
    public interface IDashboardService
    {
        int GetTotalOrders();

        decimal GetTotalRevenue();

        int GetTotalProductsSold();

        List<Product> GetLowStockProducts();

        DataTable GetRecentOrders();
    }
}
