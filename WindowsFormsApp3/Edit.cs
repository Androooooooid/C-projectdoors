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
    public partial class Edit : Form
    {
        public string price;
        public string name;
        public bool edited;//Флаг, была ли нажата кнопка ОК или отмена (и так сайдет)
        public Edit(string NAME, float PRICE)//Если изменение
        {
            InitializeComponent();
            name = NAME;
            price = PRICE.ToString();
            edited = false;
            NameBox.Text = name;
            PriceBox.Text = price;
        }
        public Edit()//Если добавление
        {
            InitializeComponent();
            name = "";
            price = "";
            edited = false;
            label3.Text = "Добавление";
        }
        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            price = PriceBox.Text;
            name = NameBox.Text;
            edited = true;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
