using AngularApi.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace AngularApi.Controllers
{
    internal interface IOrderService
    {
        List<Order> GetAllOrders();

        Order GetOrderByID(int id);

        Order CreateOrder(Order order);

        Order UpdateOrder(Order order);

        void DeleteOrder(int id);
    }
}