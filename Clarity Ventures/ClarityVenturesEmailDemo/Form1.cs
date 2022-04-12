using Microsoft.Data.SqlClient;
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
using ClarityVenturesEmailLogic;

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

        private void sendButton_Click(object sender, EventArgs e)
        {
            //string connectionString = "Server=P137G001\\SQLEXPRESS;Database=email_log;Trusted_Connection=True;";
            //string senderEmail = "vv.fitness614@gmail.com";
            //string sqlQuery = "INSERT INTO email_details (sender, recipient, email_subject, email_body, email_date, email_sent) VALUES (@sender, @recipient, @email_subject, @email_body, GETDATE(), 1)";

            ////try
            ////{
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{

            //    SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            //    conn.Open();

            //    cmd.Parameters.AddWithValue("@sender", senderEmail);
            //    cmd.Parameters.AddWithValue("@recipient", textRecipient);
            //    cmd.Parameters.AddWithValue("@email_subject", textSubject);
            //    cmd.Parameters.AddWithValue("@email_body", textMessageBody);
            //    cmd.ExecuteNonQuery();
            //}
            ////}
            ////catch (SqlException)
            ////{
            ////    throw;
            ////}
            SmtpClient client = new SmtpClient()
            {
                EnableSsl = true,
                Host = "smtp.gmail.com",
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = "vv.test.dummy@gmail.com",
                    Password = "VVTestDummy!15"
                }
            };

            MailAddress fromEmail = new MailAddress("vv.test.dummy@gmail.com", "Test Dummy");
            MailAddress toEmail = new MailAddress(textRecipient.Text);
            MailMessage message = new MailMessage()
            {
                From = fromEmail,
                Subject = textSubject.Text,
                Body = textMessageBody.Text,
            };

            message.To.Add(toEmail);
            client.SendCompleted += Client_SendCompleted;
            client.SendMailAsync(message);
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("An error has occured \n" + e.Error.Message);
                return;
            }
            else
            {
                MessageBox.Show("Message sent successfully!");
            }
        }
    }
}

