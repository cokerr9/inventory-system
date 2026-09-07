using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Models
{
    internal class PurchaseModels : connection_db
    {
        public int PurchaseId { get; set; }
        public int AccesoryId { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int Qty { get; set; }
        public DateTime Purchase_date { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}