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
        //public Detail[] details = new Detail[400];
        public List<Detail> details_List = new List<Detail>();

       
        public Form3()
        {
            InitializeComponent();
            details_List.Add ( new Detail("Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1", "Корпуса", 0));
            details_List.Add ( new Detail("Корпус GiNZZU GL5501", "Корпуса", 0));
            details_List.Add ( new Detail("Корпус GiNZZU GL5501", "Корпуса", 30));
            details_List.Add ( new Detail("Корпус CoolerMaster MasterBox Q300P MCB-Q300P-KANN-S02 черный 2", "Корпуса", 115));
            details_List.Add ( new Detail("Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 1", "Корпуса", 30));
            details_List.Add ( new Detail("Корпус DEEPCOOL MATREXX 55 V3 ADD-RGB 3F 2", "Корпуса", 1211));
            details_List.Add ( new Detail("Видеокарта-GIGABYTE-GeForce-RTX-2080-Super-AORUS-WATERFORCE-WB", "Видеокарты", 60000));
            details_List.Add ( new Detail("Видеокарта KFA2 GeForce GTX 1080 Ti HOF", "Видекарты", 55000));
            details_List.Add ( new Detail("Видеокарта Gigabyte GeForce GTX 1080 Ti AORUS XTREME WB", "Видекарты", 85000));
            details_List.Add ( new Detail("Видеокарта Gigabyte GeForce GTX 1060 WF O", "Видекарты", 20000));
            details_List.Add ( new Detail("Видеокарта MSI GeForce RTX 2060 GAMING", "Видекарты", 20000));     

            int x = 55;
            int y = 120;
            for (int i = 0; i < details_List.Count; i++) 
            {
                details_List[i].picture.Location = new Point(x, y);
                //pb.Text = details[i].category + details[i];
                details_List[i].picture.Size = new Size(120, 120);
                details_List[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                //pb.Click += new EventHandler(button1_Click);
                try
                {
                    details_List[i].picture.Load("../../Resources/" + details_List[i].category + "/" +  details_List[i].name + ".jpg");
                }
                catch (Exception ex) {
                   
                }
              
               Controls.Add( details_List[i].picture);



                details_List[i].label.Location = new Point(55 + 170 * i, 270);
                details_List[i].label.Size = new Size(120, 90);
                details_List[i].label.Text = details_List[i].name;
                Controls.Add(details_List[i].label);
            
                x = x + 170;
                if (x + 130 > Width) 
                {
                    x = 50;
                    y = y + 260;
                }
            }
                        /*
            if (details_List == "Видеокарты");
            {
                ComboBox1.details_List.Add.Clear();
                for (int i = 0; 1 < details_List. details_List[i].picture.Cout; 1++)
                {
                    if (details_List.details_List[i].descripline == "Видеокарты")
                        ComboBox1.details_List.Add(details_List.Add.details_List[i].name0);
                }
            }            */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 11; i++)
            {
                details_List[i].picture.Visible = true;

                if (nameTextBox.Text != "" &&
                     details_List[i].name.Contains(nameTextBox.Text))
                {
                    details_List[i].picture.Visible = false;
                }


                if (priceTextBox.Text != "" &&
                     details_List[i].price > Convert.ToInt32(priceTextBox.Text))
                {
                    details_List[i].picture.Visible = false;
                }


                details_List[i].label.Visible = details_List[i].picture.Visible;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
};