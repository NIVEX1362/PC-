using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать))");
        }

    
          
       
        
          private void button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.citilink.ru/catalog/computers_and_notebooks/parts/motherboards/?gclid=EAIaIQobChMIw9zRi4GP7gIVAt-yCh0d3QwHEAAYASAAEgI_4fD_BwE");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }


}
