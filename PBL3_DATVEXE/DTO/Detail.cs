using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PBL3_DATVEXE.DTO
{
    class Detail
    {
        public string id_detRoute{ get; set; }

        public string id_vehicle { get; set; }
        public DateTime time_start { get; set; }

        public string departure { get; set; }

        public string arrival { get; set; }

        public string name { get; set; }

        public int empty_seat { get; set; }

        public double price { get; set; }

        public static bool ComparePrice(Object o1,Object o2)
        {
            return ((Detail)o1).price > ((Detail)o2).price;
        }

        public static bool CompareTime(Object o1, Object o2)
        {
            if(String.Compare(Convert.ToString(((Detail)o1).time_start),Convert.ToString(((Detail)o2).time_start))>0)
            {
                return true;
            }    
            else
            {
                return false;
            }                
        }
    }
}
