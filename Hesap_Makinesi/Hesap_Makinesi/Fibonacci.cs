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
    public partial class Fibonacci : Form
    {
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int terimSayisi;
            object[] fibonacci;

            listBox1.Items.Clear();
            label2.Visible = false;
            
            if (int.TryParse(textBox1.Text, out terimSayisi))
            {
                terimSayisi = terimSayisi > 138 ? 138 : terimSayisi; // max 138 terim hesaplanıyor

            }

            if (terimSayisi > 2)
            {
                fibonacci = new object[terimSayisi];
                fibonacci[0] = fibonacci[1] = 1;

                for (int i = 2; i < terimSayisi; i++)
                {
                    fibonacci[i] = (object)(Convert.ToDecimal(fibonacci[i - 1]) + Convert.ToDecimal(fibonacci[i - 2]));
                }

                listBox1.Items.AddRange(fibonacci);
            }
            else
                label2.Visible = true;

            ActiveControl = textBox1;
        }

        private void Fibonacci_Load(object sender, EventArgs e)
        {
            AcceptButton = button1;
            CancelButton = button2;
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Visible = false;
        }
    }
}
