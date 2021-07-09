
namespace HiMessage
{
    partial class HiMessageForget
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiMessageForget));
            this.panelcontrol = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.txtverify = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblforgetpassword = new System.Windows.Forms.Label();
            this.lblaccount = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.txtforgetmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtforgetnumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblbacktologin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.progressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.btncheckit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnverify = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnsendmail = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblempty = new System.Windows.Forms.Label();
            this.lbltimeup = new System.Windows.Forms.Label();
            this.lblmailsent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelcontrol
            // 
            this.panelcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcontrol.Controls.Add(this.button1);
            this.panelcontrol.Controls.Add(this.btnclose);
            this.panelcontrol.Location = new System.Drawing.Point(0, 2);
            this.panelcontrol.Name = "panelcontrol";
            this.panelcontrol.Size = new System.Drawing.Size(400, 38);
            this.panelcontrol.TabIndex = 20;
            this.panelcontrol.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelcontrol_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(324, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(361, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(37, 38);
            this.btnclose.TabIndex = 5;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtverify
            // 
            this.txtverify.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(11)))), ((int)(((byte)(81)))));
            this.txtverify.BorderColorIdle = System.Drawing.Color.Gainsboro;
            this.txtverify.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(11)))), ((int)(((byte)(81)))));
            this.txtverify.BorderThickness = 3;
            this.txtverify.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtverify.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtverify.ForeColor = System.Drawing.Color.White;
            this.txtverify.isPassword = false;
            this.txtverify.Location = new System.Drawing.Point(136, 367);
            this.txtverify.Margin = new System.Windows.Forms.Padding(4);
            this.txtverify.Name = "txtverify";
            this.txtverify.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.txtverify.Size = new System.Drawing.Size(155, 44);
            this.txtverify.TabIndex = 55;
            this.txtverify.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtverify.Visible = false;
            // 
            // lblforgetpassword
            // 
            this.lblforgetpassword.AutoSize = true;
            this.lblforgetpassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblforgetpassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblforgetpassword.ForeColor = System.Drawing.Color.White;
            this.lblforgetpassword.Location = new System.Drawing.Point(335, 538);
            this.lblforgetpassword.Name = "lblforgetpassword";
            this.lblforgetpassword.Size = new System.Drawing.Size(32, 16);
            this.lblforgetpassword.TabIndex = 50;
            this.lblforgetpassword.Text = "......";
            this.lblforgetpassword.Visible = false;
            // 
            // lblaccount
            // 
            this.lblaccount.AutoSize = true;
            this.lblaccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblaccount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblaccount.ForeColor = System.Drawing.Color.Red;
            this.lblaccount.Location = new System.Drawing.Point(126, 204);
            this.lblaccount.Name = "lblaccount";
            this.lblaccount.Size = new System.Drawing.Size(165, 17);
            this.lblaccount.TabIndex = 49;
            this.lblaccount.Text = "Account do not match !";
            this.lblaccount.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(32, 299);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 48;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // txtforgetmail
            // 
            this.txtforgetmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtforgetmail.Enabled = false;
            this.txtforgetmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtforgetmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtforgetmail.HintForeColor = System.Drawing.Color.Gainsboro;
            this.txtforgetmail.HintText = "";
            this.txtforgetmail.isPassword = false;
            this.txtforgetmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(11)))), ((int)(((byte)(81)))));
            this.txtforgetmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.txtforgetmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(11)))), ((int)(((byte)(81)))));
            this.txtforgetmail.LineThickness = 4;
            this.txtforgetmail.Location = new System.Drawing.Point(76, 299);
            this.txtforgetmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtforgetmail.Name = "txtforgetmail";
            this.txtforgetmail.Size = new System.Drawing.Size(268, 39);
            this.txtforgetmail.TabIndex = 47;
            this.txtforgetmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtforgetmail.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(32, 234);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            // 
            // txtforgetnumber
            // 
            this.txtforgetnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtforgetnumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtforgetnumber.ForeColor = System.Drawing.Color.DarkGray;
            this.txtforgetnumber.HintForeColor = System.Drawing.Color.DarkGray;
            this.txtforgetnumber.HintText = "User Number";
            this.txtforgetnumber.isPassword = false;
            this.txtforgetnumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(11)))), ((int)(((byte)(81)))));
            this.txtforgetnumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(20)))), ((int)(((byte)(72)))));
            this.txtforgetnumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(11)))), ((int)(((byte)(81)))));
            this.txtforgetnumber.LineThickness = 4;
            this.txtforgetnumber.Location = new System.Drawing.Point(76, 234);
            this.txtforgetnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtforgetnumber.Name = "txtforgetnumber";
            this.txtforgetnumber.Size = new System.Drawing.Size(268, 39);
            this.txtforgetnumber.TabIndex = 44;
            this.txtforgetnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtforgetnumber.Enter += new System.EventHandler(this.txtforgetnumber_Enter);
            this.txtforgetnumber.Leave += new System.EventHandler(this.txtforgetnumber_Leave);
            // 
            // lblbacktologin
            // 
            this.lblbacktologin.AutoSize = true;
            this.lblbacktologin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblbacktologin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbacktologin.ForeColor = System.Drawing.Color.White;
            this.lblbacktologin.Location = new System.Drawing.Point(138, 499);
            this.lblbacktologin.Name = "lblbacktologin";
            this.lblbacktologin.Size = new System.Drawing.Size(148, 25);
            this.lblbacktologin.TabIndex = 43;
            this.lblbacktologin.Text = "Back to Login";
            this.lblbacktologin.Click += new System.EventHandler(this.lblbacktologin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(136, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 28);
            this.label9.TabIndex = 41;
            this.label9.Text = "HiMessage";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(36, 51);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(54, 53);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // progressbar1
            // 
            this.progressbar1.animated = false;
            this.progressbar1.animationIterval = 95;
            this.progressbar1.animationSpeed = 300;
            this.progressbar1.BackColor = System.Drawing.Color.Transparent;
            this.progressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressbar1.BackgroundImage")));
            this.progressbar1.Font = new System.Drawing.Font("BankGothic Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressbar1.ForeColor = System.Drawing.Color.Lime;
            this.progressbar1.LabelVisible = true;
            this.progressbar1.LineProgressThickness = 7;
            this.progressbar1.LineThickness = 4;
            this.progressbar1.Location = new System.Drawing.Point(159, 99);
            this.progressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressbar1.MaxValue = 100;
            this.progressbar1.Name = "progressbar1";
            this.progressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.progressbar1.ProgressColor = System.Drawing.Color.Lime;
            this.progressbar1.Size = new System.Drawing.Size(89, 89);
            this.progressbar1.TabIndex = 51;
            this.progressbar1.Value = 0;
            this.progressbar1.Visible = false;
            // 
            // btncheckit
            // 
            this.btncheckit.ActiveBorderThickness = 1;
            this.btncheckit.ActiveCornerRadius = 20;
            this.btncheckit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btncheckit.ActiveForecolor = System.Drawing.Color.White;
            this.btncheckit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btncheckit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.btncheckit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncheckit.BackgroundImage")));
            this.btncheckit.ButtonText = "Check it";
            this.btncheckit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncheckit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncheckit.ForeColor = System.Drawing.Color.White;
            this.btncheckit.IdleBorderThickness = 1;
            this.btncheckit.IdleCornerRadius = 20;
            this.btncheckit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btncheckit.IdleForecolor = System.Drawing.Color.White;
            this.btncheckit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btncheckit.Location = new System.Drawing.Point(76, 374);
            this.btncheckit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btncheckit.Name = "btncheckit";
            this.btncheckit.Size = new System.Drawing.Size(268, 55);
            this.btncheckit.TabIndex = 42;
            this.btncheckit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncheckit.Click += new System.EventHandler(this.btncheckit_Click);
            // 
            // btnverify
            // 
            this.btnverify.ActiveBorderThickness = 1;
            this.btnverify.ActiveCornerRadius = 20;
            this.btnverify.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnverify.ActiveForecolor = System.Drawing.Color.White;
            this.btnverify.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnverify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.btnverify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnverify.BackgroundImage")));
            this.btnverify.ButtonText = "Verify";
            this.btnverify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverify.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnverify.ForeColor = System.Drawing.Color.White;
            this.btnverify.IdleBorderThickness = 1;
            this.btnverify.IdleCornerRadius = 20;
            this.btnverify.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnverify.IdleForecolor = System.Drawing.Color.White;
            this.btnverify.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnverify.Location = new System.Drawing.Point(76, 426);
            this.btnverify.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(268, 55);
            this.btnverify.TabIndex = 52;
            this.btnverify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnverify.Visible = false;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // btnsendmail
            // 
            this.btnsendmail.ActiveBorderThickness = 1;
            this.btnsendmail.ActiveCornerRadius = 20;
            this.btnsendmail.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnsendmail.ActiveForecolor = System.Drawing.Color.White;
            this.btnsendmail.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnsendmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.btnsendmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsendmail.BackgroundImage")));
            this.btnsendmail.ButtonText = "Send mail";
            this.btnsendmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsendmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsendmail.ForeColor = System.Drawing.Color.White;
            this.btnsendmail.IdleBorderThickness = 1;
            this.btnsendmail.IdleCornerRadius = 20;
            this.btnsendmail.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnsendmail.IdleForecolor = System.Drawing.Color.White;
            this.btnsendmail.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(43)))), ((int)(((byte)(64)))));
            this.btnsendmail.Location = new System.Drawing.Point(76, 426);
            this.btnsendmail.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnsendmail.Name = "btnsendmail";
            this.btnsendmail.Size = new System.Drawing.Size(268, 55);
            this.btnsendmail.TabIndex = 46;
            this.btnsendmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsendmail.Visible = false;
            this.btnsendmail.Click += new System.EventHandler(this.btnsendmail_Click);
            // 
            // lblempty
            // 
            this.lblempty.AutoSize = true;
            this.lblempty.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblempty.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblempty.ForeColor = System.Drawing.Color.Red;
            this.lblempty.Location = new System.Drawing.Point(127, 205);
            this.lblempty.Name = "lblempty";
            this.lblempty.Size = new System.Drawing.Size(151, 17);
            this.lblempty.TabIndex = 56;
            this.lblempty.Text = "User number is empty !";
            this.lblempty.Visible = false;
            // 
            // lbltimeup
            // 
            this.lbltimeup.AutoSize = true;
            this.lbltimeup.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbltimeup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltimeup.ForeColor = System.Drawing.Color.Red;
            this.lbltimeup.Location = new System.Drawing.Point(174, 205);
            this.lbltimeup.Name = "lbltimeup";
            this.lbltimeup.Size = new System.Drawing.Size(70, 20);
            this.lbltimeup.TabIndex = 54;
            this.lbltimeup.Text = "TIME UP!";
            this.lbltimeup.Visible = false;
            // 
            // lblmailsent
            // 
            this.lblmailsent.AutoSize = true;
            this.lblmailsent.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblmailsent.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmailsent.ForeColor = System.Drawing.Color.Lime;
            this.lblmailsent.Location = new System.Drawing.Point(167, 200);
            this.lblmailsent.Name = "lblmailsent";
            this.lblmailsent.Size = new System.Drawing.Size(87, 20);
            this.lblmailsent.TabIndex = 53;
            this.lblmailsent.Text = "Mail Sent ..";
            this.lblmailsent.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // HiMessageForget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(399, 580);
            this.Controls.Add(this.txtverify);
            this.Controls.Add(this.lblforgetpassword);
            this.Controls.Add(this.lblaccount);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.txtforgetmail);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.txtforgetnumber);
            this.Controls.Add(this.lblbacktologin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.progressbar1);
            this.Controls.Add(this.btncheckit);
            this.Controls.Add(this.lblempty);
            this.Controls.Add(this.lbltimeup);
            this.Controls.Add(this.lblmailsent);
            this.Controls.Add(this.panelcontrol);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.btnsendmail);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(415, 619);
            this.MinimumSize = new System.Drawing.Size(415, 619);
            this.Name = "HiMessageForget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HiMessageForget";
            this.panelcontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelcontrol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclose;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtverify;
        private System.Windows.Forms.Label lblforgetpassword;
        private System.Windows.Forms.Label lblaccount;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtforgetmail;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtforgetnumber;
        private System.Windows.Forms.Label lblbacktologin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressbar1;
        private Bunifu.Framework.UI.BunifuThinButton2 btncheckit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnverify;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsendmail;
        private System.Windows.Forms.Label lblempty;
        private System.Windows.Forms.Label lbltimeup;
        private System.Windows.Forms.Label lblmailsent;
        private System.Windows.Forms.Timer timer1;
    }
}