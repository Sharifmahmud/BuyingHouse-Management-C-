using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IOrderRepo
    {
        bool InsertOrder(Order ord);
        bool DeleteOrder(Order ord);
        bool UpdateOrder(Order ord);
        Order GetOrder(string orderno);
        List<Order> GetAllOrder();
    }
}
