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
    public partial class UserControl1 : UserControl
    {
        Detail detail;
        public UserControl1(Detail detail1)
        {
         
            detail = detail1;
            InitializeComponent();
            
            comboBox1.Items.Clear();
            pictureBox1.Image = detail.picture.Image;
            comboBox1.Text = detail.currentColor;  
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AllDetails.korzina.Remove(detail);
        }
    
    

    }
}
