using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Müzik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (axWindowsMediaPlayer1.isOnline == false)
            {
                MessageBox.Show("İnternete erişimiz bulunmamakta olduğu için radyo programı kullanılamıyor!");
                Application.Exit();
            }
            listBox1.DrawMode = DrawMode.OwnerDrawFixed;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string kanal = listBox1.SelectedItem.ToString();
            if (kanal == "Best Fm")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.7.126/;stream.mp3";
            }
            else if (kanal == "Dream Türk")
            {
                axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/dreamturk";
            }
            else if (kanal == "Fenomen")
            {
                axWindowsMediaPlayer1.URL = "http://fenomenturk.listenfenomen.com/fenomenturk/128/icecast.audio";
            }
            else if (kanal == "Hit Fm")
            {
                axWindowsMediaPlayer1.URL = "http://yayin.turkiletisim.com.tr:1094/;";
            }
            else if (kanal == "Metropol Fm")
            {
                axWindowsMediaPlayer1.URL = "http://mfm1.webradiostreaming.de:8250/1";
            }
            else if (kanal == "Metro Fm")
            {
                axWindowsMediaPlayer1.URL = "https://playerservices.streamtheworld.com/api/livestream-redirect/METRO_FM.mp3";
            }
            else if (kanal == "Moral Fm")
            {
                axWindowsMediaPlayer1.URL = "http://yayin2.canliyayin.org:8886/;stream.mp3";
            }
            else if (kanal == "PowerTürk Fm")
            {
                axWindowsMediaPlayer1.URL = "http://mpegpowerturk.listenpowerapp.com/powerturk/mpeg/icecast.audio";
            }
            else if (kanal == "Ankara Havaları")
            {
                axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/30/?/;stream.mp3";
            }
            else if (kanal == "Radyo Seymen")
            {
                axWindowsMediaPlayer1.URL = "http://yayin.radyoseymen.com.tr:1070/;stream.mp3";
            }
            else if (kanal == "Karadeniz Fm")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.7.100/stream/170/?/;stream.mp3";
            }
              else if (kanal == "Joy Türk")
            {
                axWindowsMediaPlayer1.URL = "https://17733.live.streamtheworld.com/JOY_TURK2_SC?/;stream.mp3";
            }
              else if (kanal == "Kral Fm")
            {
                axWindowsMediaPlayer1.URL = "http://kralwmp.radyotvonline.com/";
            }
              else if (kanal == "Best Fm")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.7.126:80/;stream.mp3";
            }
            else if (kanal == "Radyo D Fm")
            {
                axWindowsMediaPlayer1.URL = "https://slowturk2.turkhosted.com/radyod";
            }
            else if (kanal == "Efkar Fm")
            {
                axWindowsMediaPlayer1.URL = "https://playerservices.streamtheworld.com/api/livestream-redirect/EFKAR_SC";
            }
            else if (kanal == "Baba Fm")
            {
                axWindowsMediaPlayer1.URL = "http://37.247.98.7:80/;";
            }
            else if (kanal == "Radyo Viva Fm")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.3.231:80/;";
            }
            else if (kanal == "Slow Türk Fm")
            {
                axWindowsMediaPlayer1.URL = "http://37.247.100.118/stream/69/";
            }
            else if (kanal == "Kafa Radyo Fm")
            {
                axWindowsMediaPlayer1.URL = "http://46.20.3.245/stream/510/;";
            }
            else if (kanal == "Ntv Spor Radyo")
            {
                axWindowsMediaPlayer1.URL = "http://ntvsporwmp.radyotvonline.com/;";
            }
            else if (kanal == " Fm")
            {
                axWindowsMediaPlayer1.URL = "";
            }
            else if (kanal == " Fm")
            {
                axWindowsMediaPlayer1.URL = "";
            }
            else if (kanal == " Fm")
            {
                axWindowsMediaPlayer1.URL = "";
            }
            else if (kanal == " Fm")
            {
                axWindowsMediaPlayer1.URL = "";
            }
            else if (kanal == " Fm")
            {
                axWindowsMediaPlayer1.URL = "";
            }
            
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.BackColor = ColorTranslator.FromHtml("#0d0d0d");
            axWindowsMediaPlayer1.enableContextMenu = false;
            listBox1.Items.Add("Best Fm");
            listBox1.Items.Add("Dream Türk");
            listBox1.Items.Add("Fenomen");
            listBox1.Items.Add("Hit Fm");
            listBox1.Items.Add("Metropol Fm");
            listBox1.Items.Add("Metro Fm");
            listBox1.Items.Add("Moral Fm");
            listBox1.Items.Add("PowerTürk Fm");
            listBox1.Items.Add("Ankara Havaları");
            listBox1.Items.Add("Radyo Seymen");
            listBox1.Items.Add("Karadeniz Fm");
            listBox1.Items.Add("Joy Türk");
            listBox1.Items.Add("Kral Fm");
            listBox1.Items.Add("Best Fm");
            listBox1.Items.Add("Radyo D Fm");
            listBox1.Items.Add("Efkar Fm");
            listBox1.Items.Add("Baba Fm");
            listBox1.Items.Add("Radyo Viva Fm");
            listBox1.Items.Add("Slow Türk Fm");
            listBox1.Items.Add("Kafa Radyo Fm");
            listBox1.Items.Add("Ntv Spor Radyo");


           

        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < listBox1.Items.Count)
            {
                Graphics g = e.Graphics;

                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush((isItemSelected) ? Color.White : ColorTranslator.FromHtml("#0d0d0d"));
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = listBox1.Items[itemIndex].ToString();

                SolidBrush itemTextColorBrush = (isItemSelected) ? new SolidBrush(Color.Black) : new SolidBrush(Color.White);
                g.DrawString(itemText, e.Font, itemTextColorBrush, listBox1.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string saat = DateTime.Now.ToLongTimeString();
            label2.Text = saat;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hazırlayan : Eyüp Can Balaban\nÜcretsizdir ve her yere dağıtabilirsiniz\nGeliştirmeye devam edilecektir.", "Hakkında");
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Listede olanları tıklarsanız 1-2 dakika bekleyin. İnternete bağlı mı değil mi diye araştırmaya devam ediyor ve açılmayan radyolar şu anda kapalı veya sunucuya bağlanmıyor olabilir.","Yardım");
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ayarlar mı daha yeni yaptık azcık bekle :D", "Ayarlar");
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
