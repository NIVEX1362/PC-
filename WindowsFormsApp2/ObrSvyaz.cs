using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsN1VeX
{
    public partial class ObrSvyaz : Form
    {
        public ObrSvyaz()
        {
            InitializeComponent();
        }

        string Address1 = "";
        string Address2 = "";

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rpdelta132@gmail.com");
                mail.To.Add(new MailAddress("rpdelta132@gmail.com"));

                mail.Subject = "Отзыв";
                mail.IsBodyHtml = true;
                mail.Body = textBox1.Text;

                if (Address1 != "")
                {
                    Attachment attachment = new Attachment(Address1);
                    attachment.Name = "1.jpg";
                    mail.Attachments.Add(attachment);
                }
                if (Address2 != "") 
                {
                    Attachment attachment = new Attachment(Address2);
                    attachment.Name = "2.jpg";
                    mail.Attachments.Add(attachment);
                }

                //mail.Attachments.Add(new Attachment("Заказ.csv"));
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
