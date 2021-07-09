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
    public partial class ANNOUNCEMENT : Form
    {
        public ANNOUNCEMENT()
        {
            InitializeComponent();
        }       
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Form5_Load(object sender, EventArgs e)
        {         
            timer1.Start();
            timer2.Start();
            timer4.Start();
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert fr = new FormAlert();
            fr.showAlert(msg, type);
        }
        void announcement()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBLDUYURULAR ", bgl.baglanti());
            System.Data.DataTable dt1 = new System.Data.DataTable();
            da1.Fill(dt1);
            datagrid1.DataSource = dt1;
            datagrid1.Columns["ID"].Visible = false;
            datagrid1.Columns["TARIH"].Visible = false;
            datagrid1.Columns["SAAT"].Visible = false;
            duyurusayisi = (datagrid1.Rows.Count - 1);
            lblcount.Text = duyurusayisi.ToString();
            lblcountshow.Text = "(" + lblcount.Text + ")";
        }
        int alimsayisi;
        int duyurusayisi;
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblnumberannouncement.Text == lblmanagernumber.Text)
            {
                btnedit.Visible = true;
                bunifuImageButton1.Visible = true;
                panelcreate.Visible = true;
            }
            sayac++;
            if (sayac == 1)
            {
                announcement();
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

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblselect.Visible = false;
                lblmesajid.Text = datagrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblyayınlayan.Text = datagrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lbldate.Text = datagrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
                lbltime.Text = datagrid1.Rows[e.RowIndex].Cells[4].Value.ToString();
                richTextBox1.Text = datagrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                lblselect.Visible = true;
            }
            
            SqlCommand komut = new SqlCommand("select AD,SOYAD from TBLKISILER where NUMARA='" + lblyayınlayan.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                lblpublisher.Text = dr[0] + " " + dr[1];
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
                SqlCommand komut = new SqlCommand("delete from TBLDUYURULAR where ID=" + lblmesajid.Text, bgl.baglanti());
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                panelview.Visible = false;
                lblmesajid.Text = "";
                announcement();
                alimsayisi = (datagrid1.Rows.Count - 1);
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
            btnview.Enabled = true;
            btnedit.Enabled = true;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (lblmesajid.Text != "")
            {
                btnupdate.Visible = true;
                pbx.Visible = true;
                panelview.Visible = true;
                panelview.BringToFront();
                btnview.Enabled = false;
                richTextBox1.Focus();
                btnedit.Enabled = false;
                btncreate.Enabled = false;
                btnback.Enabled = false;
            }
            else
            {
                lblselect.Visible = true;
            }
        }
        int sayac2=0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToShortTimeString();           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (lblmesajid.Text != "")
            {
                SqlCommand komut = new SqlCommand("update TBLDUYURULAR set DUYURU=@P1,TARIH=@P2,SAAT=@P3 where ID=" + lblmesajid.Text, bgl.baglanti());
                komut.Parameters.AddWithValue("@P1", richTextBox1.Text);
                komut.Parameters.AddWithValue("@P2", lbltarih.Text);
                komut.Parameters.AddWithValue("@P3", lblsaat.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                announcement();
                btnupdate.Visible = false;
                lblupdated.Visible = true;
                pbx.Visible = false;
                btnedit.Enabled = true;
                panelview.Visible = false;
                btnview.Enabled = true;
                timer3.Start();
            }
            else
            {
                lblselect.Visible = true;
            }
        }

        private void pbx_Click(object sender, EventArgs e)
        {
            btnupdate.Visible = false;
            pbx.Visible = false;
            btnedit.Enabled = true;
            btncreate.Enabled = true;
            btnback.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {            
            sayac2++;
            if (sayac2 == 4)
            {
                lblupdated.Visible = false;
                lbliletildi.Visible = false;
                sayac2 = 0;
            }
            
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
                pbx2.Visible = true;
                btnpublish.Visible = true;
                label2.Visible = true;
                label7.Visible = true;
                lblused.Visible = true;
                btnview.Enabled = false;
                btnedit.Enabled = false;
                btncreate.Enabled = false;
                rchcreate.Visible = true;
                rchcreate.Focus();           
        }
        void clean()
        {
            pbx2.Visible = false;
            btnpublish.Visible = false;
            label2.Visible = false;
            label7.Visible = false;
            lblused.Visible = false;
            btnview.Enabled = true;
            btnedit.Enabled = true;
            btncreate.Enabled = true;
            rchcreate.Visible = false;
            rchcreate.Clear();
            lblselect.Visible = false;
        }
        private void pbx2_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void rchcreate_TextChanged(object sender, EventArgs e)
        {
            int use = rchcreate.Text.Length;
            lblused.Text = "(" + use.ToString() + ")";
            if (use >= 500)
            {
                lblused.ForeColor = Color.DarkRed;
                btnpublish.Enabled = false;
            }
            else
            {
                lblused.ForeColor = Color.Gray;
                btnpublish.Enabled = true;
            }
        }

        private void btnpublish_Click(object sender, EventArgs e)
        {
            if (rchcreate.Text != "" && rchcreate.Text != "Your announcement")
            {
                SqlCommand komut1 = new SqlCommand("insert into TBLDUYURULAR (YAYINLAYAN,DUYURU,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", lblnumberannouncement.Text.ToString());
                komut1.Parameters.AddWithValue("@p2", rchcreate.Text.ToString());
                komut1.Parameters.AddWithValue("@p3", lbltarih.Text.ToString());
                komut1.Parameters.AddWithValue("@p4", lblsaat.Text.ToString());
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                lbliletildi.Visible = true;
                lblblank.Visible = false;
                timer3.Start();
                clean();
            }
            else
            {
                lblblank.Visible = true;
            }
        }

        private void rchcreate_Enter(object sender, EventArgs e)
        {
            if (rchcreate.Text == "Your announcement")
            {
                rchcreate.Text = "";
            }
            rchcreate.ForeColor = Color.Black;
        }

        private void rchcreate_Leave(object sender, EventArgs e)
        {
            if (rchcreate.Text == "")
            {
                rchcreate.Text = "Your announcement";
                rchcreate.ForeColor = Color.DimGray;
            }            
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
            for (int j = 0; j < datagrid1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = datagrid1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < datagrid1.Rows.Count; i++)
            {
                for (int j = 0; j < datagrid1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = datagrid1[j, i].Value == null ? "" : datagrid1[j, i].Value;
                    myRange.Select();
                }
            }
        }

        private void btnexport_MouseHover(object sender, EventArgs e)
        {
            lblexport.Visible = true;
        }

        private void btnexport_MouseLeave(object sender, EventArgs e)
        {
            lblexport.Visible = false;
        }
        int sayac3=0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            sayac3++;
            if (sayac3 == 100)
            {
                announcement();
                if (alimsayisi < duyurusayisi)
                {                   
                    alimsayisi = (datagrid1.Rows.Count - 1);
                    lblcountsetting.Text = alimsayisi.ToString();
                }
                sayac3 = 0;
            }
        }
    }
}
