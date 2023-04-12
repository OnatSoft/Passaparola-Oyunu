using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        int zaman = 100;

        public void oyunBitir()
        {
            btnSonraki.Enabled = false;
            btnPass.Enabled = false;
            btnStart.Enabled = true;
            lblDogruSayisi.Text = "00";
            lblYanlisSayisi.Text = "00";
            lblZaman.Text = "00";
            txtYanit.Text = " ";
            soruNo = 0;
            richTextBox1.Text = "OYUN BİTTİ!!";
            //-------------------------------------------------//
            button1.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;
            button3.BackColor = Color.Transparent;
            button4.BackColor = Color.Transparent;
            button5.BackColor = Color.Transparent;
            button6.BackColor = Color.Transparent;
            button7.BackColor = Color.Transparent;
            button8.BackColor = Color.Transparent;
            button9.BackColor = Color.Transparent;
            button10.BackColor = Color.Transparent;
            button11.BackColor = Color.Transparent;
            button12.BackColor = Color.Transparent;
            button13.BackColor = Color.Transparent;
            button14.BackColor = Color.Transparent;
            button15.BackColor = Color.Transparent;
            button16.BackColor = Color.Transparent;
            button17.BackColor = Color.Transparent;
            button18.BackColor = Color.Transparent;
            button19.BackColor = Color.Transparent;
            button20.BackColor = Color.Transparent;
            button21.BackColor = Color.Transparent;
            button22.BackColor = Color.Transparent;
            button23.BackColor = Color.Transparent;
            button24.BackColor = Color.Transparent;
            button25.BackColor = Color.Transparent;
            button26.BackColor = Color.Transparent;
        }

        public void sorular()
        {
            if (soruNo == 1)
            {
                richTextBox1.Text = "Ülkemizin güney yönünde ki kıyı bölgesi neresidir?";
                button1.BackColor = Color.Yellow;
                button27.Text = "A";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü İç Anadolu bölgesinde ki ilimiz nedir?";
                button2.BackColor = Color.Yellow;
                button27.Text = "B";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü nedir?";
                button3.BackColor = Color.Yellow;
                button27.Text = "C";
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Samsun ilimizin ilçesi nedir?";
                button4.BackColor = Color.Yellow;
                button27.Text = "Ç";
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Türkiye'nin 3 tarafı nelerle çevrilidir?";
                button5.BackColor = Color.Yellow;
                button27.Text = "D";
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı nedir?";
                button6.BackColor = Color.Yellow;
                button27.Text = "E";
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali nedir?";
                button7.BackColor = Color.Yellow;
                button27.Text = "F";
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Doğal sistemlerle oluşmuş ısı ve ışık kaynağı nedir?";
                button8.BackColor = Color.Yellow;
                button27.Text = "G";
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Dikey iniş-kalkış yapabilen daha çok kısa mesafelere havadan gidilebilen hava taşıtı?";
                button9.BackColor = Color.Yellow;
                button27.Text = "H";
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Yaşlı kelimesine sesteş gelen kelime nedir?";
                button10.BackColor = Color.Yellow;
                button27.Text = "İ";
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Doğu Anadolu bölgemizde bulunan şehrimiz neresidir?";
                button11.BackColor = Color.Yellow;
                button27.Text = "I";
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Askeri alanda görevler yapan devlet kurumu neresidir?";
                button12.BackColor = Color.Yellow;
                button27.Text = "J";
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Denizlerde veya okyanuslarda yaşayan yırtıcı bir balık türü?";
                button13.BackColor = Color.Yellow;
                button27.Text = "K";
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Şehirlerin deniz kıyılarında olan teknelerin, gemilerin park ettiği yer neresidir?";
                button14.BackColor = Color.Yellow;
                button27.Text = "L";
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "Değerli taşların, kömürün yer altından çıkarıldığı yer neresidir?";
                button15.BackColor = Color.Yellow;
                button27.Text = "M";
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Her yıl baharın gelişi kutlanan eğlence veya festival nedir?";
                button16.BackColor = Color.Yellow;
                button27.Text = "N";
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Halk şairinin diğer adı nedir?";
                button17.BackColor = Color.Yellow;
                button27.Text = "O";
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "Kış mevsiminin vazgeçilmezi olan vitamin dolu meyve nedir?";
                button18.BackColor = Color.Yellow;
                button27.Text = "P";
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "11 Ayın sultanı da denilen günler nedir?";
                button19.BackColor = Color.Yellow;
                button27.Text = "R";
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Marmara ve Ege denizinde sıklıkla karşılaşılan küçük lezzetli balık türü nedir?";
                button20.BackColor = Color.Yellow;
                button27.Text = "S";
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Çocukların hastalığını iyileştirmek için verilen sıvı ilacın adı nedir?";
                button21.BackColor = Color.Yellow;
                button27.Text = "Ş";
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Dünya'nın yeryüzünü kaplamış çiçekler, bitkiler, sebzeler yetişen yumuşak doku nedir?";
                button22.BackColor = Color.Yellow;
                button27.Text = "T";
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı nedir?";
                button23.BackColor = Color.Yellow;
                button27.Text = "U";
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Türkiye'nin ilinden gelen bir kedi cinsi?";
                button24.BackColor = Color.Yellow;
                button27.Text = "V";
            }
            if (soruNo == 25)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı nedir?";
                button25.BackColor = Color.Yellow;
                button27.Text = "Y";
            }
            if (soruNo == 26)
            {
                richTextBox1.Text = "Ege bölgesinde yüzyıllarca yetişen her hastalığa derman bulabilen, yağı yapılan kahvaltılık yiyecek nedir?";
                button26.BackColor = Color.Yellow;
                button27.Text = "Z";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Soru: " + soruNo.ToString();
            txtYanit.Text = " ";

            btnSonraki.Enabled = true;
            btnPass.Enabled = true;
            btnStart.Enabled = false;
            richTextBox1.Text = " ";
            timer1.Start();

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            oyunBitir();
            timer1.Stop();
            lblZaman.Text = "100";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zaman--;
            lblZaman.Text = zaman.ToString();
        }

        private void txtYanit_KeyDown(object sender, KeyEventArgs e)
        {
            //CEVAPLAR ---------------------------------------------------------------
            btnSonraki.Enabled = false;

            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    case 1:
                        if (txtYanit.Text == "AKDENİZ")
                        {
                            button1.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 2:
                        if (txtYanit.Text == "BURSA")
                        {
                            button2.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 3:
                        if (txtYanit.Text == "CUMA")
                        {
                            button3.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 4:
                        if (txtYanit.Text == "ÇARŞAMBA")
                        {
                            button4.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 5:
                        if (txtYanit.Text == "DENİZ")
                        {
                            button5.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 6:
                        if (txtYanit.Text == "ESKİ")
                        {
                            button6.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 7:
                        if (txtYanit.Text == "FERMAN")
                        {
                            button7.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 8:
                        if (txtYanit.Text == "GÜNEŞ")
                        {
                            button8.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 9:
                        if (txtYanit.Text == "HELİKOPTER")
                        {
                            button9.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 10:
                        if (txtYanit.Text == "İHTİYAR")
                        {
                            button10.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 11:
                        if (txtYanit.Text == "IĞDIR")
                        {
                            button11.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 12:
                        if (txtYanit.Text == "JANDARMA")
                        {
                            button12.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 13:
                        if (txtYanit.Text == "KÖPEKBALIĞI")
                        {
                            button13.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 14:
                        if (txtYanit.Text == "LİMAN")
                        {
                            button14.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 15:
                        if (txtYanit.Text == "MADEN")
                        {
                            button15.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 16:
                        if (txtYanit.Text == "NEVRUZ")
                        {
                            button16.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 17:
                        if (txtYanit.Text == "OZAN")
                        {
                            button17.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 18:
                        if (txtYanit.Text == "PORTAKAL")
                        {
                            button18.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 19:
                        if (txtYanit.Text == "RAMAZAN")
                        {
                            button19.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 20:
                        if (txtYanit.Text == "SARDALYA")
                        {
                            button20.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 21:
                        if (txtYanit.Text == "ŞURUP")
                        {
                            button21.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 22:
                        if (txtYanit.Text == "TOPRAK")
                        {
                            button22.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 23:
                        if (txtYanit.Text == "UMUT")
                        {
                            button23.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 24:
                        if (txtYanit.Text == "VAN KEDİSİ")
                        {
                            button24.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 25:
                        if (txtYanit.Text == "YILDIRIM")
                        {
                            button25.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button25.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;

                    case 26:
                        if (txtYanit.Text == "ZEYTİN")
                        {
                            button26.BackColor = Color.LimeGreen;
                            dogru++;
                            lblDogruSayisi.Text = dogru.ToString();
                            btnSonraki.Enabled = true;
                        }
                        else
                        {
                            button26.BackColor = Color.Red;
                            yanlis++;
                            lblYanlisSayisi.Text = yanlis.ToString();
                            btnSonraki.Enabled = true;
                        }
                        break;
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            //SORULAR -----------------------------------------------------------------
            soruNo++;
            groupBox1.Text = "Soru: " + soruNo.ToString();
            txtYanit.Text = " ";
            sorular();
        }
    }
}
