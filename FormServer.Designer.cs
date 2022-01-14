namespace SystemManagement
{
    partial class FormServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstClientIP = new System.Windows.Forms.ListBox();
            this.btnsend2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnstart1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtmsge = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstClientIP);
            this.groupBox1.Controls.Add(this.btnsend2);
            this.groupBox1.Controls.Add(this.btnstart1);
            this.groupBox1.Controls.Add(this.txtmsge);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(7, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVER";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(844, 451);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 62);
            this.button2.TabIndex = 22;
            this.button2.Text = "Client";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(807, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 20;
            this.label3.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(591, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Client IP";
            // 
            // lstClientIP
            // 
            this.lstClientIP.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstClientIP.FormattingEnabled = true;
            this.lstClientIP.ItemHeight = 22;
            this.lstClientIP.Location = new System.Drawing.Point(586, 71);
            this.lstClientIP.Name = "lstClientIP";
            this.lstClientIP.Size = new System.Drawing.Size(198, 400);
            this.lstClientIP.TabIndex = 18;
            // 
            // btnsend2
            // 
            this.btnsend2.ActiveBorderThickness = 1;
            this.btnsend2.ActiveCornerRadius = 20;
            this.btnsend2.ActiveFillColor = System.Drawing.Color.Lime;
            this.btnsend2.ActiveForecolor = System.Drawing.Color.Black;
            this.btnsend2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnsend2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsend2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend2.BackgroundImage")));
            this.btnsend2.ButtonText = "Send";
            this.btnsend2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsend2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsend2.IdleBorderThickness = 1;
            this.btnsend2.IdleCornerRadius = 20;
            this.btnsend2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnsend2.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnsend2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnsend2.Location = new System.Drawing.Point(419, 451);
            this.btnsend2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnsend2.Name = "btnsend2";
            this.btnsend2.Size = new System.Drawing.Size(148, 57);
            this.btnsend2.TabIndex = 17;
            this.btnsend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsend2.Click += new System.EventHandler(this.btnsend2_Click_1);
            // 
            // btnstart1
            // 
            this.btnstart1.ActiveBorderThickness = 1;
            this.btnstart1.ActiveCornerRadius = 20;
            this.btnstart1.ActiveFillColor = System.Drawing.Color.Lime;
            this.btnstart1.ActiveForecolor = System.Drawing.Color.Black;
            this.btnstart1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnstart1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnstart1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstart1.BackgroundImage")));
            this.btnstart1.ButtonText = "Start";
            this.btnstart1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnstart1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart1.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnstart1.IdleBorderThickness = 1;
            this.btnstart1.IdleCornerRadius = 20;
            this.btnstart1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnstart1.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnstart1.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnstart1.Location = new System.Drawing.Point(374, 37);
            this.btnstart1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnstart1.Name = "btnstart1";
            this.btnstart1.Size = new System.Drawing.Size(193, 41);
            this.btnstart1.TabIndex = 16;
            this.btnstart1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnstart1.Click += new System.EventHandler(this.btnstart1_Click_1);
            // 
            // txtmsge
            // 
            this.txtmsge.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsge.Location = new System.Drawing.Point(45, 340);
            this.txtmsge.Multiline = true;
            this.txtmsge.Name = "txtmsge";
            this.txtmsge.Size = new System.Drawing.Size(522, 102);
            this.txtmsge.TabIndex = 15;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(42, 98);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(525, 199);
            this.txtStatus.TabIndex = 14;
            // 
            // txtip
            // 
            this.txtip.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtip.Location = new System.Drawing.Point(123, 42);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(236, 36);
            this.txtip.TabIndex = 13;
            this.txtip.Text = "127.0.0.1:8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Server";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(963, 559);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormServer";
            this.Text = "FormServer";
            this.Load += new System.EventHandler(this.FormServer_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstClientIP;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsend2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnstart1;
        private System.Windows.Forms.TextBox txtmsge;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
    }
}