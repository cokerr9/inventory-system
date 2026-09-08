using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    public class AccessoryModel : connection_db
    {
        public int AccessoryId { get; set; }
        public string AccessoryName { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int ModelId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
    }
}
