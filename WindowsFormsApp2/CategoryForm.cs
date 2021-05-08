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

            int x = 55;
            int y = 120;
            foreach (Detail corpus in AllDetails.details_List)
            {
                //Прилетели корпуса, ищем их. Видеокарты - их
                if (corpus.category == category)
                {
                    //Картинка с товаром
                    PictureBox picture = new PictureBox();
                    picture.Location = new Point(x, y);
                    picture.Size = new Size(120, 120);
                    picture.SizeMode = PictureBoxSizeMode.Zoom;
                    picture.Click += new EventHandler(AllDetails.OpenDetail);
                    picture.Tag = corpus.name;
                    picture.Image = corpus.picture.Image;
                    Controls.Add(picture);

                    //Штука чтобы подписать название
                    Label label = new Label();
                    label.Location = new Point(x, y + 170);
                    label.Size = new Size(120, 90);
                    label.Text = corpus.name;
                    Controls.Add(label);

                    x = x + 170;
                    if (x + 130 > Width)
                    {
                        x = 50;
                        y = y + 260;
                    }
                }    
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
