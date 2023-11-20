using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] ls_str = textBox1.Text.Split(' ');
            int[] ls = new int[ls_str.Length];


            for (int i = 0; i < ls_str.Length; i++)
            {
                if (int.TryParse(ls_str[i], out int sayi))
                {
                    ls[i] = sayi;
                }
                else
                {
                    MessageBox.Show("Geçersiz Sayı!");
                    return;
                }
            }

            int toplam = 0;
            foreach (int i in ls)
            {
                toplam += i;

                
            }

            label2.Text = toplam.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
