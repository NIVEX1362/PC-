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
                UserControl1 uc = new UserControl1(detail);
                uc.Location = new Point(0, y);
                Controls.Add(uc);

                int Count = pair.Value;

                y = y + 50;
            }
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
