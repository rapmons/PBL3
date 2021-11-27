using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_DATVEXE.DTO;
using PBL3_DATVEXE.BLL;

namespace PBL3_DATVEXE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            setCBBLSH();
        }
        public void setCBBLSH()
        {
            List<DTO_route> list = BLL_Route.Instance.getallRoute();
            comboBox1.Items.Add(new CBBitem
            {
                Text = "All",
                Value = "0"
            });
            foreach (var i in list)
            {
                comboBox1.Items.Add(new CBBitem
                {
                    Value = i.id_route,
                    Text = i.departure + "-" + i.arrival
                });
            }
            comboBox1.SelectedIndex = 0;
        }
        public void Show1(string id_route, string name)
        {
            dataGridView1.DataSource = BLL_delRoute.Instance.getListdelroute_BLL(id_route);


        }

        private void button4_Click(object sender, EventArgs e)
        {

            Show1(((CBBitem)comboBox1.SelectedItem).Value, textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3(null);
            f.Show();
            f.d += new Form3.Mydel(Show1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count==1)
            {
                string id_detroute = dataGridView1.SelectedRows[0].Cells["id_delroute"].Value.ToString();
                Form3 f = new Form3(id_detroute);
                f.d += new Form3.Mydel(Show1);
                f.Show();
            }    
        }

       
    }
}
