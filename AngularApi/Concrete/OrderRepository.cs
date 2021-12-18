using AngularApi.Abstract;
using AngularApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Concrete
{
    public class OrderRepository : IOrderRepository
    {
        public Order CreateOrder(Order order)
        {
            using (var orderDbContext = new AngularApiContext())
            {
                orderDbContext.Order.Add(order);
                orderDbContext.SaveChanges();
                return order;
            }
        }

        public void DeleteOrder(int id)
        {
            using (var orderDbContext = new AngularApiContext())
            {
                var deletedOrder = GetOrderByID(id);
                orderDbContext.Order.Remove(deletedOrder);
                orderDbContext.SaveChanges();
            }
        }

        public List<Order> GetAllOrders()
        {
           using (var orderDbContext = new AngularApiContext())
            {
                return orderDbContext.Order.ToList();
            }
        }

        public Order GetOrderByID(int id)
        {
            using (var orderDbContext = new AngularApiContext())
            {
                return orderDbContext.Order.Find(id);
            }
        }

        public Order UpdateOrder(Order order)
        {
            using (var orderDbContext = new AngularApiContext())
            {
                orderDbContext.Order.Update(order);
                orderDbContext.SaveChanges();
                return order;
            }
        }
    }
}
