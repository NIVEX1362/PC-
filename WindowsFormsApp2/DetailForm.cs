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
    public partial class DetailForm : Form
    {
        Detail detail;
        public DetailForm(string _detail)
        {
            InitializeComponent();

            foreach (Detail detail1 in AllDetails.details_List)
            {
                if (detail1.name == _detail)
                {
                    detail = detail1;
                    pictureBox1.Image = detail1.picture.Image;

                    comboBox1.DataSource = detail.picture.Image;
                    detail.currentColor = comboBox1.Text;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void button1_Click_1(object sender, EventArgs e)
        {
            
            if (AllDetails.korzina.ContainsKey(detail))
            {
                
                AllDetails.korzina[detail] = AllDetails.korzina[detail] + 1;
            }
            
            else
            {
                AllDetails.korzina.Add(detail, 1);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            detail.currentColor = comboBox1.Text;
        }
    }
}
