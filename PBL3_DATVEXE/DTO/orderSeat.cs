using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DATVEXE.DTO
{
    class orderSeat
    {
        public int id_orderSeat { get; set; }
        public string id_detRoute { get; set; }
        public string id_vehicle { get; set; }

        public string id_seat { get; set; }

        public bool status { get; set; }
    }
}
