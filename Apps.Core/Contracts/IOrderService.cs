using Apps.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.Core.Contracts
{
    public interface IOrderService
    {
        void CreateOrder(Order order, List<OrderItem> items);
    }
}
