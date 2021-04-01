using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportGui
{
    public class MailForm : Form1
    {
        public string emailAddress { get; set; }
        public string body { get; set; }

        public string subject = "ÖV-Berbindung";

        public MailForm ()
        {
            emailAddress = this.emailAddress;
            body = this.body;
        }

        public void sendMail ()
        {
            Process.Start("mailto:" + emailAddress + "?subject=" + subject + "&body="
            + body);
        }
    }
}
