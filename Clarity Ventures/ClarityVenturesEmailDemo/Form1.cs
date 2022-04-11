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

namespace ClarityVenturesEmailDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void sendButton_Click(object sender, EventArgs e)
        //{
        //    SmtpClient client = new SmtpClient()
        //    {
        //        EnableSsl = true,
        //        Host = "smtp.gmail.com",
        //        Port = 587,
        //        DeliveryMethod = SmtpDeliveryMethod.Network,
        //        UseDefaultCredentials = false,
        //        Credentials = new NetworkCredential()
        //        {

        //        }
        //    }
        //}
    }
}
