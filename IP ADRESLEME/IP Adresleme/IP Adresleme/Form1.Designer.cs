namespace IP_Adresleme
{
    partial class Form1
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
            this.hesapla = new System.Windows.Forms.Button();
            this.ipadresi = new System.Windows.Forms.Label();
            this.subnet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ip1 = new System.Windows.Forms.TextBox();
            this.ip3 = new System.Windows.Forms.TextBox();
            this.ip4 = new System.Windows.Forms.TextBox();
            this.sm1 = new System.Windows.Forms.TextBox();
            this.sm3 = new System.Windows.Forms.TextBox();
            this.sm2 = new System.Windows.Forms.TextBox();
            this.sm5 = new System.Windows.Forms.TextBox();
            this.sm4 = new System.Windows.Forms.TextBox();
            this.gt1 = new System.Windows.Forms.TextBox();
            this.gt4 = new System.Windows.Forms.TextBox();
            this.gt2 = new System.Windows.Forms.TextBox();
            this.gt3 = new System.Windows.Forms.TextBox();
            this.ag1 = new System.Windows.Forms.TextBox();
            this.ag4 = new System.Windows.Forms.TextBox();
            this.ag2 = new System.Windows.Forms.TextBox();
            this.ag3 = new System.Windows.Forms.TextBox();
            this.bc3 = new System.Windows.Forms.TextBox();
            this.bc1 = new System.Windows.Forms.TextBox();
            this.bc2 = new System.Windows.Forms.TextBox();
            this.bc4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.ip2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // hesapla
            // 
            this.hesapla.Location = new System.Drawing.Point(379, 125);
            this.hesapla.Name = "hesapla";
            this.hesapla.Size = new System.Drawing.Size(75, 23);
            this.hesapla.TabIndex = 0;
            this.hesapla.Text = "Hesapla";
            this.hesapla.UseVisualStyleBackColor = true;
            this.hesapla.Click += new System.EventHandler(this.hesapla_Click);
            // 
            // ipadresi
            // 
            this.ipadresi.AutoSize = true;
            this.ipadresi.Location = new System.Drawing.Point(5, 9);
            this.ipadresi.Name = "ipadresi";
            this.ipadresi.Size = new System.Drawing.Size(55, 13);
            this.ipadresi.TabIndex = 1;
            this.ipadresi.Text = "IP Adresi :";
            // 
            // subnet
            // 
            this.subnet.AutoSize = true;
            this.subnet.Location = new System.Drawing.Point(5, 40);
            this.subnet.Name = "subnet";
            this.subnet.Size = new System.Drawing.Size(76, 13);
            this.subnet.TabIndex = 1;
            this.subnet.Text = "Subnet Mask :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "D.Gateway : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ağ Adresi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Broadcast :";
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(80, 6);
            this.ip1.MaxLength = 3;
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(41, 20);
            this.ip1.TabIndex = 2;
            this.ip1.Leave += new System.EventHandler(this.ip1_Leave);
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(203, 6);
            this.ip3.MaxLength = 3;
            this.ip3.Multiline = true;
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(41, 20);
            this.ip3.TabIndex = 2;
            this.ip3.Leave += new System.EventHandler(this.ip3_Leave);
            // 
            // ip4
            // 
            this.ip4.Location = new System.Drawing.Point(266, 6);
            this.ip4.MaxLength = 3;
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(41, 20);
            this.ip4.TabIndex = 2;
            this.ip4.Leave += new System.EventHandler(this.ip4_Leave);
            // 
            // sm1
            // 
            this.sm1.Location = new System.Drawing.Point(80, 37);
            this.sm1.Name = "sm1";
            this.sm1.Size = new System.Drawing.Size(41, 20);
            this.sm1.TabIndex = 2;
            // 
            // sm3
            // 
            this.sm3.Location = new System.Drawing.Point(203, 37);
            this.sm3.Name = "sm3";
            this.sm3.Size = new System.Drawing.Size(41, 20);
            this.sm3.TabIndex = 2;
            // 
            // sm2
            // 
            this.sm2.Location = new System.Drawing.Point(140, 37);
            this.sm2.Name = "sm2";
            this.sm2.Size = new System.Drawing.Size(41, 20);
            this.sm2.TabIndex = 2;
            // 
            // sm5
            // 
            this.sm5.Location = new System.Drawing.Point(331, 37);
            this.sm5.Name = "sm5";
            this.sm5.Size = new System.Drawing.Size(41, 20);
            this.sm5.TabIndex = 2;
            // 
            // sm4
            // 
            this.sm4.Location = new System.Drawing.Point(266, 37);
            this.sm4.Name = "sm4";
            this.sm4.Size = new System.Drawing.Size(41, 20);
            this.sm4.TabIndex = 2;
            // 
            // gt1
            // 
            this.gt1.Location = new System.Drawing.Point(80, 99);
            this.gt1.Name = "gt1";
            this.gt1.Size = new System.Drawing.Size(41, 20);
            this.gt1.TabIndex = 2;
            // 
            // gt4
            // 
            this.gt4.Location = new System.Drawing.Point(266, 100);
            this.gt4.Name = "gt4";
            this.gt4.Size = new System.Drawing.Size(41, 20);
            this.gt4.TabIndex = 2;
            // 
            // gt2
            // 
            this.gt2.Location = new System.Drawing.Point(140, 99);
            this.gt2.Name = "gt2";
            this.gt2.Size = new System.Drawing.Size(41, 20);
            this.gt2.TabIndex = 2;
            // 
            // gt3
            // 
            this.gt3.Location = new System.Drawing.Point(203, 100);
            this.gt3.Name = "gt3";
            this.gt3.Size = new System.Drawing.Size(41, 20);
            this.gt3.TabIndex = 2;
            // 
            // ag1
            // 
            this.ag1.Location = new System.Drawing.Point(80, 70);
            this.ag1.Name = "ag1";
            this.ag1.Size = new System.Drawing.Size(41, 20);
            this.ag1.TabIndex = 2;
            // 
            // ag4
            // 
            this.ag4.Location = new System.Drawing.Point(266, 70);
            this.ag4.Name = "ag4";
            this.ag4.Size = new System.Drawing.Size(41, 20);
            this.ag4.TabIndex = 2;
            // 
            // ag2
            // 
            this.ag2.Location = new System.Drawing.Point(140, 70);
            this.ag2.Name = "ag2";
            this.ag2.Size = new System.Drawing.Size(41, 20);
            this.ag2.TabIndex = 2;
            // 
            // ag3
            // 
            this.ag3.Location = new System.Drawing.Point(203, 70);
            this.ag3.Name = "ag3";
            this.ag3.Size = new System.Drawing.Size(41, 20);
            this.ag3.TabIndex = 2;
            // 
            // bc3
            // 
            this.bc3.Location = new System.Drawing.Point(203, 129);
            this.bc3.Name = "bc3";
            this.bc3.Size = new System.Drawing.Size(41, 20);
            this.bc3.TabIndex = 2;
            // 
            // bc1
            // 
            this.bc1.Location = new System.Drawing.Point(80, 129);
            this.bc1.Name = "bc1";
            this.bc1.Size = new System.Drawing.Size(41, 20);
            this.bc1.TabIndex = 2;
            // 
            // bc2
            // 
            this.bc2.Location = new System.Drawing.Point(140, 129);
            this.bc2.Name = "bc2";
            this.bc2.Size = new System.Drawing.Size(41, 20);
            this.bc2.TabIndex = 2;
            // 
            // bc4
            // 
            this.bc4.Location = new System.Drawing.Point(266, 129);
            this.bc4.Name = "bc4";
            this.bc4.Size = new System.Drawing.Size(41, 20);
            this.bc4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(127, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = ".";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(250, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = ".";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(187, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = ".";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 109);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = ".";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(127, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = ".";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(187, 131);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = ".";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(187, 103);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(10, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = ".";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(250, 136);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(10, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = ".";
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(140, 6);
            this.ip2.MaxLength = 3;
            this.ip2.Multiline = true;
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(41, 20);
            this.ip2.TabIndex = 2;
            this.ip2.Leave += new System.EventHandler(this.ip3_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 491);
            this.Controls.Add(this.bc4);
            this.Controls.Add(this.ag4);
            this.Controls.Add(this.gt3);
            this.Controls.Add(this.sm3);
            this.Controls.Add(this.sm4);
            this.Controls.Add(this.ip4);
            this.Controls.Add(this.bc1);
            this.Controls.Add(this.ag1);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.gt1);
            this.Controls.Add(this.sm1);
            this.Controls.Add(this.bc3);
            this.Controls.Add(this.ag3);
            this.Controls.Add(this.gt2);
            this.Controls.Add(this.sm5);
            this.Controls.Add(this.bc2);
            this.Controls.Add(this.ag2);
            this.Controls.Add(this.gt4);
            this.Controls.Add(this.sm2);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subnet);
            this.Controls.Add(this.ipadresi);
            this.Controls.Add(this.hesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesapla;
        private System.Windows.Forms.Label ipadresi;
        private System.Windows.Forms.Label subnet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ip1;
        private System.Windows.Forms.TextBox ip3;
        private System.Windows.Forms.TextBox ip4;
        private System.Windows.Forms.TextBox sm1;
        private System.Windows.Forms.TextBox sm3;
        private System.Windows.Forms.TextBox sm2;
        private System.Windows.Forms.TextBox sm5;
        private System.Windows.Forms.TextBox sm4;
        private System.Windows.Forms.TextBox gt1;
        private System.Windows.Forms.TextBox gt4;
        private System.Windows.Forms.TextBox gt2;
        private System.Windows.Forms.TextBox gt3;
        private System.Windows.Forms.TextBox ag1;
        private System.Windows.Forms.TextBox ag4;
        private System.Windows.Forms.TextBox ag2;
        private System.Windows.Forms.TextBox ag3;
        private System.Windows.Forms.TextBox bc3;
        private System.Windows.Forms.TextBox bc1;
        private System.Windows.Forms.TextBox bc2;
        private System.Windows.Forms.TextBox bc4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox ip2;
    }
}

