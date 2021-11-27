using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DATVEXE.DTO
{
    class DetailRoute
    {

        public string id_delRoute { get; set; }


        public string id_route { get; set; }

        public string id_vehicle { get; set; }

        public DateTime date { get; set; }

        public double price { get; set; }

        public DateTime time_start { get; set; }

        public bool deleted { get; set; }

    }
}
