using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsN1VeX
{
    public partial class CategoryForm : Form
    {
        public CategoryForm(string category) 
        {
            InitializeComponent();
            if (category == "Корпуса")
            {
                label1.Text = "GiNZZU GL5501";
                pictureBox1.Load("../../Resources/Корпуса/Корпус " + label1.Text + ".jpg");
                label2.Text = "1STPLAYER DK DX 11";
                pictureBox2.Load("../../Resources/Корпуса/Корпус " + label2.Text + ".jpg");
                label3.Text = "Cougar MX660 Mesh RGB";
                pictureBox3.Load("../../Resources/Корпуса/Корпус " + label3.Text + ".jpg");
                label4.Text = "DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1";
                pictureBox4.Load("../../Resources/Корпуса/Корпус " + label4.Text + ".jpg");
                
            }
            
            if (category == "Видеокарты")
           
            {
                pictureBox1.Load("../../Resources/Видеокарты/Видеокарта Видеокарта Palit GeForce RTX 2080 Super GAMEROCK Premium Edition.jpg");
                pictureBox2.Load("../../Resources/Видеокарты/RX 5500 XT Трёх вентеляторная версия.jpg");
                pictureBox3.Load("../../Resources/Видеокарты/Видеокарта MSI GeForce RTX 2060 GAMING.jpg");
                pictureBox4.Load("../../Resources/Видеокарты/Видеокарта KFA2 GeForce GTX 1080 Ti HOF.jpg");
                pictureBox5.Load("../../Resources/Видеокарты/Видеокарта GIGABYTE GeForce RTX 3090 GAMING OC.PNG");
            };


            if (category == "Блок питания")
            {
                pictureBox5.Load("../../Resources/Блок питания/Блок питания Corsair CV550.jpg");
                label1.Text = "Блок питания Corsair CV550";
            };


            if (category == "Материнская плата")
            {
                pictureBox1.Load("../../Resources/Материнская плата/9317e0e02ea10fd61df56299452f8cee8a04eec0eae9ca4473344a9cb6402ee2.jpg");
            };


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
