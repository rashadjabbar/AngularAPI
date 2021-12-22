using AngularApi.Business.Concrete;
using AngularApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IOrderService _orderService;

        public OrdersController()
        {
            _orderService = new OrderManager();
        }

        [HttpGet]
        public List<Order> Get()
        {
            return _orderService.GetAllOrders();
        }

        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderService.GetOrderByID(id);
        }

        static volatile public string document;

        [HttpPost("{upload}")]
        public string Upload()
        {
            
            if (Request.Form.Files.Count != 0)
            {
                IFormFile file = Request.Form.Files[0];
                document = FileHelper.Add(file);
            }

            return document;    
        }

        [HttpPost]
        public Order Post([FromBody]Order order)
        {
            order.OrderFile = document;
            return _orderService.CreateOrder(order);
        }

        [HttpPut]
        public Order Put([FromBody] Order order)
        {
            return _orderService.UpdateOrder(order);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _orderService.DeleteOrder(id);
        }

    }
}
