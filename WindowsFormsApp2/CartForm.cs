using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

                y = y + 70;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rpdelta132@gmail.com");
                mail.To.Add(new MailAddress("rpdelta132@gmail.com"));

                mail.Subject = "Новый заказ!";
                mail.IsBodyHtml = true;
                mail.Body = File.ReadAllText("Привет");

                File.WriteAllText("Заказ.csv", "Название,Цвет,Цена,Количество");
                foreach (KeyValuePair<Detail, int> pair in AllDetails.korzina)
                {
                    Detail detail = pair.Key;
                    int Count = pair.Value;

                    File.AppendAllText("Заказ.csv",
                        Environment.NewLine +
                        detail.name + "," + detail.currentColor + "," + detail.price.ToString() + "," + Count.ToString());

                    mail.Attachments.Add(new Attachment("../../Resources/" + detail.category + "/" + detail.name + ".jpg"));
                }
                mail.Attachments.Add(new Attachment("Заказ.csv"));
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(mail.From.Address, "LIYNIX1337");

                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
                mail.Dispose(); 

                MessageBox.Show("отправил");
            }
            catch (Exception ex)
            {
                throw new Exception("Mail0.Send: " + ex.Message);
            }

        }

    }
}
