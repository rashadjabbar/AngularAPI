using AngularApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Abstract
{
    public interface IOrderRepository
    {
        List<Order> GetAllOrders();

        Order GetOrderByID(int id);

        Order CreateOrder(Order order);

        Order UpdateOrder(Order order);

        void DeleteOrder(int id);

    }
}
