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
    public partial class CartForm : Form
    {
        public CartForm()
        {
            InitializeComponent();

            int y = 20;
            //Для всех товаров из корзины
            foreach (KeyValuePair<Detail, int> pair in AllDetails.korzina)
            {
                Detail detail = pair.Key;
                int Count = pair.Value;

                //Создаем лейбл
                Label label = new Label();
                label.Location = new Point(0, y);
                //пишем в нем деталь такая-то, столько-то штук
                label.Text = detail.name + " (" + Count.ToString() + ")";
                label.Size = new Size(600, 30);
                Controls.Add(label);
                y = y + 50;
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
