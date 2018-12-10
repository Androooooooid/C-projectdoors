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
            ComponentList.Columns.Add("id");
            ComponentList.Columns.Add("Наименование");
            ComponentList.Columns.Add("Цена");
            ComponentList.Columns[0].Width = 0; //Схлопнутый столбец c id
            update();
        }

        private void update()
        {
            ComponentList.Items.Clear();//Очищаем форму (нужно для апдейта)

            foreach (string[] masstr in database.getfield())//Вытаскиваем список из базы данных и распарсиваем его
            {
                ListViewItem component = new ListViewItem(); //По факту -id
                ListViewItem.ListViewSubItem name = new ListViewItem.ListViewSubItem();
                ListViewItem.ListViewSubItem price = new ListViewItem.ListViewSubItem();
                component.Text = masstr[0];
                name.Text = masstr[1];
                price.Text = masstr[2];
                component.SubItems.Add(name);//Пихаем в item subitem
                component.SubItems.Add(price);//Пихаем subitem в item
                ComponentList.Items.Add(component);//Добавляем на форму новый компонент
            }
            ComponentList.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            ComponentList.Columns[2].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void name_comp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void ComponentList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ComponentList_DoubleClick(object sender, EventArgs e)//Двойной щелчок по таблице
        {
            if (ComponentList.SelectedItems.Count != 0)//Ну мало ли! иначе может глючить
            {
                int id = int.Parse(ComponentList.SelectedItems[0].Text);//Вытаскиваем id из схлопнутого [0] столбца выделенной строки

                Edit CompEdit = new Edit(database.getname(id), database.getprice(id));//Создаем форму, пихаем в ее конструктор название и цену
                CompEdit.ShowDialog();//Показываем как диалог
                if(CompEdit.edited)//Когда диалог закрывается, смотрим какая кнопка была нажата ок, или отменить
                {
                    database.updateprice(id, CompEdit.price); 
                    database.updatename(id, CompEdit.name);//Апдейтим если был нажат ОК
                }
                update();//Перезагружаем элементы из бд
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Edit CompEdit = new Edit();
            CompEdit.ShowDialog();
            if (CompEdit.edited)
            {
                //Ну тут запрос на INSERT кароче
            }
            update();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calculator opencal = new calculator();
            opencal.ShowDialog();
        }
    }
}


