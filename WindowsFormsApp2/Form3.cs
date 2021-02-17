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
    }
    public partial class Form3 : Form
    {
        public Detail[] details = new Detail[400];

        public Form3()
        {
            InitializeComponent();



            details[0] = new Detail();
            details[0].category = "Корпуса";
            details[0].name = "Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1";
            //details[0].picture = pictureBox1;

            details[1] = new Detail();
            details[1].category = "Корпуса";
            details[1].name = "Корпус GiNZZU GL5501";
            //details[1].picture = pictureBox2;

            details[2] = new Detail();
            details[2].category = "Корпуса";
            details[2].name = "Корпус GiNZZU GL550 2";
            //details[2].picture = pictureBox3;

            details[3] = new Detail();
            details[3].category = "Корпуса";
            details[3].name = "Корпус CoolerMaster MasterBox Q300P MCB-Q300P-KANN-S02 черный 2";
            //details[3].picture = pictureBox4;

            details[4] = new Detail();
            details[4].category = "Корпуса";
            details[4].name = "Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1";
            //details[4].picture = pictureBox5;

            details[5] = new Detail();
            details[5].category = "Корпуса";
            details[5].name = "Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 2";
            //details[5].picture = pictureBox5;

            details[6] = new Detail();
            details[6].category = "Видеокарты";
            details[6].name = "Видеокарта-GIGABYTE-GeForce-RTX-2080-Super-AORUS-WATERFORCE-WB";
            //details[6].picture = pictureBox6;

            details[7] = new Detail();
            details[7].category = "Видеокарты";
            details[7].name = "Видеокарта KFA2 GeForce GTX 1080 Ti HOF";
            //details[3].picture = pictureBox7;

            details[8] = new Detail();
            details[8].name = "Видеокарта Gigabyte GeForce GTX 1080 Ti AORUS XTREME WB";
            //details[8].picture = pictureBox8;

            details[9] = new Detail();
            details[9].name = "Видеокарта Gigabyte GeForce GTX 1060 WF OC";
            //details[9].picture = pictureBox9;

            details[10] = new Detail();
            details[10].name = "RTX 2060 D6";
            //details[10].picture = pictureBox10;

            details[11] = new Detail();
            details[11].name = "Видеокарта MSI GeForce RTX 2060 GAMING";
            //details[11].picture = pictureBox11;


            
            int x = 55;
            int y = 120;  
            for (int i = 0; i < 12 ; i++)
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
                catch (Exception) { }
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
            for (int i = 0; i < 4; i++)
            {
             details[i].picture.Visible = false;
            if (textBox1.Text != "" &&
               details[i].name == textBox1.Text)
              {
               details[i].picture.Visible = true;
              }


                    }
        }
    }
}
