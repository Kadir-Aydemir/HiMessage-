using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;
using HiMessage.Forms;

namespace HiMessage
{
    public partial class HiMessageLogin : Form
    {
        public HiMessageLogin()
        {
            InitializeComponent();
            Init_Data();
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
        private void Init_Data()
        {
            if (Settings1.Default.username != string.Empty)
            {
                if (Settings1.Default.remember == true)
                {
                    txtusernumber.Text = Settings1.Default.username;
                    chkremember.Checked = true;
                    txtuserpassword.Focus();
                }
                else
                {
                    txtusernumber.Text = "User Number";
                    txtusernumber.ForeColor = Color.DarkGray;
                }
            }
        }
        private void Save_Data()
        {
            if (chkremember.Checked)
            {
                Settings1.Default.username = txtusernumber.Text.Trim();
                Settings1.Default.remember = true;
                Settings1.Default.Save();
            }
            else
            {
                Settings1.Default.username = "";
                Settings1.Default.remember = false;
                Settings1.Default.Save();
            }
        }
        private void txtusernumber_Enter(object sender, EventArgs e)
        {
            if (txtusernumber.Text == "User Number")
            {
                txtusernumber.Text = "";
            }
            txtusernumber.ForeColor = Color.White;
        }

        private void txtusernumber_Leave(object sender, EventArgs e)
        {
            if (txtusernumber.Text == "")
            {
                txtusernumber.Text = "User Number";
                txtusernumber.ForeColor = Color.DarkGray;
            }
        }

        private void txtuserpassword_Enter(object sender, EventArgs e)
        {        
             if (txtuserpassword.Text == "Password")
             {
                 txtuserpassword.Text = "";
             }
             txtuserpassword.ForeColor = Color.White;            
        }

        private void txtuserpassword_Leave(object sender, EventArgs e)
        {
            if (txtuserpassword.Text == "")
            {
                txtuserpassword.Text = "Password";
                txtuserpassword.ForeColor = Color.DarkGray;
            }            
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelsignup.Visible = false;
            lblpassword.Visible = false;
            txtfirstname.Text = "First Name";
            txtfirstname.ForeColor = Color.DarkGray;
            txtlastname.Text = "Last Name";
            txtlastname.ForeColor = Color.DarkGray;
            msknumber.Clear();
            txtmail.Text = "someone@gmail.com";
            txtmail.ForeColor = Color.DarkGray;
            txtpassword1.Text = "Password";
            txtpassword1.ForeColor = Color.DarkGray;
            txtpassword2.Text = "Re-Enter Password";
            txtpassword2.ForeColor = Color.DarkGray;
            lblsuccessfully.Visible = false;
            bunifuCheckbox1.Checked = false;

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
            {
                btnsignup.Visible = true;
            }
            if (bunifuCheckbox1.Checked == false)
            {
                btnsignup.Visible = false;
            }
        }

        private void txtfirstname_Enter(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "First Name")
            {
                txtfirstname.Text = "";
            }
            txtfirstname.ForeColor = Color.White;
        }

        private void txtfirstname_Leave(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "")
            {
                txtfirstname.Text = "First Name";
                txtfirstname.ForeColor = Color.DarkGray;
            }            
        }

        private void txtlastname_Enter(object sender, EventArgs e)
        {

            if (txtlastname.Text == "Last Name")
            {
                txtlastname.Text = "";
            }
            txtlastname.ForeColor = Color.White;
        }

        private void txtlastname_Leave(object sender, EventArgs e)
        {
            if (txtlastname.Text == "")
            {
                txtlastname.Text = "Last Name";
                txtlastname.ForeColor = Color.DarkGray;
            }            
        }
       
        private void txtpassword1_Enter(object sender, EventArgs e)
        {
            if (txtpassword1.Text == "Password")
            {
                txtpassword1.Text = "";
            }
            txtpassword1.ForeColor = Color.White;
        }

        private void txtpassword1_Leave(object sender, EventArgs e)
        {
            if (txtpassword1.Text == "")
            {
                txtpassword1.Text = "Password";
                txtpassword1.ForeColor = Color.DarkGray;
            }            
        }

        private void txtpassword2_Enter(object sender, EventArgs e)
        {
            if (txtpassword2.Text == "Re-Enter Password")
            {
                txtpassword2.Text = "";
            }
            txtpassword2.ForeColor = Color.White;
        }

        private void txtpassword2_Leave(object sender, EventArgs e)
        {
            if (txtpassword2.Text == "")
            {
                txtpassword2.Text = "Re-Enter Password";
                txtpassword2.ForeColor = Color.DarkGray;
            }            
        }
        int durum = 1;
        void online()
        {
            SqlCommand komut = new SqlCommand("update TBLONLINE set DURUM='" + durum + "' where NUMARA=" + txtusernumber.Text, bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where NUMARA=@P1 and SIFRE=@P2", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", txtusernumber.Text);
            komut.Parameters.AddWithValue("@P2", txtuserpassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Save_Data();
                online();
                HiMessage him = new HiMessage();
                him.number = txtusernumber.Text;
                him.Show();
                this.Hide();
            }
            else
            {
                lblwrong.Visible = true;
            }
            bgl.baglanti().Close();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            if (txtpassword1.Text == txtpassword2.Text)
            {
                SqlCommand komut = new SqlCommand("insert into TBLKISILER (AD,SOYAD,NUMARA,SIFRE,MAIL,FOTO) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtfirstname.Text);
                komut.Parameters.AddWithValue("@p2", txtlastname.Text);
                komut.Parameters.AddWithValue("@p3", msknumber.Text);
                komut.Parameters.AddWithValue("@p4", txtpassword1.Text);
                komut.Parameters.AddWithValue("@p5", txtmail.Text);
                komut.Parameters.AddWithValue("@p6", Application.StartupPath+ "\\picture\\default.png");
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                SqlCommand komut2 = new SqlCommand("insert into TBLONLINE (AD_SOYAD,NUMARA) values (@p1,@p2)", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtfirstname.Text+" "+txtlastname.Text);
                komut2.Parameters.AddWithValue("@p2", msknumber.Text);       
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                btnsignup.Visible = false;
                lblsuccessfully.Visible = true;
                lblpassword.Visible = false;
            }
            else
            {
                lblpassword.Visible = true;
            }
        }

        private void txtmail_Enter(object sender, EventArgs e)
        {
            if (txtmail.Text == "someone@gmail.com")
            {
                txtmail.Text = "";
            }
            txtmail.ForeColor = Color.White;
        }

        private void txtmail_Leave(object sender, EventArgs e)
        {
            if (txtmail.Text == "")
            {
                txtmail.Text = "someone@gmail.com";
                txtmail.ForeColor = Color.DarkGray;
            }            
        }
            
        private void lblsignup_Click(object sender, EventArgs e)
        {
            panelsignup.Visible = true;
            lblwrong.Visible = false;
            panelsignup.BringToFront();
        }

        private void lbliforgetlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HiMessageForget fr = new HiMessageForget();
            fr.Show();
            this.Hide();
        }
    }
}
