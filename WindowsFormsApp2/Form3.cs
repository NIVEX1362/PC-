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
    public partial class Form3 : Form
    {
        public Detail[] Corpusa = new Detail[4];
        public Form3()
        {
            InitializeComponent();

            Corpusa[0] = new Detail();
            Corpusa[0].name = "Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1";
            Corpusa[0].picture = pictureBox1;

            Corpusa[1] = new Detail();
            Corpusa[1].name = "Корпус GiNZZU GL5501";
            Corpusa[1].picture = pictureBox2;

            Corpusa[2] = new Detail();
            Corpusa[2].name = "Корпус Корпус GiNZZU GL550 2";
            Corpusa[2].picture = pictureBox3;

            Corpusa[3] = new Detail();
            Corpusa[3].name = "Корпус Корпус CoolerMaster MasterBox Q300P MCB-Q300P-KANN-S02 черный 2";
            Corpusa[3].picture = pictureBox4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
             Corpusa[i].picture.Visible = false;
            if (textBox1.Text != "" &&
               Corpusa[i].name == textBox1.Text)
              {
               Corpusa[i].picture.Visible = true;
              }


                    }
        }
    }
}
