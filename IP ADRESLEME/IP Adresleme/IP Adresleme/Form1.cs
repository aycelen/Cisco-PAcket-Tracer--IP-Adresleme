    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace IP_Adresleme
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
        
            private void hesapla_Click(object sender, EventArgs e)
            {

                int ips1 = Convert.ToInt32(ip1.Text);
                int ips2 = Convert.ToInt32(ip2.Text);
                int ips3 = Convert.ToInt32(ip3.Text);
                int ips4 = Convert.ToInt32(ip4.Text);


                if (0<ips1 && ips1 < 127)
                {
                   sm1.Text="255";
                   sm2.Text = "0";
                   sm3.Text = "0";
                   sm4.Text = "0";
                   sm5.Text = "A Sınıfı";
                   ag1.Text = ip1.Text;
                   ag2.Text = "0";
                   ag3.Text = "0";
                   ag4.Text = "0";
                   gt1.Text = ip1.Text;
                   gt2.Text = "0";
                   gt3.Text = "0";
                   gt4.Text = "1";
                   bc1.Text = ip1.Text;
                   bc2.Text = ip2.Text;
                   bc3.Text = ip3.Text;
                   bc4.Text = "255";


                } 
                if(ips1==127)
                {
                    MessageBox.Show("127'li Ip'ler test amaçlı kullanılırlar !");
            
                }
                if(127<ips1 && ips1<192)
                {
                    sm1.Text = "255";
                    sm2.Text = "255";
                    sm3.Text = "0";
                    sm4.Text = "0";
                    sm5.Text = "B Sınıfı";
                   ag1.Text = ip1.Text;
                   ag2.Text = ip2.Text;
                   ag3.Text = "0";
                   ag4.Text = "0";
                   gt1.Text = ip1.Text;
                   gt2.Text = ip2.Text;
                   gt3.Text = "0";
                   gt4.Text = "1";
                   bc1.Text = ip1.Text;
                   bc2.Text = ip2.Text;
                   bc3.Text = ip3.Text;
                   bc4.Text = "255";

                }
                if (191 < ips1 && ips1 < 224)
                {
                    sm1.Text = "255";
                    sm2.Text = "255";
                    sm3.Text = "255";
                    sm4.Text = "0";
                    sm5.Text = "C Sınıfı";
                    ag1.Text = ip1.Text;
                    ag2.Text = ip2.Text;
                    ag3.Text = ip3.Text;
                    ag4.Text = "0";
                    gt1.Text = ip1.Text;
                    gt2.Text = ip2.Text;
                    gt3.Text = ip3.Text;
                    gt4.Text = "1";
                    bc1.Text = ip1.Text;
                    bc2.Text = ip2.Text;
                    bc3.Text = ip3.Text;
                    bc4.Text = "255";


                }
                if (223 < ips1 && ips1 < 240)
                {
                    sm1.Text = "255";
                    sm2.Text = "255";
                    sm3.Text = "255";
                    sm4.Text = "255";
                    sm5.Text = "D Sınıfı";
                    ag1.Text = ip1.Text;
                    ag2.Text = ip2.Text;
                    ag3.Text = ip3.Text;
                    ag4.Text = ip4.Text;
                    gt1.Text = ip1.Text;
                    gt2.Text = ip2.Text;
                    gt3.Text = ip3.Text;
                    gt4.Text = ip4.Text;
                    bc1.Text = ip1.Text;
                    bc2.Text = ip2.Text;
                    bc3.Text = ip3.Text;
                    bc4.Text = "255";

                }
            }

            private void ip1_Leave(object sender, EventArgs e)
            {
                {
                    try
                    {
                        if (Convert.ToInt32(ip1.Text) < 0 || Convert.ToInt32(ip1.Text) > 255)
                        {
                            MessageBox.Show("Değer 0-255 arasında olmalı !");
                            ip1.Text = "";
                            ip1.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sayısal bir değer girin.");
                        ip1.Text = "";
                        ip1.Focus();
                    }
                }
            }

            private void ip2_Leave(object sender, EventArgs e)
            {
                {
                    try
                    {
                 

                        if (Convert.ToInt32(ip2.Text) < 0 || Convert.ToInt32(ip2.Text) > 255 )
                        {
                            MessageBox.Show("Değer 0-255 arasında olmalı");
                            ip2.Text = "";
                            ip2.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sayısal bir değer girin");
                        ip2.Text = "";
                        ip2.Focus();
                    }
                }
            }

            private void ip3_Leave(object sender, EventArgs e)
            {
                {
                    try
                    {
                        if (Convert.ToInt32(ip3.Text) < 0 || Convert.ToInt32(ip3.Text) > 255)
                        {
                            MessageBox.Show("Değer 0-255 arasında olmalı");
                            ip3.Text = "";
                            ip3.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sayısal bir değer girin");
                        ip3.Text = "";
                        ip3.Focus();
                    }
                }
            }

            private void ip4_Leave(object sender, EventArgs e)
            {
                {
                    try
                    {
                        if (Convert.ToInt32(ip4.Text) < 0 || Convert.ToInt32(ip4.Text) > 255)
                        {
                            MessageBox.Show("Değer 0-255 arasında olmalı");
                            ip4.Text = "";
                            ip4.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sayısal bir değer girin");
                        ip4.Text = "";
                        ip4.Focus();
                    }
                }
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }

  
        }
    }
