using PBL3_DATVEXE.DAL;
using PBL3_DATVEXE.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_DATVEXE.BLL
{
    class BLL_TKVX
    {
        private static BLL_TKVX _Instance;

        public static BLL_TKVX Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TKVX();
                }
                return _Instance;
            }
            private set
            {

            }
        }
        public List<Vehicle> getAllXe_BLL()
        {
            return DAL_TKVX.Instance.getALLXe_DAL();
        }

        public List<Detail> getALLDetailSchedule_BLL(string departure1, string arrival1, DateTime date1)
        {
            return DAL_TKVX.Instance.getDetailSchedule_DAL(departure1,arrival1,date1);
        }
        // sắp xếp từ dal
        public List<Detail> Sort_BLL(DAL_TKVX.myDel d, string departure1, string arrival1, DateTime date1)
        {
            return DAL_TKVX.Instance.Sort_DAL(d, departure1, arrival1, date1);
        }

        public void addPerson_BLL(string id_person, string name, string phone, string address, string email)
        {
            DAL_TKVX.Instance.addPerson_DAL(id_person,name,phone,address,email);
        }

        //lấy ghế từ dal
        public List<Seat> getAllGhe_BLL()
        {
            return DAL_TKVX.Instance.getALLGhe_DAL();
        }

        // thêm order
        public void addOrder_BLL(string id_order, int id_orderSeat, string id_detRoute, string id_person, int numberTicket, double total_price, DateTime date_order)
        {
            DAL_TKVX.Instance.addOrder_DAL(id_order, id_orderSeat, id_detRoute, id_person, numberTicket, total_price, date_order);
        }

        // lấy danh sách tên ghế từ DAL
        public List<Seat> getGhebyXe_BLL(string id_vehicle)
        {
            return DAL_TKVX.Instance.getGheByXe_DAL(id_vehicle);
        }

        // lấy tất cả khách
        public List<Person> getALlKhach_BLL()
        {
            return DAL_TKVX.Instance.getALlKhachHang_DAL();
        }

        // lấy id_order max trong dal
        public string getMaxIdOrder_BLL()
        {
            return DAL_TKVX.Instance.getMaxIdOrder();
        }
        // lấy id_person max trong dal
        public string getMaxIdPerson_BLL()
        {
            return DAL_TKVX.Instance.getMaxIdPerson();
        }
        public List<DetailRoute> getAllChiTietTuyen_BLL()
        {
            return DAL_TKVX.Instance.getALLChiTietTuyen_DAL();
        }
        public void updateDetailRoute_BLL(string id_detRoute)
        {
            DAL_TKVX.Instance.updateDetailRoute_DAL(id_detRoute);
        }

        public List<orderSeat> getAllOrderSeat_BLL()
        {
            return DAL_TKVX.Instance.getAllOrderSeat_DAL();
        }
    }
}
