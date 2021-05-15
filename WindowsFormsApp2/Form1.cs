using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsN1VeX
{ 



       
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }



        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Войдите");
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

     

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Корпуса");


            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Видеокарты");
            f.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Блок питания");
            f.Show();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Процессоры");
            f.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            CategoryForm f = new CategoryForm("Охлаждение");
            f.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Оперативная память");
            f.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("Материнская плата");
            f.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("HDD");
            f.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CategoryForm f = new CategoryForm("SSD");
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllDetails f = new AllDetails();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CartForm().Show();
        }

        private void Russian_Click(object sender, EventArgs e)
        {
            translate(AllDetails.RusWords);
        }

        void translate(Dictionary<string, string> words)
        {
            button1.Text = words["Все комплектующие"];
            button2.Text = words["Корзина"];
            button5.Text = words["Войдите"];
            button7.Text = words["Обратная связь"];
            label1.Text = words["Видеокарты"];
            label2.Text = words["Корпуса"];
            label3.Text = words["Блок питания"];
            label4.Text = words["Процессоры"];
            label5.Text = words["ССД"];
            label6.Text = words["Охлаждение"];
            label7.Text = words["Оперативная память"];
            label8.Text = words["Материнская плата"];
            label9.Text = words["Жёсткий диск"];
            label10.Text = words["Добавить комплектующие"];

        }


        private void English_Click(object sender, EventArgs e)
        {
            translate(AllDetails.EngWords);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddDetail f = new AddDetail();
            f.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoginForm f = new LoginForm();
            f.ShowDialog();

        label10.Visible = (LoginForm.Login == "Admin");
        button6.Visible = (LoginForm.Login == "Admin");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ObrSvyaz f = new ObrSvyaz();
            f.ShowDialog();
        }
    }
}
