using System;
using System.Collections.Generic;

namespace AngularApi.Models
{
    public partial class Documents
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public int? OrderId { get; set; }
    }
}
