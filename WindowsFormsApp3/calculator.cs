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
    public partial class calculator : Form
    {

        private database_work database=new database_work();//объявить

        public calculator()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void calculator_Load(object sender, EventArgs e)
        {
            
        }

        private double calc_ursa()
        {
            int width = Convert.ToInt32(widthbox.Text);
            int height = Convert.ToInt32(heightbox.Text);
            int thickness = Convert.ToInt32(thicknessbox.Text);
            double V = width * height * thickness;
            double calc_ursa_price = V / 1000000000 * get_ursa_price();
            return calc_ursa_price;
        }

        private int get_ursa_price()
        {
            return 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label19.Text = Convert.ToString(calc_ursa());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label19.Text = database.getprice(3).ToString();// юзаем запрос скйль из датабэйсворк
        }
    }
}
