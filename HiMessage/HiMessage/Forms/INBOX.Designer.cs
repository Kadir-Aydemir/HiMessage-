
namespace HiMessage.Forms
{
    partial class INBOX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INBOX));
            this.lblnumberinbox = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datagrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnview = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbldelete = new System.Windows.Forms.Label();
            this.btnreply = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelview = new System.Windows.Forms.Panel();
            this.btnback = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltitlee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblmesajid = new System.Windows.Forms.Label();
            this.lblgönderen = new System.Windows.Forms.Label();
            this.lbltarih = new System.Windows.Forms.Label();
            this.lblsaat = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblselect = new System.Windows.Forms.Label();
            this.panelcreate = new System.Windows.Forms.Panel();
            this.txtmessage = new System.Windows.Forms.RichTextBox();
            this.pbiletildi = new System.Windows.Forms.PictureBox();
            this.lblused = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btncreatepanelclose = new System.Windows.Forms.Button();
            this.txttitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pbtik = new System.Windows.Forms.PictureBox();
            this.txtreceiver = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnnew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsend = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblblank = new System.Windows.Forms.Label();
            this.lbliletildi = new System.Windows.Forms.Label();
            this.lblexport = new System.Windows.Forms.Label();
            this.btnexport = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblcountshow = new System.Windows.Forms.Label();
            this.lblcount = new System.Windows.Forms.Label();
            this.lblcountsetting = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panelview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).BeginInit();
            this.panelcreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbiletildi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnumberinbox
            // 
            this.lblnumberinbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnumberinbox.AutoSize = true;
            this.lblnumberinbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnumberinbox.ForeColor = System.Drawing.Color.White;
            this.lblnumberinbox.Location = new System.Drawing.Point(110, 482);
            this.lblnumberinbox.Name = "lblnumberinbox";
            this.lblnumberinbox.Size = new System.Drawing.Size(30, 24);
            this.lblnumberinbox.TabIndex = 38;
            this.lblnumberinbox.Text = "....";
            this.lblnumberinbox.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.label4.Location = new System.Drawing.Point(50, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Inbox";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // datagrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.datagrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid1.DoubleBuffered = true;
            this.datagrid1.EnableHeadersVisualStyles = false;
            this.datagrid1.GridColor = System.Drawing.Color.Black;
            this.datagrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.datagrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.datagrid1.Location = new System.Drawing.Point(12, 47);
            this.datagrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.datagrid1.Name = "datagrid1";
            this.datagrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagrid1.RowHeadersVisible = false;
            this.datagrid1.RowTemplate.ReadOnly = true;
            this.datagrid1.Size = new System.Drawing.Size(894, 275);
            this.datagrid1.TabIndex = 42;
            this.datagrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // btnview
            // 
            this.btnview.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnview.BackColor = System.Drawing.Color.Gainsboro;
            this.btnview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnview.BorderRadius = 7;
            this.btnview.ButtonText = "    View";
            this.btnview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnview.DisabledColor = System.Drawing.Color.Gray;
            this.btnview.Iconcolor = System.Drawing.Color.Transparent;
            this.btnview.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnview.Iconimage")));
            this.btnview.Iconimage_right = null;
            this.btnview.Iconimage_right_Selected = null;
            this.btnview.Iconimage_Selected = null;
            this.btnview.IconMarginLeft = 0;
            this.btnview.IconMarginRight = 0;
            this.btnview.IconRightVisible = true;
            this.btnview.IconRightZoom = 0D;
            this.btnview.IconVisible = true;
            this.btnview.IconZoom = 30D;
            this.btnview.IsTab = false;
            this.btnview.Location = new System.Drawing.Point(752, 10);
            this.btnview.Margin = new System.Windows.Forms.Padding(4);
            this.btnview.Name = "btnview";
            this.btnview.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnview.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnview.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnview.selected = false;
            this.btnview.Size = new System.Drawing.Size(149, 29);
            this.btnview.TabIndex = 44;
            this.btnview.Text = "    View";
            this.btnview.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnview.Textcolor = System.Drawing.Color.Black;
            this.btnview.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(543, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 45;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            this.bunifuImageButton1.MouseLeave += new System.EventHandler(this.bunifuImageButton1_MouseLeave);
            this.bunifuImageButton1.MouseHover += new System.EventHandler(this.bunifuImageButton1_MouseHover);
            // 
            // lbldelete
            // 
            this.lbldelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldelete.AutoSize = true;
            this.lbldelete.BackColor = System.Drawing.Color.Transparent;
            this.lbldelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbldelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldelete.ForeColor = System.Drawing.Color.Gray;
            this.lbldelete.Location = new System.Drawing.Point(487, 15);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(50, 17);
            this.lbldelete.TabIndex = 46;
            this.lbldelete.Text = "Delete";
            this.lbldelete.Visible = false;
            // 
            // btnreply
            // 
            this.btnreply.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnreply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnreply.BackColor = System.Drawing.Color.Gainsboro;
            this.btnreply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnreply.BorderRadius = 7;
            this.btnreply.ButtonText = "    Reply";
            this.btnreply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreply.DisabledColor = System.Drawing.Color.Gray;
            this.btnreply.Iconcolor = System.Drawing.Color.Transparent;
            this.btnreply.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnreply.Iconimage")));
            this.btnreply.Iconimage_right = null;
            this.btnreply.Iconimage_right_Selected = null;
            this.btnreply.Iconimage_Selected = null;
            this.btnreply.IconMarginLeft = 0;
            this.btnreply.IconMarginRight = 0;
            this.btnreply.IconRightVisible = true;
            this.btnreply.IconRightZoom = 0D;
            this.btnreply.IconVisible = true;
            this.btnreply.IconZoom = 30D;
            this.btnreply.IsTab = false;
            this.btnreply.Location = new System.Drawing.Point(594, 10);
            this.btnreply.Margin = new System.Windows.Forms.Padding(5);
            this.btnreply.Name = "btnreply";
            this.btnreply.Normalcolor = System.Drawing.Color.Gainsboro;
            this.btnreply.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnreply.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnreply.selected = false;
            this.btnreply.Size = new System.Drawing.Size(149, 29);
            this.btnreply.TabIndex = 47;
            this.btnreply.Text = "    Reply";
            this.btnreply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreply.Textcolor = System.Drawing.Color.Black;
            this.btnreply.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnreply.Visible = false;
            this.btnreply.Click += new System.EventHandler(this.btnreply_Click);
            // 
            // panelview
            // 
            this.panelview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelview.Controls.Add(this.btnback);
            this.panelview.Controls.Add(this.lbltitlee);
            this.panelview.Controls.Add(this.label6);
            this.panelview.Controls.Add(this.lbltime);
            this.panelview.Controls.Add(this.lbldate);
            this.panelview.Controls.Add(this.label5);
            this.panelview.Controls.Add(this.label3);
            this.panelview.Controls.Add(this.lblsender);
            this.panelview.Controls.Add(this.label1);
            this.panelview.Controls.Add(this.richTextBox1);
            this.panelview.Location = new System.Drawing.Point(12, 48);
            this.panelview.Name = "panelview";
            this.panelview.Size = new System.Drawing.Size(894, 275);
            this.panelview.TabIndex = 48;
            this.panelview.Visible = false;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.Image = ((System.Drawing.Image)(resources.GetObject("btnback.Image")));
            this.btnback.ImageActive = null;
            this.btnback.Location = new System.Drawing.Point(4, 7);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(35, 30);
            this.btnback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnback.TabIndex = 54;
            this.btnback.TabStop = false;
            this.btnback.Zoom = 10;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // lbltitlee
            // 
            this.lbltitlee.AutoSize = true;
            this.lbltitlee.BackColor = System.Drawing.Color.Transparent;
            this.lbltitlee.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltitlee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltitlee.ForeColor = System.Drawing.Color.Gray;
            this.lbltitlee.Location = new System.Drawing.Point(98, 51);
            this.lbltitlee.Name = "lbltitlee";
            this.lbltitlee.Size = new System.Drawing.Size(34, 21);
            this.lbltitlee.TabIndex = 56;
            this.lbltitlee.Text = "......";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(47, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 55;
            this.label6.Text = "Title:";
            // 
            // lbltime
            // 
            this.lbltime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltime.ForeColor = System.Drawing.Color.Gray;
            this.lbltime.Location = new System.Drawing.Point(825, 14);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(34, 21);
            this.lbltime.TabIndex = 54;
            this.lbltime.Text = "......";
            // 
            // lbldate
            // 
            this.lbldate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbldate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldate.ForeColor = System.Drawing.Color.Gray;
            this.lbldate.Location = new System.Drawing.Point(679, 14);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(34, 21);
            this.lbldate.TabIndex = 53;
            this.lbldate.Text = "......";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(769, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Time:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(619, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date:";
            // 
            // lblsender
            // 
            this.lblsender.AutoSize = true;
            this.lblsender.BackColor = System.Drawing.Color.Transparent;
            this.lblsender.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblsender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsender.ForeColor = System.Drawing.Color.Gray;
            this.lblsender.Location = new System.Drawing.Point(116, 14);
            this.lblsender.Name = "lblsender";
            this.lblsender.Size = new System.Drawing.Size(34, 21);
            this.lblsender.TabIndex = 50;
            this.lblsender.Text = "......";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(46, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sender:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.LightGray;
            this.richTextBox1.Location = new System.Drawing.Point(50, 98);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(803, 173);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lblmesajid
            // 
            this.lblmesajid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmesajid.AutoSize = true;
            this.lblmesajid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmesajid.ForeColor = System.Drawing.Color.White;
            this.lblmesajid.Location = new System.Drawing.Point(146, 482);
            this.lblmesajid.Name = "lblmesajid";
            this.lblmesajid.Size = new System.Drawing.Size(0, 24);
            this.lblmesajid.TabIndex = 49;
            this.lblmesajid.Visible = false;
            // 
            // lblgönderen
            // 
            this.lblgönderen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblgönderen.AutoSize = true;
            this.lblgönderen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgönderen.ForeColor = System.Drawing.Color.White;
            this.lblgönderen.Location = new System.Drawing.Point(74, 482);
            this.lblgönderen.Name = "lblgönderen";
            this.lblgönderen.Size = new System.Drawing.Size(30, 24);
            this.lblgönderen.TabIndex = 50;
            this.lblgönderen.Text = "....";
            this.lblgönderen.Visible = false;
            // 
            // lbltarih
            // 
            this.lbltarih.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltarih.AutoSize = true;
            this.lbltarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltarih.ForeColor = System.Drawing.Color.White;
            this.lbltarih.Location = new System.Drawing.Point(44, 482);
            this.lbltarih.Name = "lbltarih";
            this.lbltarih.Size = new System.Drawing.Size(30, 24);
            this.lbltarih.TabIndex = 51;
            this.lbltarih.Text = "....";
            this.lbltarih.Visible = false;
            // 
            // lblsaat
            // 
            this.lblsaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsaat.AutoSize = true;
            this.lblsaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsaat.ForeColor = System.Drawing.Color.White;
            this.lblsaat.Location = new System.Drawing.Point(8, 482);
            this.lblsaat.Name = "lblsaat";
            this.lblsaat.Size = new System.Drawing.Size(30, 24);
            this.lblsaat.TabIndex = 52;
            this.lblsaat.Text = "....";
            this.lblsaat.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.BackColor = System.Drawing.Color.Transparent;
            this.lblselect.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblselect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblselect.ForeColor = System.Drawing.Color.Firebrick;
            this.lblselect.Location = new System.Drawing.Point(283, 12);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(131, 21);
            this.lblselect.TabIndex = 53;
            this.lblselect.Text = "Select message";
            this.lblselect.Visible = false;
            // 
            // panelcreate
            // 
            this.panelcreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelcreate.BackgroundImage")));
            this.panelcreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcreate.Controls.Add(this.txtmessage);
            this.panelcreate.Controls.Add(this.pbiletildi);
            this.panelcreate.Controls.Add(this.lblused);
            this.panelcreate.Controls.Add(this.label2);
            this.panelcreate.Controls.Add(this.label7);
            this.panelcreate.Controls.Add(this.label8);
            this.panelcreate.Controls.Add(this.btncreatepanelclose);
            this.panelcreate.Controls.Add(this.txttitle);
            this.panelcreate.Controls.Add(this.pbtik);
            this.panelcreate.Controls.Add(this.txtreceiver);
            this.panelcreate.Controls.Add(this.btnnew);
            this.panelcreate.Controls.Add(this.btnsend);
            this.panelcreate.Controls.Add(this.lblblank);
            this.panelcreate.Controls.Add(this.lbliletildi);
            this.panelcreate.Location = new System.Drawing.Point(409, 29);
            this.panelcreate.Name = "panelcreate";
            this.panelcreate.Size = new System.Drawing.Size(491, 489);
            this.panelcreate.TabIndex = 54;
            this.panelcreate.Visible = false;
            // 
            // txtmessage
            // 
            this.txtmessage.BackColor = System.Drawing.Color.Black;
            this.txtmessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmessage.BulletIndent = 10;
            this.txtmessage.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmessage.ForeColor = System.Drawing.Color.DarkGray;
            this.txtmessage.Location = new System.Drawing.Point(30, 158);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(439, 214);
            this.txtmessage.TabIndex = 5;
            this.txtmessage.Text = "Your message";
            this.txtmessage.TextChanged += new System.EventHandler(this.txtmessage_TextChanged);
            this.txtmessage.Enter += new System.EventHandler(this.txtmessage_Enter);
            this.txtmessage.Leave += new System.EventHandler(this.txtmessage_Leave);
            // 
            // pbiletildi
            // 
            this.pbiletildi.Image = ((System.Drawing.Image)(resources.GetObject("pbiletildi.Image")));
            this.pbiletildi.Location = new System.Drawing.Point(117, 391);
            this.pbiletildi.Name = "pbiletildi";
            this.pbiletildi.Size = new System.Drawing.Size(33, 30);
            this.pbiletildi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbiletildi.TabIndex = 23;
            this.pbiletildi.TabStop = false;
            this.pbiletildi.Visible = false;
            // 
            // lblused
            // 
            this.lblused.AutoSize = true;
            this.lblused.BackColor = System.Drawing.Color.Transparent;
            this.lblused.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblused.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblused.ForeColor = System.Drawing.Color.Gray;
            this.lblused.Location = new System.Drawing.Point(413, 453);
            this.lblused.Name = "lblused";
            this.lblused.Size = new System.Drawing.Size(31, 21);
            this.lblused.TabIndex = 19;
            this.lblused.Text = "(0)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(364, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Used:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(176, 453);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Up to 500 characters";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(195, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "New Message";
            // 
            // btncreatepanelclose
            // 
            this.btncreatepanelclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncreatepanelclose.BackColor = System.Drawing.Color.Transparent;
            this.btncreatepanelclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncreatepanelclose.BackgroundImage")));
            this.btncreatepanelclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncreatepanelclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncreatepanelclose.FlatAppearance.BorderSize = 0;
            this.btncreatepanelclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btncreatepanelclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreatepanelclose.Location = new System.Drawing.Point(453, 8);
            this.btncreatepanelclose.Name = "btncreatepanelclose";
            this.btncreatepanelclose.Size = new System.Drawing.Size(28, 24);
            this.btncreatepanelclose.TabIndex = 7;
            this.btncreatepanelclose.UseVisualStyleBackColor = false;
            this.btncreatepanelclose.Click += new System.EventHandler(this.btncreatepanelclose_Click);
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.Black;
            this.txttitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttitle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle.ForeColor = System.Drawing.Color.DarkGray;
            this.txttitle.HintForeColor = System.Drawing.Color.Gainsboro;
            this.txttitle.HintText = "User Number";
            this.txttitle.isPassword = false;
            this.txttitle.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttitle.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txttitle.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txttitle.LineThickness = 1;
            this.txttitle.Location = new System.Drawing.Point(30, 97);
            this.txttitle.Margin = new System.Windows.Forms.Padding(4);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(426, 35);
            this.txttitle.TabIndex = 8;
            this.txttitle.Text = "Title";
            this.txttitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttitle.Enter += new System.EventHandler(this.txttitle_Enter);
            this.txttitle.Leave += new System.EventHandler(this.txttitle_Leave);
            // 
            // pbtik
            // 
            this.pbtik.Image = ((System.Drawing.Image)(resources.GetObject("pbtik.Image")));
            this.pbtik.Location = new System.Drawing.Point(421, 58);
            this.pbtik.Name = "pbtik";
            this.pbtik.Size = new System.Drawing.Size(33, 30);
            this.pbtik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbtik.TabIndex = 21;
            this.pbtik.TabStop = false;
            this.pbtik.Visible = false;
            // 
            // txtreceiver
            // 
            this.txtreceiver.BackColor = System.Drawing.Color.Black;
            this.txtreceiver.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtreceiver.Enabled = false;
            this.txtreceiver.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtreceiver.ForeColor = System.Drawing.Color.White;
            this.txtreceiver.HintForeColor = System.Drawing.Color.White;
            this.txtreceiver.HintText = "User Number";
            this.txtreceiver.isPassword = false;
            this.txtreceiver.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtreceiver.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtreceiver.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtreceiver.LineThickness = 1;
            this.txtreceiver.Location = new System.Drawing.Point(30, 54);
            this.txtreceiver.Margin = new System.Windows.Forms.Padding(4);
            this.txtreceiver.Name = "txtreceiver";
            this.txtreceiver.Size = new System.Drawing.Size(426, 35);
            this.txtreceiver.TabIndex = 9;
            this.txtreceiver.Text = "Receiver";
            this.txtreceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnnew
            // 
            this.btnnew.Activecolor = System.Drawing.Color.Black;
            this.btnnew.BackColor = System.Drawing.Color.Black;
            this.btnnew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnew.BackgroundImage")));
            this.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnew.BorderRadius = 7;
            this.btnnew.ButtonText = "            New";
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.DisabledColor = System.Drawing.Color.Gray;
            this.btnnew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnew.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnnew.Iconimage")));
            this.btnnew.Iconimage_right = null;
            this.btnnew.Iconimage_right_Selected = null;
            this.btnnew.Iconimage_Selected = null;
            this.btnnew.IconMarginLeft = 0;
            this.btnnew.IconMarginRight = 0;
            this.btnnew.IconRightVisible = true;
            this.btnnew.IconRightZoom = 0D;
            this.btnnew.IconVisible = true;
            this.btnnew.IconZoom = 45D;
            this.btnnew.IsTab = false;
            this.btnnew.Location = new System.Drawing.Point(25, 439);
            this.btnnew.Name = "btnnew";
            this.btnnew.Normalcolor = System.Drawing.Color.Black;
            this.btnnew.OnHovercolor = System.Drawing.Color.Black;
            this.btnnew.OnHoverTextColor = System.Drawing.Color.White;
            this.btnnew.selected = false;
            this.btnnew.Size = new System.Drawing.Size(143, 35);
            this.btnnew.TabIndex = 21;
            this.btnnew.Text = "            New";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Textcolor = System.Drawing.Color.White;
            this.btnnew.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnnew.Visible = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsend
            // 
            this.btnsend.Activecolor = System.Drawing.Color.Black;
            this.btnsend.BackColor = System.Drawing.Color.Black;
            this.btnsend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend.BackgroundImage")));
            this.btnsend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsend.BorderRadius = 7;
            this.btnsend.ButtonText = "            Send";
            this.btnsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsend.DisabledColor = System.Drawing.Color.Gray;
            this.btnsend.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsend.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnsend.Iconimage")));
            this.btnsend.Iconimage_right = null;
            this.btnsend.Iconimage_right_Selected = null;
            this.btnsend.Iconimage_Selected = null;
            this.btnsend.IconMarginLeft = 0;
            this.btnsend.IconMarginRight = 0;
            this.btnsend.IconRightVisible = true;
            this.btnsend.IconRightZoom = 0D;
            this.btnsend.IconVisible = true;
            this.btnsend.IconZoom = 45D;
            this.btnsend.IsTab = false;
            this.btnsend.Location = new System.Drawing.Point(25, 439);
            this.btnsend.Name = "btnsend";
            this.btnsend.Normalcolor = System.Drawing.Color.Black;
            this.btnsend.OnHovercolor = System.Drawing.Color.Black;
            this.btnsend.OnHoverTextColor = System.Drawing.Color.White;
            this.btnsend.selected = false;
            this.btnsend.Size = new System.Drawing.Size(143, 35);
            this.btnsend.TabIndex = 7;
            this.btnsend.Text = "            Send";
            this.btnsend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsend.Textcolor = System.Drawing.Color.White;
            this.btnsend.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // lblblank
            // 
            this.lblblank.AutoSize = true;
            this.lblblank.BackColor = System.Drawing.Color.Transparent;
            this.lblblank.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblblank.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblblank.ForeColor = System.Drawing.Color.Firebrick;
            this.lblblank.Location = new System.Drawing.Point(156, 396);
            this.lblblank.Name = "lblblank";
            this.lblblank.Size = new System.Drawing.Size(214, 21);
            this.lblblank.TabIndex = 21;
            this.lblblank.Text = "Please fill in the blank fields";
            this.lblblank.Visible = false;
            // 
            // lbliletildi
            // 
            this.lbliletildi.AutoSize = true;
            this.lbliletildi.BackColor = System.Drawing.Color.Transparent;
            this.lbliletildi.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbliletildi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbliletildi.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbliletildi.Location = new System.Drawing.Point(156, 396);
            this.lbliletildi.Name = "lbliletildi";
            this.lbliletildi.Size = new System.Drawing.Size(232, 21);
            this.lbliletildi.TabIndex = 22;
            this.lbliletildi.Text = "Your message has been sent";
            this.lbliletildi.Visible = false;
            // 
            // lblexport
            // 
            this.lblexport.AutoSize = true;
            this.lblexport.BackColor = System.Drawing.Color.Transparent;
            this.lblexport.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblexport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblexport.ForeColor = System.Drawing.Color.Gray;
            this.lblexport.Location = new System.Drawing.Point(65, 345);
            this.lblexport.Name = "lblexport";
            this.lblexport.Size = new System.Drawing.Size(102, 17);
            this.lblexport.TabIndex = 56;
            this.lblexport.Text = "Export to Excel";
            this.lblexport.Visible = false;
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.Transparent;
            this.btnexport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexport.Image = ((System.Drawing.Image)(resources.GetObject("btnexport.Image")));
            this.btnexport.ImageActive = null;
            this.btnexport.Location = new System.Drawing.Point(12, 332);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(47, 39);
            this.btnexport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexport.TabIndex = 55;
            this.btnexport.TabStop = false;
            this.btnexport.Zoom = 10;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            this.btnexport.MouseLeave += new System.EventHandler(this.btnexport_MouseLeave);
            this.btnexport.MouseHover += new System.EventHandler(this.btnexport_MouseHover);
            // 
            // lblcountshow
            // 
            this.lblcountshow.AutoSize = true;
            this.lblcountshow.BackColor = System.Drawing.Color.Transparent;
            this.lblcountshow.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblcountshow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcountshow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.lblcountshow.Location = new System.Drawing.Point(105, 19);
            this.lblcountshow.Name = "lblcountshow";
            this.lblcountshow.Size = new System.Drawing.Size(0, 19);
            this.lblcountshow.TabIndex = 57;
            // 
            // lblcount
            // 
            this.lblcount.AutoSize = true;
            this.lblcount.BackColor = System.Drawing.Color.Transparent;
            this.lblcount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblcount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.lblcount.Location = new System.Drawing.Point(149, 19);
            this.lblcount.Name = "lblcount";
            this.lblcount.Size = new System.Drawing.Size(18, 21);
            this.lblcount.TabIndex = 58;
            this.lblcount.Text = "..";
            this.lblcount.Visible = false;
            // 
            // lblcountsetting
            // 
            this.lblcountsetting.AutoSize = true;
            this.lblcountsetting.BackColor = System.Drawing.Color.Transparent;
            this.lblcountsetting.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblcountsetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcountsetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.lblcountsetting.Location = new System.Drawing.Point(186, 21);
            this.lblcountsetting.Name = "lblcountsetting";
            this.lblcountsetting.Size = new System.Drawing.Size(18, 21);
            this.lblcountsetting.TabIndex = 59;
            this.lblcountsetting.Text = "..";
            this.lblcountsetting.Visible = false;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // INBOX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(20)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(918, 512);
            this.Controls.Add(this.panelcreate);
            this.Controls.Add(this.lblcountsetting);
            this.Controls.Add(this.lblcount);
            this.Controls.Add(this.lblcountshow);
            this.Controls.Add(this.lblexport);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.lblsaat);
            this.Controls.Add(this.lbltarih);
            this.Controls.Add(this.lblgönderen);
            this.Controls.Add(this.lblmesajid);
            this.Controls.Add(this.btnreply);
            this.Controls.Add(this.lbldelete);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblnumberinbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelview);
            this.Controls.Add(this.datagrid1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "INBOX";
            this.Text = "INBOX";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panelview.ResumeLayout(false);
            this.panelview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnback)).EndInit();
            this.panelcreate.ResumeLayout(false);
            this.panelcreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbiletildi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label lblnumberinbox;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid datagrid1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnview;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label lbldelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnreply;
        private System.Windows.Forms.Panel panelview;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        internal System.Windows.Forms.Label lblmesajid;
        internal System.Windows.Forms.Label lblgönderen;
        internal System.Windows.Forms.Label lbltarih;
        internal System.Windows.Forms.Label lblsaat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbltitlee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblselect;
        private Bunifu.Framework.UI.BunifuImageButton btnback;
        private System.Windows.Forms.Panel panelcreate;
        private Bunifu.Framework.UI.BunifuFlatButton btnnew;
        private System.Windows.Forms.PictureBox pbiletildi;
        private System.Windows.Forms.Label lblused;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncreatepanelclose;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txttitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnsend;
        private System.Windows.Forms.RichTextBox txtmessage;
        private System.Windows.Forms.PictureBox pbtik;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtreceiver;
        private System.Windows.Forms.Label lbliletildi;
        private System.Windows.Forms.Label lblblank;
        private System.Windows.Forms.Label lblexport;
        private Bunifu.Framework.UI.BunifuImageButton btnexport;
        private System.Windows.Forms.Label lblcount;
        private System.Windows.Forms.Label lblcountsetting;
        private System.Windows.Forms.Timer timer3;
        internal System.Windows.Forms.Label lblcountshow;
    }
}