using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DATVEXE.DTO
{
    class DTO_DelRoute
    {
        public string id_delroute { get; set; }
        public string route { get; set; }
        public string vehicle { get; set; }
        public DateTime date { get; set; }
        public string time_start { get; set; }
        public double price { get; set; }
        public bool deleted { get; set; }
    }
}
