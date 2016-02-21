using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace eCardSender.Misc
{
    public sealed class Mailer
    {

        MailAddress fromAddress = new MailAddress("floribuda85@gmail.com", "Florin Buda");
        const string subject = "My picture!";
        private static Mailer instance=null;

        private Mailer()
        {
        }

        public static Mailer Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Mailer();
                }
                return instance;
            }
        }


        public void sendMail(String to, String message, String filePath)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("florinbuda85@gmail.com", "lrkruvrkvnhdpitl"),
                EnableSsl = true
            };
           
            client.Send("florinbuda85@gmail.com", "florinbuda85@gmail.com", "test", "testbody");
            Console.WriteLine("Sent");
        }

        /// <summary>
        /// Sends a embedded image via email
        /// </summary>
        /// <param name="to"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <param name="filePath"></param>
        public void sendHtmlMail(String to, String subject, String message, String filePath)
        {


            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("florinbuda85@gmail.com", getPassword()),
                EnableSsl = true
            };

            MailMessage newMail = new MailMessage();
            newMail.To.Add(new MailAddress(to));
            newMail.From = this.fromAddress;

            newMail.Subject = subject;
            newMail.IsBodyHtml = true;

            var inlineLogo = new LinkedResource(filePath);
            inlineLogo.ContentId = Guid.NewGuid().ToString();

            string body = string.Format(message + @"<br><br><img src=""cid:{0}"" />", inlineLogo.ContentId);

            var view = AlternateView.CreateAlternateViewFromString(body, null, "text/html");
            view.LinkedResources.Add(inlineLogo);
            newMail.AlternateViews.Add(view);

            client.Send(newMail);

            MessageBox.Show("Mail sent!");
           

        }

        private string getPassword()
        {
            string passwordEncrypted = "b7e93f19579867f744577a49f0073f82";
            string encryptionKey = Microsoft.VisualBasic.Interaction.InputBox("Type the decryption key.", "Password", "", -1, -1);

            BlowFishCS.BlowFish decryptor = new BlowFishCS.BlowFish(encryptionKey);



            return decryptor.Decrypt_ECB(passwordEncrypted);
        }
    }
}
