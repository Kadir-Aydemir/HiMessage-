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

namespace HiMessage.Forms
{
    public partial class ONLINE_USERS : Form
    {
        public ONLINE_USERS()
        {
            InitializeComponent();
        }
      
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }
        void online()
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select * from TBLONLINE where NUMARA<>'"+lblnumberonline.Text+"'", bgl.baglanti());
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            datagrid1.DataSource = dt1;
            datagrid1.Columns["ID"].Visible = false;
            alimsayisi = datagrid1.Rows.Count - 1;
            lblcount.Text = alimsayisi.ToString();
            lblcountshow.Text = "(" + lblcount.Text + ")";
        }
        int alimsayisi;
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblnumberonline.Text == lblmanagernumber.Text)
            {
                bunifuImageButton1.Visible = true;
            }
            sayac++;           
            if (sayac == 1)
            {
                online();
            }
            if (sayac == 100)
            {
                online();
                sayac = 0;
            }    
        }

        private void btnphoto_Click(object sender, EventArgs e)
        {
            paneladdprofile.Visible = true;
            pbx.Visible = true;
            btnviewprofile.Enabled = false;
        }

        private void pbx_Click(object sender, EventArgs e)
        {
            paneladdprofile.Visible = false;
            pbx.Visible = false;
            btnviewprofile.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panelprofile.Visible = false;
            paneladdprofile.Visible = false;
            btnviewprofile.Enabled = true;
            pbx.Visible = false;
        }

        private void datagrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                panelprofile.Visible = false;
                panelcreate.Visible = false;
                paneladdprofile.Visible = false;
                pbx.Visible = false;
                createclean();
                lblonlineid.Text = datagrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                lblnumber.Text = datagrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtreceiver.Text = datagrid1.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblusername.Text = datagrid1.Rows[e.RowIndex].Cells[2].Value.ToString();
                lblonline.Text = datagrid1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception)
            {
                lblselect.Visible = false;
            }
           
            if (lblonline.Text == "True")
            {
                chbonline.Checked = true;
            }
            if (lblonline.Text == "False")
            {
                chbonline.Checked = false;
            }
            if (lblnumber.Text != "")
            {
                panelprofile.Visible = true;
                btnviewprofile.Enabled = true;

                lblselect.Visible = false;
            }

            SqlCommand komut = new SqlCommand("select * from TBLKISILER where NUMARA='" + lblnumber.Text + "'", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblkisiid.Text = dr[0].ToString();
                lblmail.Text = dr[5].ToString();
                lblbirthday.Text = dr[6].ToString();
                lblage.Text = dr[7].ToString();
                lblposition.Text = dr[8].ToString();
                lblmarried.Text = dr[9].ToString();
                lblchild.Text = dr[10].ToString();
                lblbio.Text = dr[11].ToString();
                pictureBox1.ImageLocation = dr[12].ToString();                
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
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();
            lblsaat.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnsendmessage_Click(object sender, EventArgs e)
        {
            panelcreate.Visible = true;
            panelcreate.BringToFront();
        }

        private void btncreatepanelclose_Click(object sender, EventArgs e)
        {
            panelcreate.Visible = false;
            createclean();
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

        private void btnsend_Click(object sender, EventArgs e)
        {
            if (txttitle.Text != "" && txtmessage.Text != "" && txttitle.Text != "Title" && txtmessage.Text != "Your message")
            {
                SqlCommand komut1 = new SqlCommand("insert into TBLMESAJLAR (GONDEREN,ALICI,BASLIK,ICERIK,TARIH,SAAT) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", lblnumberonline.Text.ToString());
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

        private void txtposition_OnValueChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from TBLONLINE where NUMARA like '" + txtsearch.Text + "%'", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            datagrid1.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void bunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
            lbldelete.Visible = true;
        }

        private void bunifuImageButton1_MouseLeave(object sender, EventArgs e)
        {
            lbldelete.Visible = false;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (lblonlineid.Text != "")
            {
                if (MessageBox.Show("ARE YOU SURE YOU WANT TO DELETE USER ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("delete from TBLKISILER where ID='" + lblkisiid.Text + "'", bgl.baglanti());
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    SqlCommand komut2 = new SqlCommand("delete from TBLONLINE where ID='" + lblonlineid.Text + "'", bgl.baglanti());
                    komut2.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    panelprofile.Visible = false;
                    paneladdprofile.Visible = false;
                    lblonlineid.Text = "";
                    lblkisiid.Text = "";
                    online();
                }
                else
                {
                    MessageBox.Show("USER DELETE CANCELED.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                lblselect.Visible = true;
            }    
                
        }
    }
}
