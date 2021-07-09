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


namespace HiMessage
{
    public partial class HiMessage : Form
    {
        Button currentbutton;
        Random random;
        int tempindex;
        Form activeForm;
        public HiMessage()
        {
            InitializeComponent();
            slidemenuwidth = panelmenu.Width;
            random = new Random();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        sqlbaglantisi bgl = new sqlbaglantisi();
        Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.Colorlist.Count);
            while (tempindex == index)
            {
                index = random.Next(ThemeColor.Colorlist.Count);
            }
            tempindex = index;
            string color = ThemeColor.Colorlist[index];
            return ColorTranslator.FromHtml(color);
        }
        void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentbutton != (Button)btnsender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentbutton = (Button)btnsender;
                    currentbutton.BackColor = color;
                    currentbutton.ForeColor = Color.Black;
                    currentbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    paneltitlebar.BackColor = color;                    
                    ThemeColor.PrimaryColor = color;                    
                }
            }
        }
        void DisableButton()
        {
            foreach (Control previousBtn in panelmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(23, 24, 33);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnsender)
        {
            string numara = lblnumara.Text ;
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnsender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDestkopPane.Controls.Add(childForm);
            this.panelDestkopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();            
            lbltitle.Text = childForm.Text;            
            lblhome.Visible = true;
            panelcreate.Visible = false;            
        }
            
        private void Reset()
        {
            DisableButton();
            lbltitle.Text = "HOME";
            lblhome.Visible = false;
            paneltitlebar.BackColor = Color.FromArgb(161, 20, 72);
            currentbutton = null;
        }

        int durum = 0;
        void offline()
        {
            SqlCommand komut = new SqlCommand("update TBLONLINE set DURUM='" + durum + "' where NUMARA='" + lblnumara.Text+"'", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
        private void btnclosee_Click(object sender, EventArgs e)
        {
            offline();
            timer6.Start();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MESSAGES_SENT(), sender);
            Forms.MESSAGES_SENT abc = (Forms.MESSAGES_SENT)Application.OpenForms["MESSAGES_SENT"];
            abc.lblnumbermessages.Text = number;
            if (lblshowoutgoing.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ONLINE_USERS(), sender);
            Forms.ONLINE_USERS abc = (Forms.ONLINE_USERS)Application.OpenForms["ONLINE_USERS"];
            abc.lblnumberonline.Text = number;
            abc.lblmanagernumber.Text = managernumber;
            if (lblshowonline.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }
     
        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ANNOUNCEMENT(), sender);
            Forms.ANNOUNCEMENT abc = (Forms.ANNOUNCEMENT)Application.OpenForms["ANNOUNCEMENT"];
            abc.lblnumberannouncement.Text = number;
            abc.lblmanagernumber.Text = managernumber;
            if (lblshowannouncement.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubmenu(panelsettingsubmenu);           
        }
      
        private void paneltitlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            btnnormal.Visible = true;
            btnmax.Visible = false;
            this.WindowState = FormWindowState.Maximized;           
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            btnnormal.Visible = false;
            btnmax.Visible = true;
            this.WindowState = FormWindowState.Normal;           
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btnhide_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }
        void hide()
        {
            panelDestkopPane.Location = new Point(52, 80);
            btnhide.Visible = false;
            btnshow.Visible = true;
            btninbox.Visible = true;
            btnannouncement.Visible = true;
            btnonline.Visible = true;
            btnmessages.Visible = true;
            btnsetting.Visible = true;
        }
        void show()
        {
            panelDestkopPane.Location = new Point(220, 80);
            btnhide.Visible = true;
            btnshow.Visible = false;
            btninbox.Visible = false;
            btnannouncement.Visible = false;
            btnonline.Visible = false;
            btnmessages.Visible = false;
            btnsetting.Visible = false;
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }
       
        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.INBOX(), sender);
            Forms.INBOX abc = (Forms.INBOX)Application.OpenForms["INBOX"];
            abc.lblnumberinbox.Text = number;
            if (lblshowincoming.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }

        private void btnmessages_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MESSAGES_SENT(), sender);
            Forms.MESSAGES_SENT abc = (Forms.MESSAGES_SENT)Application.OpenForms["MESSAGES_SENT"];
            abc.lblnumbermessages.Text = number;
            if (lblshowoutgoing.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }

        private void btnonline_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ONLINE_USERS(), sender);
            Forms.ONLINE_USERS abc = (Forms.ONLINE_USERS)Application.OpenForms["ONLINE_USERS"];
            abc.lblnumberonline.Text = number;
            abc.lblmanagernumber.Text = managernumber;
            if (lblshowonline.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }
      
        private void btnannouncement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ANNOUNCEMENT(), sender);
            Forms.ANNOUNCEMENT abc = (Forms.ANNOUNCEMENT)Application.OpenForms["ANNOUNCEMENT"];
            abc.lblnumberannouncement.Text = number;
            abc.lblmanagernumber.Text = managernumber;
            if (lblshowannouncement.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            showSubmenu(panelsettingsubmenu);           
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
            panelcreate.Visible = true;
            panelcreate.BringToFront();
        }

        private void btncreatepanelclose_Click(object sender, EventArgs e)
        {
            panelcreate.Visible = false;
            createclean();
        }

        private void txtreceiver_Enter(object sender, EventArgs e)
        {
            if (txtreceiver.Text == "Receiver")
            {
                txtreceiver.Text = "";
            }
            txtreceiver.ForeColor = Color.White;
        }

        private void txtreceiver_Leave(object sender, EventArgs e)
        {
            if (txtreceiver.Text == "")
            {
                txtreceiver.Text = "Receiver";
                txtreceiver.ForeColor = Color.DarkGray;
            }            
        }

        private void txttitle_Enter(object sender, EventArgs e)
        {
            if (txttitle.Text == "Title")
            {
                txttitle.Text = "";
            }
            txttitle.ForeColor = Color.White;
        }

        private void txttitle_Leave(object sender, EventArgs e)
        {
            if (txttitle.Text == "")
            {
                txttitle.Text = "Title";
                txttitle.ForeColor = Color.DarkGray;
            }             
        }
        public string number;                      
        string managernumber;
        private void HiMessage_Load(object sender, EventArgs e)
        {           
            lblnumara.Text = number;
            inbox();
            alimsayisi = (datagrid1.Rows.Count - 1);
            lblcountsetting.Text = alimsayisi.ToString();            
            announcement();
            alimsayisiann = (datagrid2.Rows.Count - 1);
            lblcountsettingann.Text = alimsayisiann.ToString();
            timer3.Start();
            SqlCommand komut1 = new SqlCommand("select * from TBLKISILER where ID='8'", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                managernumber = dr1[3].ToString();
                
            }
            bgl.baglanti().Close();
            if (lblnumara.Text == managernumber)
            {
                panelprofile.Visible = false;
            }
            SqlCommand komut = new SqlCommand("select * from TBLKISILER where NUMARA='" + lblnumara.Text+"'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblid.Text = dr[0].ToString();
                lbladsoyad.Text = dr[1] + " " + dr[2];
                txtmail.Text = dr[5].ToString();
                mskbirth.Text = dr[6].ToString();
                mskage.Text = dr[7].ToString();
                txtposition.Text = dr[8].ToString();
                lblmarried.Text = dr[9].ToString();
                mskchild.Text = dr[10].ToString();
                rchbio.Text = dr[11].ToString();
                fotoyolu= dr[12].ToString();
                pictureBox1.ImageLocation = fotoyolu;
            }
            bgl.baglanti().Close();
            if (lblmarried.Text == "True")
            {
                chbmarried.Checked = true;
            }
            if (lblmarried.Text == "False")
            {
                chbmarried.Checked = false;
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.INBOX(), sender);
            Forms.INBOX abc = (Forms.INBOX)Application.OpenForms["INBOX"];
            abc.lblnumberinbox.Text = number;
            if (lblshowincoming.Text == "False")
            {
                abc.lblcountshow.Visible = false;
            }
            else
            {
                abc.lblcountshow.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToShortTimeString();
            lblshowincoming.Text = Forms.Settings1.Default.showincoming.ToString();
            lblshowoutgoing.Text = Forms.Settings1.Default.showoutgoing.ToString();
            lblshowonline.Text = Forms.Settings1.Default.showonline.ToString();
            lblshowannouncement.Text = Forms.Settings1.Default.showannouncement.ToString();
            lblnotifyinbox.Text = Forms.Settings1.Default.inboxnotify.ToString();
            lblnotifyannouncement.Text = Forms.Settings1.Default.announcementnotify.ToString();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if(txttitle.Text!="" && txtmessage.Text != "" && txttitle.Text != "Title" && txtmessage.Text != "Your message")
            {
                SqlCommand komut1 = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK,TARIH,SAAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", lblnumara.Text.ToString());
                komut1.Parameters.AddWithValue("@p2", txtreceiver.Text.ToString());
                komut1.Parameters.AddWithValue("@p3", txttitle.Text.ToString());
                komut1.Parameters.AddWithValue("@p4", txtmessage.Text.ToString());
                komut1.Parameters.AddWithValue("@p5", lbltarih.Text.ToString());
                komut1.Parameters.AddWithValue("@p6", lblsaat.Text.ToString());
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                lbliletildi.Visible = true;
                pbiletildi.Visible = true;
                btnsend.Visible = false;
                btnnew.Visible = true;
                lblblank.Visible = false;
            }
            else
            {
                lblblank.Visible = true;
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("select * from TBLKISILER where NUMARA=" + txtreceiver.Text, bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            if (dr1.Read())
            {
                btnfind.Visible = false;
                pbtik.Visible = true;
                btnsend.Visible = true;
                txtreceiver.Enabled = false;
                pbcancel.Visible = false;
            }
            else
            {
                pbcancel.Visible = true;
            }
        }

        private void txtmessage_Enter(object sender, EventArgs e)
        {
            if (txtmessage.Text == "Your message")
            {
                txtmessage.Text = "";
            }
            txtmessage.ForeColor = Color.White;          
        }

        private void txtmessage_Leave(object sender, EventArgs e)
        {
            if (txtmessage.Text == "")
            {
                txtmessage.Text = "Your message";
                txtmessage.ForeColor = Color.DarkGray;
            }            
        }

        private void txtmessage_TextChanged(object sender, EventArgs e)
        {
            int use = txtmessage.Text.Length;
            lblused.Text = "("+use.ToString()+")";
            if (use >= 500)
            {
                lblused.ForeColor = Color.DarkRed;
                btnsend.Enabled = false;
            }
            else
            {
                lblused.ForeColor = Color.Gray;
                btnsend.Enabled = true;
            }
        }
        void createclean()
        {
            btnfind.Visible = true;
            pbtik.Visible = false;
            btnsend.Visible = false;
            pbcancel.Visible = false;
            txtmessage.Clear();
            lbliletildi.Visible = false;
            pbiletildi.Visible = false;
            lblblank.Visible = false;
            txttitle.Text = "Title";
            txtreceiver.Text = "Receiver";
            txtreceiver.Enabled = true;
            btnnew.Visible = false;
        }
        private void lblnew_Click(object sender, EventArgs e)
        {
            createclean();
        }

        private void chbmarried_OnChange(object sender, EventArgs e)
        {
            if (chbmarried.Checked == true)
            {
                lblmarried.Text = "True";
            }
            if (chbmarried.Checked == false)
            {
                lblmarried.Text = "False";
            }
        }

        private void rchbio_TextChanged(object sender, EventArgs e)
        {
            int use2 = rchbio.Text.Length;
            lbluse2.Text = "(" + use2.ToString() + ")";
            if (use2 >= 100)
            {
                lbluse2.ForeColor = Color.DarkRed;
                btnupdateinfo.Visible = false;
            }
            else
            {
                lbluse2.ForeColor = Color.Gray;
                btnupdateinfo.Visible = true;
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtmail.Enabled = true;
            txtposition.Enabled = true;
            mskage.Enabled = true;
            mskbirth.Enabled = true;
            mskchild.Enabled = true;
            chbmarried.Enabled = true;
            btnupdateinfo.Enabled = true;
            btnedit.Enabled = false;
            pbx.Visible = true;
            btnphoto.Enabled = true;
        }

        private void btnupdateinfo_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBLKISILER set MAIL=@P2,DOGUM_GUNU=@P3,YAS=@P4,MEVKI=@P5,EVLI=@P6,COCUK=@P7,BIO=@P8,FOTO=@P9 where ID=@P10", bgl.baglanti());
            komut.Parameters.AddWithValue("@P2", txtmail.Text.ToString());
            komut.Parameters.AddWithValue("@P3", mskbirth.Text.ToString());
            komut.Parameters.AddWithValue("@P4", mskage.Text.ToString());
            komut.Parameters.AddWithValue("@P5", txtposition.Text.ToString());
            komut.Parameters.AddWithValue("@P6", lblmarried.Text.ToString());
            komut.Parameters.AddWithValue("@P7", mskchild.Text.ToString());
            komut.Parameters.AddWithValue("@P8", rchbio.Text.ToString());
            komut.Parameters.AddWithValue("@P9", fotoyolu);
            komut.Parameters.AddWithValue("@P10", lblid.Text.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            btnupdateinfo.Enabled = false;
            btnphoto.Enabled = false;
            btnedit.Enabled = true;
            enabled();
            lblguncellendi.Visible = true;
            timer2.Start();
        }
        int say = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            say++;
            if (say == 5)
            {
                timer2.Stop();
                say = 0;
                lblguncellendi.Visible = false;
            }
        }
        void enabled()
        {
            txtmail.Enabled = false;
            txtposition.Enabled = false;
            mskage.Enabled = false;
            mskbirth.Enabled = false;
            mskchild.Enabled = false;
            chbmarried.Enabled = false;
            btnupdateinfo.Enabled = false;
            btnedit.Enabled = true;
            btnphoto.Enabled = false;
            pbx.Visible = false;
        }
        private void pbx_Click(object sender, EventArgs e)
        {
            enabled();
        }
        string fotoyolu;
        private void btnphoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            fotoyolu = openFileDialog1.FileName;
        }
        void customizeDesign()
        {
            panelsettingsubmenu.Visible = false;            
        }
        void hideSubmenu()
        {
            if (panelsettingsubmenu.Visible == true)
                panelsettingsubmenu.Visible = false;           
        }
        void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SETTING2(), sender);            
            hideSubmenu();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SETTING(), sender);
            Forms.SETTING abc = (Forms.SETTING)Application.OpenForms["SETTING"];
            abc.lblnumbersetting.Text = number;
            abc.lblmanagernumber.Text = managernumber;           
            hideSubmenu();
        }
        void inbox()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBLMESAJLAR where ALICI=" + lblnumara.Text, bgl.baglanti());
            System.Data.DataTable dt1 = new System.Data.DataTable();
            da1.Fill(dt1);
            datagrid1.DataSource = dt1;
            datagrid1.Columns["MESAJID"].Visible = false;
            datagrid1.Columns["ALICI"].Visible = false;
            datagrid1.Columns["TARIH"].Visible = false;
            datagrid1.Columns["SAAT"].Visible = false;
            mesajsayisi = datagrid1.Rows.Count - 1;
            lblcount.Text = mesajsayisi.ToString();

        }
        int mesajsayisi;
        int alimsayisi;
        int sayac2;
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert fr = new FormAlert();
            fr.showAlert(msg, type);
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            sayac2++;
            if (sayac2 == 100)
            {
                if (lblnotifyinbox.Text == "True")
                {
                    inbox();
                    if (alimsayisi < mesajsayisi)
                    {
                        this.Alert("You have a message", FormAlert.enmType.Message);
                        button1.BackColor = Color.Firebrick;
                        axWindowsMediaPlayer1.URL = Application.StartupPath + "\\message\\messagetone.wav";
                        alimsayisi = (datagrid1.Rows.Count - 1);
                        lblcountsetting.Text = alimsayisi.ToString();
                    }
                    if (alimsayisi > mesajsayisi)
                    {
                        alimsayisi = (datagrid1.Rows.Count - 1);
                        lblcountsetting.Text = alimsayisi.ToString();
                    }
                }
                if (lblnotifyannouncement.Text == "True")
                {
                    announcement();
                    if (alimsayisiann < duyurusayisi)
                    {
                        this.Alert("You have an Announcement", FormAlert.enmType.Announcement);
                        button5.BackColor = Color.Firebrick;
                        axWindowsMediaPlayer1.URL = Application.StartupPath + "\\message\\messagetone.wav";
                        alimsayisiann = (datagrid2.Rows.Count - 1);
                        lblcountsettingann.Text = alimsayisiann.ToString();
                    }
                    if (alimsayisiann > duyurusayisi)
                    {
                        alimsayisiann = (datagrid2.Rows.Count - 1);
                        lblcountsettingann.Text = alimsayisiann.ToString();
                    }
                }                  
                sayac2 = 0;
            }
        }
        void announcement()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TBLDUYURULAR ", bgl.baglanti());
            System.Data.DataTable dt2 = new System.Data.DataTable();
            da2.Fill(dt2);
            datagrid2.DataSource = dt2;
            datagrid2.Columns["ID"].Visible = false;
            datagrid2.Columns["TARIH"].Visible = false;
            datagrid2.Columns["SAAT"].Visible = false;
            duyurusayisi = (datagrid2.Rows.Count - 1);
            lblcountann.Text = duyurusayisi.ToString();
        }
        public int alimsayisiann;
        int duyurusayisi;

        private void btnlogout_Click(object sender, EventArgs e)
        {
            offline();
            timer7.Start();
           
        }
        int slidemenuwidth;
        private void timer4_Tick(object sender, EventArgs e)
        {
            panelmenu.Width = panelmenu.Width - 10;
            if (panelmenu.Width <= 50)
            {
                timer4.Stop();
                hide();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            panelmenu.Width = panelmenu.Width + 10;
            if (panelmenu.Width > slidemenuwidth)
            {
                timer5.Stop();
                show();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.095;
            }
            else
            {
                timer6.Stop();
                Application.Exit();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.095;
            }
            else
            {
                timer7.Stop();
                if (activeForm != null)
                    activeForm.Close();
                Reset();
                HiMessageLogin fr = new HiMessageLogin();
                fr.Show();
                this.Close();
            }           
        }
    }   
}
