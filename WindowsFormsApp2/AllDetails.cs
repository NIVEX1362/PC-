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
    public partial class AllDetails : Form
    {
        //public Detail[] details = new Detail[400];
        public static List<Detail> details_List = new List<Detail>();
        public static Dictionary<Detail, int> korzina = new Dictionary<Detail, int>();
        public static Dictionary<string, string> PolWords = new Dictionary<string, string>();
        public static Dictionary<string, string> RusWords = new Dictionary<string, string>();
        public static Dictionary<string, string> EngWords = new Dictionary<string, string>();


        /// <summary>
        /// Заполнить все детали
        /// </summary>
        public static void FillDetails()
        {
            

            RusWords.Add("Название", "Название");
            EngWords.Add("Название", "Name");
            RusWords.Add("Цена", "Цена");
            EngWords.Add("Цена", "Price");
            RusWords.Add("Поиск", "Поиск");
            EngWords.Add("Поиск", "Search");

            string[] lines = File.ReadAllLines("../../../Комплектующие.txt");
            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                details_List.Add(new Detail(parts[0], parts[1], Convert.ToInt32(parts[2])));
            }

            for (int i = 0; i < details_List.Count; i++)
            {
                try
                {
                    details_List[i].picture.Load("../../Resources/" + details_List[i].category + "/" + details_List[i].name + ".jpg");
                }
                catch (Exception)
                {

                }
            }
        }



        public AllDetails()
        {
            InitializeComponent();

            int x = 55;
            int y = 10;
            for (int i = 0; i < details_List.Count; i++) 
            {
                details_List[i].picture.Location = new Point(x, y);
                //pb.Text = details[i].category + details[i];
                details_List[i].picture.Tag = details_List[i].name;
                details_List[i].picture.Size = new Size(120, 120);
                details_List[i].picture.SizeMode = PictureBoxSizeMode.Zoom;
                details_List[i].picture.Click -= new EventHandler(OpenDetail);
                details_List[i].picture.Click += new EventHandler(OpenDetail);
                try
                {
                    details_List[i].picture.Load("../../Resources/" + details_List[i].category + "/" +  details_List[i].name + ".jpg");
                }
                catch (Exception) {
                   
                }
              
                panel1.Controls.Add( details_List[i].picture);



                details_List[i].label.Location = new Point(x, y + 120);
                details_List[i].label.Size = new Size(120, 90);
                details_List[i].label.Text = details_List[i].name;
                panel1.Controls.Add(details_List[i].label);
            
                x = x + 170;
                if (x + 130 > Width) 
                {
                    x = 50;
                    y = y + 260;
                }
            }
        }


        public static void OpenDetail(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            new DetailForm(pb.Tag.ToString()).Show();
        }


            private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < details_List.Count; i++)
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

        private void AllDetails_Load(object sender, EventArgs e)
        {

        }

 
        void RenameAll(Dictionary<string, string> Words)
        {
            label1.Text = Words["Название"];
        }

      

    }
};