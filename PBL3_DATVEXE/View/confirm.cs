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
    public partial class confirm : Form
    {
        private static int count = 0;
        // khai báo delegate để chuyển đổi dữ liệu từ form detailschedule sang confirm
        public delegate double getGia();
        public getGia d { get; set; }


        // khai báo delegate lấy id_route and it_vehicle từ detailschedule sang confirm
        public delegate string getIdRoute_Vehicle();
        public getIdRoute_Vehicle d2 { get; set; }
        public getIdRoute_Vehicle d3 { get; set; }


        public confirm()
        {
            InitializeComponent();
        }
        // lấy danh sách các tên ghế mà đã chọn
        public List<string> listNameGhe = new List<string>();

        public List<string> getNameGhe()
        {
            return listNameGhe;
        }
        private void But_seat_Click(object sender, EventArgs e)
        {
            Button t = (Button)sender;
            if(t.ForeColor == Color.Red)
            {
                t.ForeColor = Color.Black;
                count--;
                
                lbPrice.Text = Convert.ToString(count * d());
                try
                {
                listNameGhe.Remove(t.Text);
                }
                catch(Exception r)
                {
                    MessageBox.Show(r.ToString());
                }
            }   
            else
            {
            t.ForeColor = Color.Red;
            count++;
            lbPrice.Text = Convert.ToString(count * d());
            listNameGhe.Add(t.Text.ToString());
            }                
        }

        // hàm lấy số vé và tổng giá
        //public void getGiaAndVe(int soVe, double tongGia)
        //{
        //    //soVe = count;
        //    //tongGia = count * d();
        //    soVe = 654;
        //    tongGia = 654;
        //}
        // hàm lấy id_route and id_vehicle 
        public string getIdRoute()
        {
            return d2();
        }
        public string getIdVehicle()
        {
            return d3();
        }
        private void But_tiep_Click(object sender, EventArgs e)
        {
            datVe dv = new datVe(count,count*d());
            //dv.d1 += new datVe.getVeAndTongGia(getGiaAndVe);
            dv.getGhe += new datVe.getNameGhe(getNameGhe);
            dv.getRoute += new datVe.getIdRouteAndVehicle(getIdRoute);
            dv.getVehicle += new datVe.getIdRouteAndVehicle(getIdVehicle);
            dv.Show();
           
            this.Close();
        }

        private void confirm_FormClosed(object sender, FormClosedEventArgs e)
        {
            count = 0;
            
        }
        public List<Button> getButtonInForm()
        {
            List<Button> list = new List<Button>();
            list.Add(But_seat1);
            list.Add(But_seat2);
            list.Add(But_seat3);
            list.Add(But_seat4);
            list.Add(But_seat5);
            list.Add(But_seat6);
            list.Add(But_seat7);
            list.Add(But_seat8);
            list.Add(But_seat9);
            list.Add(But_seat10);
            return list;
        }

        private void confirm_Load(object sender, EventArgs e)
        {
            List<orderSeat> list = BLL_TKVX.Instance.getAllOrderSeat_BLL();
            foreach(Button i in getButtonInForm())
            {
                foreach (orderSeat j in list)
                {
                    if ((j.id_detRoute == d2()) && (j.status == true) && (String.Compare(j.id_seat, i.Text[i.Text.Length - 1].ToString()) == 0))
                    {
                        i.ForeColor = Color.Red;
                    }
                }
            }    
            //List<Seat> listSeat = BLL_TKVX.Instance.getGhebyXe_BLL(d3());
            //foreach(Button j in getButtonInForm())
            //{
            //    foreach (Seat i in listSeat)
            //    {
            //        if (i.status == true && i.name_seat == j.Text)
            //        {
            //            j.ForeColor = Color.Red;
            //        }
            //    }
            //}    
 
        }
    }
}
