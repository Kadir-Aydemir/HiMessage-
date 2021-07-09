using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net.Mail;
using System.Net;

namespace HiMessage
{
    public partial class HiMessageForget : Form
    {
        public HiMessageForget()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void panelcontrol_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void txtforgetnumber_Enter(object sender, EventArgs e)
        {
            if (txtforgetnumber.Text == "User Number")
            {
                txtforgetnumber.Text = "";
            }
            txtforgetnumber.ForeColor = Color.White;
        }

        private void txtforgetnumber_Leave(object sender, EventArgs e)
        {
            if (txtforgetnumber.Text == "")
            {
                txtforgetnumber.Text = "User Number";
                txtforgetnumber.ForeColor = Color.DarkGray;
            }
        }
        void clean()
        {
            btnsendmail.Visible = false;
            btnverify.Visible = false;
            progressbar1.Visible = false;
            lblempty.Visible = false;
            txtverify.Visible = false;
            lblmailsent.Visible = false;
            lblaccount.Visible = false;
            pictureBox7.Visible = false;
        }
        private void btncheckit_Click(object sender, EventArgs e)
        {
            clean();
            if (txtforgetnumber.Text != "")
            {
                SqlCommand komut = new SqlCommand("select MAIL,SIFRE from TBLKISILER where NUMARA=" + txtforgetnumber.Text, bgl.baglanti());
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    btncheckit.Visible = false;
                    btnsendmail.Visible = true;
                    txtforgetmail.Visible = true;
                    pictureBox7.Visible = true;
                    lblempty.Visible = false;
                    lblaccount.Visible = false;
                    txtforgetmail.Text = dr[0].ToString();
                    lblforgetpassword.Text = dr[1].ToString();
                }
                else
                {
                    lblaccount.Visible = true;
                }
            }
            else
            {
                lblempty.Visible = true;
            }
        }

        int sayi;
        private void btnverify_Click(object sender, EventArgs e)
        {
            if (txtverify.Text == sayi.ToString())
            {
                SmtpClient sc = new SmtpClient();
                sc.Port = 587;
                sc.Host = "smtp.gmail.com";
                sc.EnableSsl = true;

                string kime = txtforgetmail.Text;
                string konu = "Your HiMessage account information";
                string icerik = "Your information is safe with us.\n Account password is: " + lblforgetpassword.Text;

                sc.Credentials = new NetworkCredential("aydemirsoftware@gmail.com", "191119ea");
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("aydemirsoftware@gmail.com", "AYDEMİR YAZILIM");
                mail.To.Add(kime);
                mail.Subject = konu;
                mail.IsBodyHtml = true;
                mail.Body = icerik;
                sc.Send(mail);
                HiMessageLogin fr = new HiMessageLogin();
                fr.lblsent.Visible = true;
                fr.Show();
                this.Hide();
            }           
        }
        int sayac = 95;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            progressbar1.Value = sayac;
            if (sayac == 35)
            {
                progressbar1.ProgressColor = Color.Firebrick;
                progressbar1.ForeColor = Color.Firebrick;
            }
            if (sayac == 5)
            {
                lblmailsent.Visible = false;
                lbltimeup.Visible = true;
            }
            if (sayac == 0)
            {
                timer1.Stop();
                HiMessageLogin fr = new HiMessageLogin();
                fr.Show();
                this.Hide();
            }
        }
         Random rdm = new Random();

        private void btnsendmail_Click(object sender, EventArgs e)
        {
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sayi = rdm.Next(10000, 99999);
            string kime = txtforgetmail.Text;
            string konu = "Your HiMessage account verify!";
            string icerik = "Your information is safe with us.\n Verification Code is: " + sayi.ToString();

            sc.Credentials = new NetworkCredential("aydemirsoftware@gmail.com", "191119ea");
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("aydemirsoftware@gmail.com", "AYDEMİR YAZILIM");
            mail.To.Add(kime);
            mail.Subject = konu;
            mail.IsBodyHtml = true;
            mail.Body = icerik;
            sc.Send(mail);
            lblmailsent.Visible = true;
            btnsendmail.Visible = false;
            btnverify.Visible = true;
            progressbar1.Visible = true;
            txtverify.Visible = true;
            timer1.Start();
        }

        private void lblbacktologin_Click(object sender, EventArgs e)
        {
            HiMessageLogin fr = new HiMessageLogin();
            fr.Show();
            this.Hide();
        }
    }
}
