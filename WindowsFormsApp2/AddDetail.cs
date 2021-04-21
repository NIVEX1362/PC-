using Microsoft.Owin.BuilderProperties;
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
    public partial class AddDetail : Form
    {
        public AddDetail()
        {
            InitializeComponent();
        }

       

       private void button1_Click_1(object sender, EventArgs e)
        {
            File.AppendAllText("../../../Комплектующие.txt", Environment.NewLine +
                 textBox1.Text + ", " + comboBox1.Text + ", " + priceTB.Text);
            if (address != "" && !File.Exists("../../Resources/" + comboBox1.Text + "/" + textBox1.Text + ".jpg"))
            {
                File.Copy(address, "../../Resources/" + comboBox1.Text + "/" + textBox1.Text + ".jpg");
            }

                File.WriteAllText("../../Resources/" + comboBox1.Text + "/" + textBox1.Text + ".txt", textBox1.Text);
        }

        string address;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

  

}
