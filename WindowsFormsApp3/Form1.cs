using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private database_work database;
        

        private void Form1_Load(object sender, EventArgs e)
        {
            database = new database_work();
            name_comp.DisplayMember = "materials";
            name_comp.ValueMember = "id";
            update();
        }

        private void update()
        {
            name_comp.DataSource = database.getfield();
        }

        private void name_comp_SelectedIndexChanged(object sender, EventArgs e)
        {
            price_up.Text = database.getprice(name_comp.SelectedIndex+1).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedindex = name_comp.SelectedIndex;
            database.updateprice(name_comp.SelectedIndex + 1,price_up.Text);
            update();
            name_comp.SelectedIndex = selectedindex;
        }
    }
}


