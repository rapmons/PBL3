using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DATVEXE.DTO
{
    class Order
    {
        public string id_order { get; set; }
        public string id_orderSeat { get; set; }
        public string id_detRoute { get; set; }
        public string id_person { get; set; }
        public int numberTicket { get; set; }
        public double total_price { get; set; }
        public DateTime date_order { get; set; }
    }
}
