using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    internal class CategoryModels : connection_db
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryStatus { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
    }
}
