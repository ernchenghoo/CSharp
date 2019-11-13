using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace AssignmentCSharp.Main.View
{
    public partial class EmailSupplierForm : Form
    {
        public EmailSupplierForm(string email,int itemId,String foodname)
        {
            InitializeComponent();
            textBoxTo.Text = email;
            textBoxSubject.Text = "Request for more stock for item ";
            textBoxSubject.Text += foodname;
            textBoxContent.Text = "The number of amount will be needed is ";
            this.id = itemId;
        }
        readonly int id = 0;

        private void EmailSupplierForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("restaurantGoodFood923@gmail.com","Asd@1234");
                MailMessage msg = new MailMessage();
                msg.To.Add(textBoxTo.Text);
                msg.From = new MailAddress("restaurantGoodFood923@gmail.com");
                msg.Subject = textBoxSubject.Text;
                msg.Body = textBoxContent.Text;
                client.Send(msg);
                MessageBox.Show(string.Format("Successful send to {0}", textBoxTo.Text));
                Model.FoodStock foodId = new Model.FoodStock(id, false);
                foodId.ValidToSendEmail();
                this.Close();

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
