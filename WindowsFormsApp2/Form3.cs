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
    public struct Detail
    {
        public PictureBox picture;
        public Label label;

        public int price;
        public string category;
        public string name;
        public string opisanie;
        public Detail(string name1, string category1, int price1)
        {
            label = new Label();
            picture = new PictureBox();
            name = name1;
            price = price1;
            category = category1;
            opisanie = "";
        }
    }
    public partial class Form3 : Form
    {
        public Detail[] details = new Detail[400];

        public Form3()
        {
            InitializeComponent();

            details[0] = new Detail("Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1", "Корпуса", 0);
            details[1] = new Detail("Корпус GiNZZU GL5501", "Корпуса", 0);
            details[2] = new Detail("Корпус GiNZZU GL5501", "Корпуса", 30);
            details[3] = new Detail("Корпус CoolerMaster MasterBox Q300P MCB-Q300P-KANN-S02 черный 2", "Корпуса", 115);
            details[4] = new Detail("Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1", "Корпуса", 30);
            details[5] = new Detail("Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 2", "Корпуса", 1211);
            details[6] = new Detail("Видеокарта-GIGABYTE-GeForce-RTX-2080-Super-AORUS-WATERFORCE-WB", "Видеокарты", 60000);
            details[7] = new Detail("Видеокарта KFA2 GeForce GTX 1080 Ti HOF", "Видекарты", 55000);
            details[8] = new Detail("Видеокарта Gigabyte GeForce GTX 1080 Ti AORUS XTREME WB", "Видекарты", 85000);
            details[9] = new Detail("Видеокарта Gigabyte GeForce GTX 1060 WF O", "Видекарты", 20000);
            details[10] = new Detail("Видеокарта MSI GeForce RTX 2060 GAMING", "Видекарты", 20000);     

            int x = 55;
            int y = 120;  
            for (int i = 0; i < 11 ; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(x, y);
                //pb.Text = details[i].category + details[i];
                pb.Size = new Size(120, 120);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                //pb.Click += new EventHandler(button1_Click);
                try
                {
                    pb.Load("../../Resources/" + details[i].category + "/" + details[i].name + ".jpg");
                }
                catch (Exception ex) {
                   
                }
                details[i].picture = pb;

                Controls.Add(pb);



                Label label1 = new Label();
                label1.Location = new Point(55 + 170 * i, 270);
                label1.Size = new Size(120, 90);
                label1.Text = details[i].name;
                details[i].label = label1;
                Controls.Add(label1);
            
                x = x + 170;
                if (x + 130 > Width) 
                {
                    x = 50;
                    y = y + 260;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                details[i].picture.Visible = true;

                if (nameTextBox.Text != "" &&
                    !details[i].name.Contains(nameTextBox.Text))
                {
                    details[i].picture.Visible = false;
                }


                if (priceTextBox.Text != "" &&
                    details[i].price > Convert.ToInt32(priceTextBox.Text))
                {
                    details[i].picture.Visible = false;
                }


                details[i].label.Visible = details[i].picture.Visible;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}