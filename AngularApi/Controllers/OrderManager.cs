using AngularApi.Abstract;
using AngularApi.Concrete;
using AngularApi.Controllers;
using AngularApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularApi.Business.Concrete
{
    public class OrderManager : IOrderService
    {

        private IOrderRepository _orderRepository;

        public OrderManager()
        {
            _orderRepository = new OrderRepository();
        }

        public Order CreateOrder(Order order)
        {
            return _orderRepository.CreateOrder(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepository.DeleteOrder(id);
        }

        public List<Order> GetAllOrders()
        {
            return _orderRepository.GetAllOrders();
        }

        public Order GetOrderByID(int id)
        {
            return _orderRepository.GetOrderByID(id);

        }

        public Order UpdateOrder(Order order)
        {
            return _orderRepository.UpdateOrder(order);
        }
    }
}
