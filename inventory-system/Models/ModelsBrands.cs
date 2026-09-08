using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    internal class ModelsBrands : connection_db
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string BrandStatus { get; set; }
    }
}
