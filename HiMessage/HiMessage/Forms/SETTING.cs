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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace HiMessage.Forms
{
    public partial class SETTING : Form
    {
        public SETTING()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        void id()
        {
            SqlCommand komut = new SqlCommand("select ID from TBLKISILER where NUMARA='" + lblnumbersetting.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblkisiid.Text = dr[0].ToString();
            }         
        }
        void password()
        {
            SqlCommand komut = new SqlCommand("select SIFRE from TBLKISILER where ID='" + lblkisiid.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblpassword.Text = dr[0].ToString();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = Settings1.Default.Backupdate.ToString();
            lbltime.Text = Settings1.Default.Backuptime.ToString();           
            lbltarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToShortTimeString();
            id();
            password();
        }

        private void btnchangepassword_Click(object sender, EventArgs e)
        {
            btnchangepassword.Enabled = false;
            panelchangepassword.Visible = true;
            pbxchange.Visible = true;
        }

        private void pbxchange_Click(object sender, EventArgs e)
        {
            btnchangepassword.Enabled = true;
            panelchangepassword.Visible = false;
            pbxchange.Visible = false;
            lblcheck.Visible = false;
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            if (lblnumbersetting.Text == lblmanagernumber.Text)
            {
                btnbackupdatabase.Enabled = false;
                panelbackup.Visible = true;
                pbxbackup.Visible = true;
            }
            else
            {
                lblauthorize.Visible = true;
                timer2.Start();
            }
        }

        private void pbxbackup_Click(object sender, EventArgs e)
        {
            btnbackupdatabase.Enabled = true;
            panelbackup.Visible = false;
            pbxbackup.Visible = false;
        }

        private void bunifuMetroTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "Password")
            {
                bunifuMetroTextbox1.Text = "";
            }
            bunifuMetroTextbox1.ForeColor = Color.White;
        }

        private void bunifuMetroTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "")
            {
                bunifuMetroTextbox1.Text = "Password";
                bunifuMetroTextbox1.ForeColor = Color.DarkGray;
            }
        }

        private void txtpassword1_Enter(object sender, EventArgs e)
        {
            if (txtpassword1.Text == "New Password")
            {
                txtpassword1.Text = "";
            }
            txtpassword1.ForeColor = Color.White;
        }

        private void txtpassword1_Leave(object sender, EventArgs e)
        {
            if (txtpassword1.Text == "")
            {
                txtpassword1.Text = "New Password";
                txtpassword1.ForeColor = Color.DarkGray;
            }
        }

        private void txtpassword2_Enter(object sender, EventArgs e)
        {
            if (txtpassword2.Text == "Re-Enter New Password")
            {
                txtpassword2.Text = "";
            }
            txtpassword2.ForeColor = Color.White;
        }

        private void txtpassword2_Leave(object sender, EventArgs e)
        {
            if (txtpassword2.Text == "")
            {
                txtpassword2.Text = "Re-Enter New Password";
                txtpassword2.ForeColor = Color.DarkGray;
            }
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            if(bunifuMetroTextbox1.Text==lblpassword.Text && txtpassword1.Text==txtpassword2.Text && txtpassword1.Text!="" && txtpassword2.Text != "")
            {
                SqlCommand komut = new SqlCommand("update TBLKISILER set SIFRE='" + txtpassword1.Text + "' where ID='" + lblkisiid.Text + "'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                lblcheck.Visible = false;
                lblsuccessfully.Visible = true;
                timer2.Start();
                txtpassword2.Text = "Re-Enter New Password";
                txtpassword2.ForeColor = Color.DarkGray;
                txtpassword1.Text = "New Password";
                txtpassword1.ForeColor = Color.DarkGray;
                bunifuMetroTextbox1.Text = "Password";
                bunifuMetroTextbox1.ForeColor = Color.DarkGray;
            }
            else
            {
                lblcheck.Visible = true;
            }
        }
        int sayac = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 4)
            {
                timer2.Stop();
                sayac = 0;
                lblsuccessfully.Visible = false;
                lblprocess.Visible = false;
                lblauthorize.Visible = false;
            }
        }

        private void btnbackup_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbldate.Text = DateTime.Now.ToShortDateString();
                lbltime.Text = DateTime.Now.ToShortTimeString();
                txtaddress.Text = txtaddress.Text.Replace("'\'","'\\'");
                SqlCommand komut = new SqlCommand("BACKUP DATABASE[" + txtdataname.Text + "] TO DISK = '" + txtaddress.Text + "\\" + txtdataname.Text + ".bak'", bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Settings1.Default.Backupdate = lbldate.Text;
                Settings1.Default.Backuptime = lbltime.Text;
                Settings1.Default.Save();
                lbldatacheck.Visible = false;
                lblprocess.Visible = true;
                timer2.Start();
            }
            catch (Exception)
            {
                lbldatacheck.Visible = true;
            }            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            txtaddress.Text = folderBrowserDialog1.SelectedPath;           
        }
    }
}
