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
              pictureBox1.Load("../../Resources/Корпуса/Корпус GiNZZU GL5501.jpg");
            }
            if (category == "Видеокарты")
            {
                pictureBox1.Load("../../Resources/Видеокарты/Видеокарта Видеокарта MSI GeForce RTX 3090 GAMING X TRIO КОРОБКА.jpg");
            }

            if (category == "Блок питания")
            {
                pictureBox1.Load("../../Resources/Блок питания/Блок питания Corsair CV550.jpg");
                label1.Text = "Блок питания Corsair CV550";
            }


            if (category == "Материнская плата")
            {
                pictureBox1.Load("../../Resources/Материнская плата/9317e0e02ea10fd61df56299452f8cee8a04eec0eae9ca4473344a9cb6402ee2.jpg");
            }


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
