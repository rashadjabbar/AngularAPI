using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? OrderDocNum { get; set; }
        public string OrderCusName { get; set; }
        public int? OrderGbnum { get; set; }
        public int? OrderPrice { get; set; }
        public string OrderDate { get; set; }
        public string OrderTrafficType { get; set; }
        public string OrderNote { get; set; }
        public string OrderFile { get; set; }
        public bool OrderPriceStat { get; set; }
        public bool OrderSerCheck1 { get; set; }
        public bool OrderSerCheck2 { get; set; }
        public bool OrderSerCheck3 { get; set; }
        public bool OrderSerCheck4 { get; set; }
        public int? OrderDocId { get; set; }
    }
}
