using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_DATVEXE.BLL;
using PBL3_DATVEXE.DTO;

namespace PBL3_DATVEXE
{
    public partial class Form3 : Form
    {
        public delegate void Mydel(string id, string name);
        public Mydel d { get; set; }
        public string id_detroute { get; set; }

        public Form3(string m)
        {
            InitializeComponent();
            id_detroute = m;
            setGui();
        }
        public void setGui()
        {
            List<DTO_route> list = BLL_Route.Instance.getallRoute();
            foreach(var i in list)
            {
                comboBox1.Items.Add(new CBBitem
                {
                    Value = i.id_route,
                    Text= i.departure+"-"+i.arrival
                    

                });
               
            }
         if(BLL_delRoute.Instance.GetsvByid_detroute(id_detroute)!=null)
            {
                DTO_delRoute_xl dd = new DTO_delRoute_xl();
                dd = BLL_delRoute.Instance.GetsvByid_detroute(id_detroute);
                textBox1.Text = dd.id_delroute;
                textBox2.Text = dd.time_start.ToLongTimeString();
                textBox3.Text = dd.price.ToString();
                dateTimePicker1.Value = dd.date;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO_delRoute_xl s = new DTO_delRoute_xl();
            s.id_delroute = textBox1.Text;
            s.id_route = ((CBBitem)comboBox1.SelectedItem).Value;
            s.id_vehicle = comboBox2.Text;
            s.time_start = Convert.ToDateTime(textBox2.Text);
            s.price = Convert.ToDouble(textBox3.Text);
            s.date = dateTimePicker1.Value;
            BLL_delRoute.Instance.execute(s);

            d(((CBBitem)comboBox1.SelectedItem).Value, "");
        }
    }
}
