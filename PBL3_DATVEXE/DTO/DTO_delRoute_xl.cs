using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DATVEXE.DTO
{
    class DTO_delRoute_xl
    {
        public string id_delroute { get; set; }
        public string id_route { get; set; }
        public string id_vehicle { get; set; }
        public DateTime date { get; set; }
        public DateTime time_start { get; set; }
        public double price { get; set; }
        public bool deleted { get; set; }
    }
}
