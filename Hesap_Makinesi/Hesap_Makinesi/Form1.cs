using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Hesap_Makinesi
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int parantez = 0; // Açılan işlem parantez sayısı değişkeni
        string sonIslem = string.Empty; // bir önceki matematiksel işlem
        string islem = string.Empty; // güncel matematiksel işlem
        string yazi = string.Empty; // güncel matematiksel işlem butonu text 'i
        string deger = string.Empty;// matematiksel işlem dizini
        
        private void Form1_Load(object sender, EventArgs e)
        {            
            textBox1.Text = "0";
            textBox2.Text = " ";
            label4.Text = " "; // Açılan işlem parantez sayısını gösterir
            ActiveControl = null; 
        }

        private void AnaFonksiyon(object sender, EventArgs e)
        {
            if (e.ToString().Equals("System.EventArgs")) // MouseEventArgs or Keyboard
            {
                islem = "btnEqual";
                yazi = "=";
            }
            else
            {
                islem = ((Button)sender).Name;
                yazi = ((Button)sender).Text;
            }

            if (textBox1.Text.Equals("TANIMSIZ")) textBox1.Text = "0";
            else if (textBox1.Text.Equals("HATALI ISLEM") || textBox1.Text == "KAPASITE DOLDU")
            {
                textBox2.Text = " ";
                textBox1.Text = "0";
            }

            switch (islem)
            {                
                case "btn0": case "btn1": case "btn2": case "btn3": case "btn4": case "btn5": 
                case "btn6": case "btn7": case "btn8": case "btn9": BtnNumara(); break;

                case "btnEqual": case "btnDiv":  case "btnMul":  case "btnSub":  case "btnAdd":
                case "btnMod": BtnIslem(); break; 

                case "btnCe": textBox1.Text = "0"; break;
                case "btnC": textBox1.Text = "0"; textBox2.Text = " "; break;

                case "btnLeft": case "btnRight": BtnLeftRight(); break;

                case "btnSign": BtnSign(); break;

                case "btnFact": case "btnKk": case "btnX2": case "btnLog": case "btnSin": case "btnCos":
                case "btnTan": BtnModuler(); break;

                case "btnComma": textBox1.Text = textBox1.Text.VirgulEkle(); break;//textBox1.Text = textBox1.Text.CommaOrString(); break;

                case "btnErase": BtnEraser(); break;

                case "btnFibonacci": textBox1.Text = "0"; textBox2.Text = " "; BtnFibonacci(); break;
                case "btnMatris": textBox1.Text = "0"; textBox2.Text = " "; BtnMatris(); break;

            } // switch ...

            sonIslem = islem;
      
        }

        public void BtnMatris()
        {
            Matris frmMatris = new Matris();
            frmMatris.ShowDialog();
        }
        public void BtnFibonacci()
        {
            Fibonacci frmFibonacci = new Fibonacci();
            frmFibonacci.ShowDialog();
        }

        public double Factorial(int number)
        {
            if (number < 2)
                return 1;
            else
                return number * Factorial(number - 1);
        }
  
        public void BtnEraser()
        {
            if (textBox1.Text.Equals("-0,") || textBox1.Text.Equals("-"))
            {
                textBox1.Text = "0";
            }
            else
            textBox1.Text = textBox1.Text.Length > 1 ?
                        textBox1.Text.Remove(textBox1.Text.Length - 1) : "0";
        }
        private void BtnModuler()
        {
            char item = textBox2.Text.Last(); // son işlemi değiştirebilmek için           
            bool negatif = textBox1.Text.First().Equals('-') ? true : false;// negatif sayıları ayırmak için

            if (!(item.Equals(')') || item.Equals(']'))) // kapalı parantezden sonra işlem gerekir
            {
                if (islem.Equals("btnFact")) // Faktöriyel Fonksiyonu
                {
                    if (negatif) textBox1.Text = "TANIMSIZ";// negatif sayıların faktöriyeli hesaplanmıyor
                    else
                    {
                        string[] reel = textBox1.Text.Split(','); // Pozitif doğal sayıların faktöriyeli
                        deger += Factorial(int.Parse(reel[0])).ToString();
                        textBox2.Text += "fact(" + textBox1.Text + ")";
                    }
                }
                else if (islem.Equals("btnKk")) // Karekök Fonksiyonu
                {
                    if (negatif) textBox1.Text = "TANIMSIZ";// negatif sayıların karekökü hesaplanmıyor
                    else
                    {
                        deger += Math.Sqrt(textBox1.Text.ToDouble()).ToString().Replace(',', '.');
                        textBox2.Text += "√(" + textBox1.Text + ")";
                    }
                }
                else if (islem.Equals("btnX2")) // Karesi Fonksiyonu
                {
                    double d = textBox1.Text.ToDouble();
                    deger += (d * d).ToString();

                    if (negatif)
                        textBox2.Text += "sqr(" + "neg(" + textBox1.Text.Remove(0, 1) + ")" + ")";
                    else
                        textBox2.Text += "sqr(" + textBox1.Text + ")";
                }
                else if (islem.Equals("btnSin")) // Sinüs Fonksiyonu
                {
                    double angle = Math.PI * textBox1.Text.ToDouble() / 180.0;
                    deger += Math.Sin(angle).ToString().Replace(',', '.');

                    if (negatif)
                        textBox2.Text += "sin(" + "neg(" + textBox1.Text.Remove(0, 1) + ")" + ")";
                    else
                        textBox2.Text += "sin(" + textBox1.Text + ")";
                }
                else if (islem.Equals("btnCos")) // Cosinüs Fonksiyonu
                {
                    double angle = Math.PI * textBox1.Text.ToDouble() / 180.0;
                    deger += Math.Cos(angle).ToString().Replace(',', '.');

                    if (negatif)
                        textBox2.Text += "cos(" + "neg(" + textBox1.Text.Remove(0, 1) + ")" + ")";
                    else
                        textBox2.Text += "cos(" + textBox1.Text + ")";
                }
                else if (islem.Equals("btnTan")) // Tanjant Fonksiyonu
                {
                    double angle = Math.PI * textBox1.Text.ToDouble() / 180.0;
                    deger += Math.Tan(angle).ToString().Replace(',', '.');

                    if (negatif)
                        textBox2.Text += "tan(" + "neg(" + textBox1.Text.Remove(0, 1) + ")" + ")";
                    else
                        textBox2.Text += "tan(" + textBox1.Text + ")";
                }
                else if (islem.Equals("btnLog"))// Logaritma Fonksiyonu (10 tabanında)
                {

                    if (negatif) textBox1.Text = "TANIMSIZ";// negatif sayıların logaritması hesaplanmıyor
                    else
                    {
                        deger += Math.Log10(textBox1.Text.ToDouble()).ToString().Replace(',','.');
                        textBox2.Text += "log(" + textBox1.Text + ")";
                    }
                }

            } //  if (!item.Equals(')'))...
        }
        private void BtnEqual()
        {
            bool negatif = textBox1.Text.First().Equals('-') ? true : false;// negatif sayıları ayırmak için
            char item = textBox2.Text.Last();

            if (!deger.Equals(value: ""))
            {


                if (item.Equals('/') || item.Equals('x') || item.Equals('-')
                    || item.Equals('+') || item.Equals('%'))
                {
                    deger += textBox1.Text;
                    textBox2.Text += negatif ? "neg(" + textBox1.Text.Remove(0, 1) + ")" : textBox1.Text;
                }

                deger = deger.Replace(',', '.'); // İşlem yaparken ondalık sayıların ayracını nokta olarak kullanıyoruz

                try
                {
                    DataTable dt = new DataTable();
                    var result = dt.Compute(deger, ""); 
                    string sayi = result.ToString().Length > 13 ? result.ToString().Substring(0, 14) : result.ToString();
                    if (sayi.Last().Equals(','))
                        textBox1.Text = "KAPASITE DOLDU";
                    else
                    {
                        textBox2.Text = " ";
                        deger = "";
                        textBox1.Text = sayi;
                    }
                }
                catch (Exception)
                {
                    textBox1.Text = "HATALI ISLEM";
                }
            }
        }

        private void BtnSign() // Negatif işaretleme Fonksiyonu
        {
            if (textBox1.Text.Equals("0")) textBox1.Text = "-";
            else if (textBox1.Text.First().Equals('-')) textBox1.Text = textBox1.Text.Remove(0, 1);
            else
                textBox1.Text = textBox1.Text.Insert(0, "-");
        }

        private void BtnNumara([Optional, DefaultParameterValue("yok")] string s) // Rakam Giriş Fonksiyonu
        {
            if (sonIslem.Equals("btnEqual")) // Ekranı temizlemek için
            {
                textBox1.Text = "0"; textBox2.Text = " ";
            }
                    
            if (!s.Equals("yok")) yazi = s; // Klavye girişi
                
            textBox1.Text = textBox1.Text.Equals("0") ? yazi : textBox1.Text + yazi;            
        }
        private void BtnIslem([Optional, DefaultParameterValue("yok")] string s) // Dört işlem ve Mod işlemi Fonksiyonu
        {
            if (s.Equals("Enter"))
            {
                yazi = "="; islem = "btnEqual";
            }
            else if (s.Equals("*")) yazi = "x";
            else if (!s.Equals("yok")) yazi = s;
                             
            bool negatif = textBox1.Text.First().Equals('-') ? true : false;// negatif sayıları ayırmak için
            int boyut = textBox2.Text.Length - 1;
            char item = textBox2.Text.Last();

            string deger_yazi = yazi; // deger_yazi matematiksel ifadede kullanılacak string
            if (yazi.Equals("mod"))
            {
             yazi = deger_yazi = "%";
            }
            else if (yazi.Equals("x")) deger_yazi = "*";

            if ( (sonIslem.Equals("btnDiv") || sonIslem.Equals("btnMul") || sonIslem.Equals("btnSub") 
                || sonIslem.Equals("btnAdd") || sonIslem.Equals("btnMod") ) && !(islem.Equals("btnEqual")) )
            {
                textBox2.Text = textBox2.Text.Remove(boyut, 1); deger = deger.Remove(deger.Length - 1, 1);
                textBox2.Text = textBox2.Text.Insert(boyut, yazi); deger = deger.Insert(deger.Length, deger_yazi);
            }
            else if ((item.Equals(')') || item.Equals(']')) && !islem.Equals("btnEqual"))
            {
                deger += deger_yazi;
                textBox2.Text += yazi;
            }
            else if (islem.Equals("btnEqual")) // Eşittir Butonu Fonksiyonu çağrı noktası
            {
                BtnEqual();
            }
            else
            {
                deger += textBox1.Text + deger_yazi;
                textBox2.Text += negatif ?
                    "neg(" + textBox1.Text.Remove(0, 1) + ")" + yazi : textBox1.Text + yazi;               
            }

        }

        private void BtnLeftRight() // Parantez Fonksiyonu
        {        
            if (islem.Equals("btnLeft") && !(textBox2.Text.Last().Equals(')') || textBox2.Text.Last().Equals(']')))
            {
                textBox2.Text = textBox2.Text.Equals(" ") ? "[" : textBox2.Text + "[";
                label4.Text = (++parantez).ToString();
                deger += "(";
            }
            else //btnRight 
            {
                if (parantez > 0)
                {
                    label4.Text = --parantez > 0 ? parantez.ToString() : " ";
                    if (textBox2.Text.Last().Equals(']') || textBox2.Text.Last().Equals(')'))
                    {
                        deger += ")";
                        textBox2.Text += "]";
                    }
                    else
                    {
                        deger += textBox1.Text + ")";
                        textBox2.Text += textBox1.Text.First().Equals('-') ? "neg(" + textBox1.Text.Remove(0, 1) + ")" + "]" : textBox1.Text + "]";
                    }
                }
            }
        }

        // TextBox 'lar içinde cursor un yanıp sönmemesi için
        private void textBox1_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).Enabled = false;
            ((TextBox)sender).Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            if (textBox2.Text.Equals(" "))
            {
                deger = ""; parantez = 0; label4.Text = " ";
            }

        }

        protected override bool ProcessDialogChar(char charCode) // Overridden instead of KeyPress method
        {
            string key = "";
            if (textBox1.Text.Equals("TANIMSIZ")) textBox1.Text = "0";
            else if (textBox1.Text.Equals("HATALI ISLEM") || textBox1.Text == "KAPASITE DOLDU")
            {
                textBox2.Text = " ";
                textBox1.Text = "0";
            }

            switch ((int)charCode)
            {
                case 8: BtnEraser(); sonIslem = "btnErase"; break;// Backspace (erase);

                case 13:  case 42:  case 43:  case 45:  case 47: // Dört işlem ve eşittir
                    if ((int)charCode == 13)
                    {
                        key = "Enter"; islem = "btnEqual";
                    }
                    else
                    {
                        key = charCode.ToString(); islem = "btnAdd";
                    }
                    BtnIslem(key); sonIslem = key.Equals("Enter") ? "btnEqual" : "btnAdd"; break;

                case 27: textBox1.Text = "0"; textBox2.Text = " "; sonIslem = "btnC"; break;// btnCe;

                case 44: textBox1.Text = textBox1.Text.VirgulEkle(); sonIslem = "btnComma"; break;// AnaFonksiyon ilgili case;

                case 48: case 49: case 50:  case 51:  case 52:  case 53:  case 54:  case 55: case 56:
                case 57: BtnNumara(charCode.ToString()); sonIslem = "btn5"; break; // 0-9 Rakam girişleri

            }
            return true;
        }


    }
}
