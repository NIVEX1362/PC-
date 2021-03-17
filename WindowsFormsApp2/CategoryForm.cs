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

            /*
            if (category == "Видеокарты")
           
            {
                pictureBox1.Load("../../Resources/Видеокарты/Видеокарта Видеокарта Palit GeForce RTX 2080 Super GAMEROCK Premium Edition.png");
                pictureBox2.Load("../../Resources/Видеокарты/RX 5500 XT Трёх вентеляторная версия.jpg");
                pictureBox3.Load("../../Resources/Видеокарты/Видеокарта MSI GeForce RTX 2060 GAMING.jpg");
                pictureBox4.Load("../../Resources/Видеокарты/Видеокарта KFA2 GeForce GTX 1080 Ti HOF.jpg");
                pictureBox5.Load("../../Resources/Видеокарты/Видеокарта GIGABYTE GeForce RTX 3090 GAMING OC.PNG");
            };


            if (category == "Блок питания")
            {
                pictureBox1.Load("../../Resources/Блок питания/Блок питания Corsair CV550.jpg");
                label1.Text = "Блок питания Corsair CV550";
                pictureBox2.Load("../../Resources/Блок питания/Блок питания CoolerMaster MWE 550 WHITE - V2.jpg");
                label2.Text = "Блок питания CoolerMaster MWE 550 WHITE - V2";
                pictureBox3.Load("../../Resources/Блок питания/Блок питания Thermaltake Toughpower GX1 500W.jpg");
                label3.Text = "Блок питания Thermaltake Toughpower GX1 500W";
                pictureBox4.Load("../../Resources/Блок питания/Блок питания Deepcool DQ650.jpg");
                label4.Text = "Блок питания Deepcool DQ650";
            };


            if (category == "Материнская плата")
            {
                pictureBox1.Load("../../Resources/Материнская плата/9317e0e02ea10fd61df56299452f8cee8a04eec0eae9ca4473344a9cb6402ee2.jpg");
                pictureBox2.Load("../../Resources/Материнская плата/4099e82f1be5c9dd2086cf5de8e45a47f061e322d58cedbadf393c508b114e8b.jpg");
                pictureBox3.Load("../../Resources/Материнская плата/09bab6ed50fc38029439aa5caad07443835fa8cfc49c2692aa9984ba2870fa6b.PNG");
                pictureBox4.Load("../../Resources/Материнская плата/2de13d051733280d1648517adda08e90a5dd0910cc3abae1322067f1006218af.PNG");
            };

            if (category == "Процессоры")

            {
                pictureBox1.Load("../../Resources/Процессоры/2de1a89609e4467e2ff4010ba0be6778e71f286aeb4d58cf124f510c491235f9.jpg");
                pictureBox2.Load("../../Resources/Процессоры/6d9ff4da2157134e83ed50140afcd6a41bbb8638147fdbd106f04bfb23cc90e8.jpg");
                pictureBox3.Load("../../Resources/Процессоры/48822a842545ffd3059d8bf32cddba99d975471429e8baba07877f82bde2c164.jpg");
                pictureBox4.Load("../../Resources/Процессоры/f4363b2efd4f5292f57eb5e37ea92e7a1a590fd34a01341d135497737883e9f4.jpg");
                pictureBox5.Load("../../Resources/Процессоры/db27210e31d1ea3ab6dc2e372d493d177bc55764fcf10e88879340b78038486e.jpg");
            };*/
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
