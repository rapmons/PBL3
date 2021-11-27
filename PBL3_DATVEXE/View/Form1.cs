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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            dataGridView1.DataSource = BLL_Route.Instance.getallRoute();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text= dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DTO_route r = new DTO_route();
            r.id_route = textBox1.Text;
            r.departure = textBox2.Text;
            r.arrival = textBox3.Text;
            r.deleted = false;
            BLL_Route.Instance.add_route(r);
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DTO_route r = new DTO_route();
            r.id_route = textBox1.Text;
            r.departure = textBox2.Text;
            r.arrival = textBox3.Text;
            r.deleted = false;
            BLL_Route.Instance.edit(r);
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DTO_route r = new DTO_route();
            r.id_route = textBox1.Text;
            r.departure = textBox2.Text;
            r.arrival = textBox3.Text;
            r.deleted = false;
            BLL_Route.Instance.deleteRoute(r.id_route);
            load();
        }
    }
}
