using PBL3_DATVEXE.BLL;
using PBL3_DATVEXE.DAL;
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
    public partial class DetailSchedule : Form
    {
        confirm cf = new confirm();
        public DetailSchedule()
        {
            InitializeComponent();
            ShowXe();
            setSort();
        }
        public void setSort()
        {
            cbbsapXep.Items.AddRange(new string[]
            {
                "price",
                "time_start"
            });
        }
        public void ShowXe()
        {
           
            datagridview1.DataSource = BLL_TKVX.Instance.getALLDetailSchedule_BLL("QT","DN",DateTime.Now.Date);
            datagridview1.Columns["id_detRoute"].Visible = false;
            datagridview1.Columns["id_vehicle"].Visible = false;

        }

        // hàm tham chiếu của delegate
        public double getGia()
        {
            DataGridViewSelectedRowCollection data = datagridview1.SelectedRows;
            if(data.Count == 1)
            {
                return Convert.ToDouble(data[0].Cells["price"].Value.ToString());
            }   
            else
            {
                return 0;
            }                
        }

        // lấy id_route and id_vehicle
        public string getIdDetRoute()
        {
            return datagridview1.SelectedRows[0].Cells["id_detRoute"].Value.ToString(); 
        }
        public string getIdVehicle()
        {
            return datagridview1.SelectedRows[0].Cells["id_vehicle"].Value.ToString();

        }
        private void But_chon_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection data = datagridview1.SelectedRows;
            if(data.Count == 1)
            {
                cf = new confirm();
                cf.d += new confirm.getGia(getGia);
                cf.d2 += new confirm.getIdRoute_Vehicle(getIdDetRoute);
                cf.d3 += new confirm.getIdRoute_Vehicle(getIdVehicle);
                cf.Show();  
            }   
            else
            {
                MessageBox.Show("bạn chỉ được chọn 1 chuyến tại 1 thời điểm");
            }                
        }

        private void But_sapXep_Click(object sender, EventArgs e)
        {
            if(cbbsapXep.SelectedItem.ToString() == "price" )
            {
            datagridview1.DataSource = BLL_TKVX.Instance.Sort_BLL(new DAL_TKVX.myDel(Detail.ComparePrice), "QT", "DN", DateTime.Now.Date);
            }    
            else
            {
            datagridview1.DataSource = BLL_TKVX.Instance.Sort_BLL(new DAL_TKVX.myDel(Detail.CompareTime), "QT", "DN", DateTime.Now.Date);
            }                
        }

        // trước khi mở form xem các chi tiết tuyến nếu quá giờ thì tự động xóa

        private void DetailSchedule_Load(object sender, EventArgs e)
        {
            List<DetailRoute> list = BLL_TKVX.Instance.getAllChiTietTuyen_BLL();
            foreach (DetailRoute i in list)
            {
                // MessageBox.Show((DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")), i.time_start) > 0).ToString());
                //(DateTime.Compare(Convert.ToDateTime(DateTime.Now.ToString("hh:mm:ss")), i.time_start) > 0)
                if ((DateTime.Compare(DateTime.Now.Date, i.date) > 0))//  || (DateTime.Compare(DateTime.Now.Date, i.date) > 0)
                {
                    BLL_TKVX.Instance.updateDetailRoute_BLL(i.id_delRoute);
                }
            }
        }
    }
}
