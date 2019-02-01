using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrefixDapperExample.Data
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public DateTime OrderedOn { get; set; }
    }
}
