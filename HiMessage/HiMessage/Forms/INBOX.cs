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
using Application = System.Windows.Forms.Application;

namespace HiMessage.Forms
{
    public partial class INBOX : Form
    {
        public INBOX()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void inbox()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBLMESAJLAR where ALICI=" + lblnumberinbox.Text, bgl.baglanti());
            System.Data.DataTable dt1 = new System.Data.DataTable();
            da1.Fill(dt1);
            datagrid1.DataSource = dt1;
            datagrid1.Columns["MESAJID"].Visible = false;
            datagrid1.Columns["ALICI"].Visible = false;
            datagrid1.Columns["TARIH"].Visible = false;
            datagrid1.Columns["SAAT"].Visible = false;
            mesajsayisi = datagrid1.Rows.Count - 1;
            lblcount.Text = mesajsayisi.ToString();
            lblcountshow.Text="("+lblcount.Text+")";
            
        }
        int mesajsayisi;
        int alimsayisi;
        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start(); //başlangıç
            timer2.Start(); //zaman
            timer3.Start(); //yenileme
        }
        int sayac = 0;
        int sayac2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 1)
            {                             
                inbox();
                alimsayisi = (datagrid1.Rows.Count - 1);
                lblcountsetting.Text = alimsayisi.ToString();
                timer1.Stop();
            }          
        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            lbldelete.Visible = true;
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            lbldelete.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToShortTimeString();           
        }

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblselect.Visible = false;
                lblmesajid.Text = datagrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblgönderen.Text = datagrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtreceiver.Text = datagrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbldate.Text = datagrid1.Rows[e.RowIndex].Cells[5].Value.ToString();
                lbltime.Text = datagrid1.Rows[e.RowIndex].Cells[6].Value.ToString();
                richTextBox1.Text = datagrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                lbltitlee.Text = datagrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                lblselect.Visible = true;
            }

            SqlCommand komut = new SqlCommand("select AD,SOYAD from TBLKISILER where NUMARA='" + lblgönderen.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblsender.Text = dr[0] + " " + dr[1];
            }
            else
            {
                lblselect.Visible = true;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (lblmesajid.Text != "")
            {
                SqlCommand komut = new SqlCommand("delete from TBLMESAJLAR where MESAJID=" + lblmesajid.Text, bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                panelview.Visible = false;
                lblmesajid.Text = "";                               
                inbox();
                alimsayisi = datagrid1.Rows.Count - 1;
                lblcountsetting.Text = alimsayisi.ToString();
            }
            else
            {
                lblselect.Visible = true;
            }
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (lblmesajid.Text != "")
            {
                panelview.Visible = true;
                panelview.BringToFront();
                btnreply.Visible = true;
                btnview.Enabled = false;
            }
            else
            {
                lblselect.Visible = true;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            panelview.Visible = false;
            btnreply.Visible = false;
            btnview.Enabled = true;
        }

        private void btnreply_Click(object sender, EventArgs e)
        {
            panelcreate.Visible = true;
            panelcreate.BringToFront();
            btnreply.Enabled = false;
            btnback.Enabled = false;
        }

        private void txtmessage_TextChanged(object sender, EventArgs e)
        {
            int use = txtmessage.Text.Length;
            lblused.Text = "(" + use.ToString() + ")";
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
        void createclean()
        {
            txtmessage.Clear();
            lbliletildi.Visible = false;
            pbiletildi.Visible = false;
            lblblank.Visible = false;
            txttitle.Text = "Title";
            btnnew.Visible = false;
            btnsend.Visible = true;
        }
        private void btncreatepanelclose_Click(object sender, EventArgs e)
        {
            btnreply.Enabled = true;
            btnback.Enabled = true;
            panelcreate.Visible = false;
            createclean();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (txttitle.Text != "" && txtmessage.Text != "" && txttitle.Text != "Title" && txtmessage.Text != "Your message")
            {
                SqlCommand komut1 = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK,TARIH,SAAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", lblnumberinbox.Text.ToString());
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

        private void btnnew_Click(object sender, EventArgs e)
        {
            createclean();
        }

        private void btnexport_MouseHover(object sender, EventArgs e)
        {
            lblexport.Visible = true;
        }

        private void btnexport_MouseLeave(object sender, EventArgs e)
        {
            lblexport.Visible = false;
        }

        private void btnexport_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j <datagrid1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = datagrid1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i <datagrid1.Rows.Count; i++)
            {
                for (int j = 0; j < datagrid1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = datagrid1[j, i].Value == null ? "" : datagrid1[j, i].Value;
                    myRange.Select();
                }
            }
        }
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
                inbox();
                if (alimsayisi < mesajsayisi)
                {
                    alimsayisi = (datagrid1.Rows.Count - 1);
                    lblcountsetting.Text = alimsayisi.ToString();
                }
                sayac2 = 0;
            }
        }
    }
}
