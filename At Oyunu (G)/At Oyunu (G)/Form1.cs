using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace At_Oyunu__G_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //MessageBox'ta tamam tuşuna basıldıktan sonra atların yeniden eski konumunu alması için "YenidenBaslat" Metodu oluşturuluyor.
        //Ve tekrar Soldan uzaklıkları eşleştiriliyor. Böylece atlar eski konumundan tekrar başlıyor...
        public void YenidenBaslat()
        {
            pictureBox1.Left = birinciatsolauzaklık;
            pictureBox2.Left = ikinciatsolauzaklık;
            pictureBox3.Left = ucuncuatsolauzaklık;
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;
        Random rastgele = new Random();
        int at1puan = 0, at2puan = 0, at3puan = 0;

        private void btnYenidenBaslat_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            YenidenBaslat();
            txtDurum.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //At Genişliği değişkenleri PictureBox'lar ile eşleştiriliyor.
            //Atların yarış bittiğinde durması için durulacak yer olan button2 bitisuzakligi değişkenine eşleştiriliyor.
            //Atların soldan uzaklıkları random olarak atanıyor.
            int birinciatıngenisligi = pictureBox1.Width;
            int ikinciatıngenisligi = pictureBox2.Width;
            int ucuncuatıngenisligi = pictureBox3.Width;
            int bitisuzakligi = button2.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);
            //Atların button2'de durması için, Eğer at genişliği + Atların soldan uzaklıkları button 2den büyükse kazanan atın durması sağlanıyor.
            if (birinciatıngenisligi + pictureBox1.Left >= button2.Left)
            {
                /*Oyun bittikten sonra timer durduruluyor ve kullanıcıya Evet/Hayır seçenekleri sunuluyor. Evet Seçeneği seçildiğinde
                 oyun yeniden başlıyor ve kazanan atın kazanma sayısı bir artıyor ve sıfırlanmıyor. Hayır Seçeneği seçildiğinde atların
                 kazanma sayıları sıfırlanıyor ve atlar eski konumlarına geri döndürülüyor.*/
                timer1.Stop();
                if (MessageBox.Show("Birinci At Oyunu Kazandı","Yeniden Oynamak İstermisiniz ?" , MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    YenidenBaslat();
                    txtDurum.Clear();
                    timer1.Enabled = true;
                    at1puan++;
                    txtAt1puan.Text = at1puan.ToString();
                }
                else
                {
                    YenidenBaslat();
                    txtDurum.Clear();
                    txtAt1puan.Text = "0";
                    at1puan = 0;
                    txtAt2puan.Text = "0";
                    at2puan = 0;
                    txtAt3puan.Text = "0";
                    at3puan = 0;
                }
            }
            if (ikinciatıngenisligi + pictureBox2.Left >= button2.Left)
            {
                timer1.Stop();
                if (MessageBox.Show("İkinci At Oyunu Kazandı", "Yeniden Oynamak İstermisiniz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    YenidenBaslat();
                    txtDurum.Clear();
                    timer1.Enabled = true;
                    at2puan++;
                    txtAt2puan.Text = at2puan.ToString();
                }
                else
                {
                    YenidenBaslat();
                    txtDurum.Clear();
                    txtAt1puan.Text = "0";
                    at1puan = 0;
                    txtAt2puan.Text = "0";
                    at2puan = 0;
                    txtAt3puan.Text = "0";
                    at3puan = 0;
                }
            }
            if (ucuncuatıngenisligi + pictureBox3.Left >= button2.Left)
            {
                timer1.Stop();
                if (MessageBox.Show("Üçüncü At Oyunu Kazandı", "Yeniden Oynamak İstermisiniz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    YenidenBaslat();
                    txtDurum.Clear();
                    timer1.Enabled = true;
                    at3puan++;
                    txtAt3puan.Text = at3puan.ToString();
                }
                else
                {
                    YenidenBaslat();
                    txtDurum.Clear();
                    txtAt1puan.Text = "0";
                    at1puan = 0;
                    txtAt2puan.Text = "0";
                    at2puan = 0;
                    txtAt3puan.Text = "0";
                    at3puan = 0;
                }
            }
            //Biraz imkansız bir olay olsada üç atta aynı anda yarışı bitrirse "Atlar berabere kaldı" mesajı ekranda görülmesi sağlanıyor.
            if (ucuncuatıngenisligi + pictureBox3.Left >= button2.Left && ikinciatıngenisligi + pictureBox2.Left >= button2.Left && birinciatıngenisligi + pictureBox1.Left >= button2.Left)
            {
                MessageBox.Show("Atlar Berabere Kaldı.");
            }
            //Kimin önde olup olmadığı kontrol ettirilip listbox'a yazılıyor.
            if  (pictureBox1.Left > pictureBox2.Left &&  pictureBox1.Left > pictureBox3.Left)
            {
                txtDurum.Text = "Birinci At Önde";
            }
            if (pictureBox2.Left > pictureBox1.Left && pictureBox2.Left > pictureBox3.Left)
            {
                txtDurum.Text = "İkinci At Önde";
            }
            if (pictureBox3.Left > pictureBox1.Left && pictureBox3.Left > pictureBox2.Left)
            {
                txtDurum.Text = "Üçüncü At Önde";
            }

        }
        //Butona basıldığında Timer1'in aktifleşmesi ve atların yarışa başlaması sağlanıyor.
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        //Program açıldığında Atların soldan uzaklıklığı değişkenleri PictureBox.Left yapılarına eşleştiriliyor.
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
          
        }
    }
}
