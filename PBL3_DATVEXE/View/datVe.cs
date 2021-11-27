using PBL3_DATVEXE.BLL;
using PBL3_DATVEXE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_DATVEXE.View
{
    public partial class datVe : Form
    {
        // delegate lấy số vé và tổng giá
        public delegate void getVeAndTongGia(int soVe,double tongGia);

        public getVeAndTongGia d1 { get; set; }

        // lấy id_route and id_vehicle từ confirm sang datVe
        public delegate string getIdRouteAndVehicle();

        public getIdRouteAndVehicle getRoute { get; set; }
        public getIdRouteAndVehicle getVehicle { get; set; }

        // lấy tên ghế từ form confirm sang form datVe.
        public delegate List<string> getNameGhe();

        public getNameGhe getGhe { get; set; }
        public int soVe { get; set; }
        public double tongGia { get; set; }

        public string id_detRoute { get; set; }

        public string id_vehicle { get; set; }
        public datVe(int soVe,double tongGia)
        {
            InitializeComponent();
            // giá và số vé
            this.soVe = soVe;
            this.tongGia = tongGia;
        }

        private void But_xacnhan_Click(object sender, EventArgs e)
        {
            // thêm thông tin người dùng
            string id_person = Convert.ToString(Convert.ToInt32(BLL_TKVX.Instance.getMaxIdPerson_BLL()) + 1);
            BLL_TKVX.Instance.addPerson_BLL(id_person,txtName.Text,txtPhone.Text,txtNote.Text,txtEmail.Text);
            // id_order
            string id_order = Convert.ToString(Convert.ToInt32(BLL_TKVX.Instance.getMaxIdOrder_BLL()) + 1);
            // lấy số vé and tổng giá cho thuộc tính 
            this.id_detRoute = getRoute();// id tuyến
            this.id_vehicle = getVehicle();// id xe

            //lấy danh sách tên ghế đã chọn 
            List<string> listGheDaChon = getGhe(); // list danh sách tên ghế
            // lấy id_seat của các ghế đã chọn

            List<string> listId_seat = new List<string>();
            foreach (string i in listGheDaChon)
            {
                foreach (Seat j in BLL_TKVX.Instance.getAllGhe_BLL())
                {
                    if (i == j.name_seat && j.id_vehicle == this.id_vehicle)
                    {
                        listId_seat.Add(j.id_seat);
                    }
                }
            }

            // lấy danh sách tất cả order_seat
            List<int> listOrderSeat = new List<int>();
            foreach (orderSeat i in BLL_TKVX.Instance.getAllOrderSeat_BLL())
            {
                foreach (string j in listId_seat)
                {
                    if (i.id_detRoute == this.id_detRoute && i.id_vehicle == this.id_vehicle && j == i.id_seat)
                    {
                        listOrderSeat.Add(i.id_orderSeat);
                    }
                }

            }

            //MessageBox.Show(listOrderSeat.Count.ToString());




            // có so vé , có tổng giá ,có id_route 
            // cần tìm id_seat dựa vào id_vehicle được lấy từ form detailschedule
            // thêm đơn order theo ghế đã chọn
            if (listOrderSeat.Count == 1)
            {
                BLL_TKVX.Instance.addOrder_BLL(id_order, listOrderSeat[0], this.id_detRoute, id_person, this.soVe, this.tongGia, DateTime.Now);
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("quá nhiều");
            }
        }
    }
}
