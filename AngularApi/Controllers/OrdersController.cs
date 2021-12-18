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
    }
}
