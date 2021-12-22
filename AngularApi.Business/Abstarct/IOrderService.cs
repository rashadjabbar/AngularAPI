using AngularApi.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularApi.Business.Abstarct
{
    public interface IOrderService
    {
        List<Order> GetAllOrders();

        Order GetOrderByID(int id);

        Order CreateOrder(Order order );

        Order UpdateOrder(Order order);

        void DeleteOrder(int id);
    }
}
