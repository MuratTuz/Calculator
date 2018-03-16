using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Matris : Form
    {
        public Matris()
        {
            InitializeComponent();
        }

        int x1 = -1, y1 = -2, x2 = -3, y2 = -4;
        int sutun = 0;
        bool matrisOK = false;
        private void Matris_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Hide();
            label5.Visible = false;
            listView1.Visible = false;
            
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            if (initialAll())
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                matrisOK = true;
                groupBox3.Hide();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void initialTextBox()
        {
            int birinci = x1 * y1;
            int ikinci = x2 * y2;

            var tbx = new TextBox[birinci];
            for (int i = 0; i < x1; i++)
            {
                for (int k = 0; k < y1; k++)
                {
                    var tbox = new TextBox();
                    this.Controls.Add(tbox);
                    tbox.Font = new Font("Digital-7", 10.0f, FontStyle.Regular);
                    tbox.Name = "tbx" + (i * y1 + k).ToString();
                    tbox.Parent = groupBox1;
                    tbox.Text = (i * y1 + k).ToString();
                    tbox.SetBounds(10 + 30 * k, 20 + 25 * i, 25, 20);
                    tbx[i * y1 + k] = tbox;
                }

            }

            var tby = new TextBox[ikinci];
            for (int i = 0; i < x2; i++)
            {
                for (int k = 0; k < y2; k++)
                {
                    var tbox = new TextBox();
                    this.Controls.Add(tbox);
                    tbox.Font = new Font("Digital-7", 10.0f, FontStyle.Regular);
                    tbox.Name = "tby" + (i * y2 + k).ToString();
                    tbox.Parent = groupBox2;
                    tbox.Text = (i * y2 + k).ToString();
                    tbox.SetBounds(10 + 30 * k, 20 + 25 * i, 25, 20);
                    tby[i * y2 + k] = tbox;
                }

            }

        }

        private bool initialAll()
        {
            bool donut = false;
            
            if (!(int.TryParse(textBox2.Text, out x1)) || !(int.TryParse(textBox3.Text, out y1))
                || !(int.TryParse(textBox4.Text, out x2)) || !(int.TryParse(textBox5.Text, out y2)))
            {
                label5.Text = " Matris boyutları hatalı!";
                label5.Visible = true;
            }
            else
            {
                groupBox1.Controls.Clear();
                groupBox2.Controls.Clear();
                groupBox3.Hide();

                groupBox1.Size = new Size(((y1 + 1) * 30) - 15, ((x1 + 1) * 25));
                groupBox1.Text = y1 > 3 ? "1.MATRIS" : "1";
                groupBox2.Size = new Size(((y2 + 1) * 30) - 15, ((x2 + 1) * 25));
                groupBox2.Text = y2 > 3 ? "2.MATRIS" : "2";

                int gen = groupBox1.Location.X + groupBox1.Size.Width + 50;
                groupBox1.Location = new Point(12, 287);
                groupBox2.Location = new Point(gen, 287);

                gen = groupBox2.Location.X + groupBox2.Size.Width + 35;
                int yukseklik = 0;
                yukseklik = groupBox1.Size.Height > groupBox2.Size.Height ?
                    groupBox1.Size.Height +350 : groupBox2.Size.Height + 350;
                gen = gen > 337 ? gen : 337;
                yukseklik = yukseklik > 500 ? yukseklik : 500;
                this.Size = new Size(gen, yukseklik);

                initialTextBox();
                donut = true;
            }

            return donut;
        }

        private void MatrisIslemleri( string s)
        {

            int boyut = x1 * y2;
            int[] tbx = new int[x1 * y1]; // 1. Matris değerleri
            int[] tby = new int[x2 * y2]; // 2. Matris değerleri
            List<int> tbz = new List<int>(); ; // Sonuç matrisi değerleri

            // 1 . Matris değerleri alınıyor
            groupBox1.Controls.OfType<TextBox>()
            .OrderBy(p => int.Parse(p.Name.Substring(3)))
            .Select((sonuc, index) => new { index, value = int.Parse(sonuc.Text) })
            .ToList()
            .ForEach(item => tbx[item.index] = item.value);

            // 2. Matris değerleri alınıyor
            groupBox2.Controls.OfType<TextBox>()
            .OrderBy(p => int.Parse(p.Name.Substring(3)))
            .Select((sonuc, index) => new { index, value = int.Parse(sonuc.Text) })
            .ToList()
            .ForEach(item => tby[item.index] = item.value);

            switch (s)
            {
                case "Topla": sutun = y1; tbz = MatrisTopla(tbx, tby); break;
                case "Carp": sutun = y2; tbz = MatrisCarp(tbx, tby); break;
                case "Cikar": sutun = y1; tbz = MatrisCikar(tbx, tby); break;
                case "Bol": sutun = x2; tbz = MatrisBol(tbx, tby); break;
                default:break;
            }

            ListViewInitialise(tbz);
        }

        private void ListViewInitialise(List<int> tbz)
        {
            int basamak = tbz.ToList().Max().ToString().Length;
            basamak = basamak < 3 ? 3 : basamak;
            int sizeX = sutun * (basamak * 12);
            int sizeY = x1 * 20;

            // Form size
            if (x1 > 11)
            {
                int t = groupBox2.Location.X + groupBox2.Size.Width;
                groupBox3.Location = new Point(t + 50, 20);
                groupBox3.Size = new Size(sizeX + 10, sizeY + 20);

                t = groupBox3.Location.X + groupBox3.Size.Width + 35;
                this.Size = new Size(t, this.Height);
            }
            else
            {
                groupBox3.Location = new Point(315, 20);
                groupBox3.Size = new Size(sizeX + 10, sizeY + 20);
                int t = groupBox3.Location.X + groupBox3.Size.Width + 35;
                this.Size = new Size(t, this.Height);
            }

            groupBox3.Controls.Clear();
            groupBox3.Text = sutun > 3 ? "SONUÇ" : "";

            // Boyutları ayarla
            listView1.Clear();
            listView1.Bounds = new Rectangle(new Point(5, 15), new Size(sizeX, sizeY));
            listView1.Font = new Font("Digital-7", 10.0f, FontStyle.Bold);
            listView1.Parent = groupBox3;

            // Sütunları oluştur
            for (int k = 0; k < sutun; k++)
            {
                listView1.Columns.Add("", listView1.Size.Width / sutun, HorizontalAlignment.Center);
            }

            listView1.HeaderStyle = ColumnHeaderStyle.None; // Sütun başlığı yok

            // Satırları oluştur
            for (int i = 0; i < x1; i++)
            {
                ListViewItem row = new ListViewItem(tbz[i * sutun].ToString());
                for (int k = 1; k < sutun; k++)
                {
                    row.SubItems.Add(tbz[i * sutun + k].ToString());
                }
                listView1.Items.Add(row);
            }

            listView1.GridLines = false;
            listView1.View = View.Details;
            
            groupBox3.Show();
            listView1.Visible = true;
        }
        
        private List<int> MatrisTopla(int[] tbx, int[] tby)
        {
            int boyut = x1 * y1; // Toplama işleminde matris boyutları aynı
            List<int> tbz = new List<int>(); // Sonuç matrisi değerleri
            int sonuc = 0;

            // Matris Toplam İşlemi
            for (int i = 0; i < boyut; i++)
            {
                sonuc = tbx[i] + tby[i];
                tbz.Add(sonuc);
            }

            return tbz;
        }

        private List<int> MatrisCikar(int[] tbx, int[] tby)
        {
            int boyut = x1 * y1; // Çıkarma işleminde matris boyutları aynı
            List<int> tbz = new List<int>(); // Sonuç matrisi değerleri
            int sonuc = 0;

            // Matris Çıkarma İşlemi
            for (int i = 0; i < boyut; i++)
            {
                sonuc = tbx[i] - tby[i];
                tbz.Add(sonuc);
            }

            return tbz;
        }

        private List<int> MatrisBol(int[] tbx, int[] tby)
        {
            // Ters çevrilmiş matrisin yeni boyutları
            int x3 = y2;
            int y3 = x2;
            sutun = y3;

            int boyut = x1 * y3;
            int result = 0;
            List<int> tbz = new List<int>(); // Sonuç matrisi değerleri
            int[] tby2 = new int[x3 * y3];

            // Matrisi ters çevirme işlemi (Bölme işlemi için gerekli)
            for (int i = 0; i < y2; i++)
            {
                for (int k = 0; k < x2; k++)
                {                    
                    tby2[k+(i * x2)] = tby[(i % y2) + y2 * k];
                }
            }

            // Çarpma İşlemi
            for (int i = 0; i < boyut; i++)
            {
                result = 0;

                for (int k = 0; k < x3; k++)
                {
                    result += tbx[(i / y3) * y1 + k] * tby2[(i % y3) + y3 * k];
                }

                tbz.Add(result);
            }
            return tbz;
        }

        private List<int> MatrisCarp(int[] tbx, int[] tby)
        {
            int boyut = x1 * y2;
            int result;
            List<int> tbz = new List<int>(); // Sonuç matrisi değerleri

            for (int i = 0; i < boyut; i++)
            {
                result = 0;

                for (int k = 0; k < x2; k++)
                {
                    result += tbx[(i / y2) * y1 + k] * tby[(i % y2) + y2 * k];
                }

                tbz.Add(result);                
            }

            return tbz;
        }


        private void btnCikar_Click(object sender, EventArgs e)
        {
            if ((x1 != x2) || (y1 != y2) || !matrisOK)
            {
                label5.Text = "Çıkarma işlemi için Matrislerin boyutları eşit olmalı!";
                label5.Visible = true;
            }
            else
                MatrisIslemleri("Cikar");
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if ((y1 != y2) || !matrisOK)
            {
                label5.Text = " Bölme işlemi için Matrislerin sütün sayıları eşit olmalı!";
                label5.Visible = true;
            }
            else
                MatrisIslemleri("Bol");
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            if ((y1 != x2) || !matrisOK)
            {
                label5.Text = " 1. Matris sütün sayısı 2. Matris satır sayısına eşit olmalı!";
                label5.Visible = true;
            }
            else
                MatrisIslemleri("Carp");
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            if ((x1 != x2) || (y1 != y2) || !matrisOK)
            {
                label5.Text = "Toplama işlemi için Matrislerin boyutları eşit olmalı!";
                label5.Visible = true;
            }
            else
                MatrisIslemleri("Topla");
        }

    }
}
