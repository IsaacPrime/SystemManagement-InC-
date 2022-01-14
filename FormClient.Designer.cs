namespace SystemManagement
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHome = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsend2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnconnect2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtmsge = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHome);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnsend2);
            this.groupBox1.Controls.Add(this.btnconnect2);
            this.groupBox1.Controls.Add(this.txtmsge);
            this.groupBox1.Controls.Add(this.txtStatus);
            this.groupBox1.Controls.Add(this.txtip);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 486);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnHome
            // 
            this.btnHome.ActiveBorderThickness = 1;
            this.btnHome.ActiveCornerRadius = 20;
            this.btnHome.ActiveFillColor = System.Drawing.Color.Chartreuse;
            this.btnHome.ActiveForecolor = System.Drawing.Color.Black;
            this.btnHome.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnHome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHome.BackgroundImage")));
            this.btnHome.ButtonText = "Home";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHome.IdleBorderThickness = 1;
            this.btnHome.IdleCornerRadius = 20;
            this.btnHome.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHome.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHome.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnHome.Location = new System.Drawing.Point(759, 19);
            this.btnHome.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(179, 65);
            this.btnHome.TabIndex = 36;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(827, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 59);
            this.button1.TabIndex = 35;
            this.button1.Text = "Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(111, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 27);
            this.label3.TabIndex = 34;
            this.label3.Text = "Message";
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
            this.btnsend2.Location = new System.Drawing.Point(433, 428);
            this.btnsend2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnsend2.Name = "btnsend2";
            this.btnsend2.Size = new System.Drawing.Size(148, 42);
            this.btnsend2.TabIndex = 33;
            this.btnsend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsend2.Click += new System.EventHandler(this.btnsend2_Click_1);
            // 
            // btnconnect2
            // 
            this.btnconnect2.ActiveBorderThickness = 1;
            this.btnconnect2.ActiveCornerRadius = 20;
            this.btnconnect2.ActiveFillColor = System.Drawing.Color.Lime;
            this.btnconnect2.ActiveForecolor = System.Drawing.Color.Black;
            this.btnconnect2.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnconnect2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnconnect2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnconnect2.BackgroundImage")));
            this.btnconnect2.ButtonText = "Connect";
            this.btnconnect2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconnect2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconnect2.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnconnect2.IdleBorderThickness = 1;
            this.btnconnect2.IdleCornerRadius = 20;
            this.btnconnect2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnconnect2.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnconnect2.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnconnect2.Location = new System.Drawing.Point(433, 29);
            this.btnconnect2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnconnect2.Name = "btnconnect2";
            this.btnconnect2.Size = new System.Drawing.Size(148, 41);
            this.btnconnect2.TabIndex = 32;
            this.btnconnect2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnconnect2.Click += new System.EventHandler(this.btnconnect2_Click);
            // 
            // txtmsge
            // 
            this.txtmsge.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmsge.Location = new System.Drawing.Point(116, 317);
            this.txtmsge.Multiline = true;
            this.txtmsge.Name = "txtmsge";
            this.txtmsge.Size = new System.Drawing.Size(465, 102);
            this.txtmsge.TabIndex = 31;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(116, 76);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(465, 199);
            this.txtStatus.TabIndex = 30;
            // 
            // txtip
            // 
            this.txtip.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtip.Location = new System.Drawing.Point(116, 34);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(236, 36);
            this.txtip.TabIndex = 29;
            this.txtip.Text = "127.0.0.1:8080";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 28;
            this.label1.Text = "Server";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(956, 512);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClient";
            this.Text = "FormClient";
            this.Load += new System.EventHandler(this.FormClient_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnsend2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnconnect2;
        private System.Windows.Forms.TextBox txtmsge;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
    }
}