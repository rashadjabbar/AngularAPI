using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class Services
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? OrderId { get; set; }
        public bool? ServiceStat { get; set; }
    }
}
