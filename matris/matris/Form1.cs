using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace matris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /**
         * 
         * İlk Soru Tamamlandı 
         * (1- n*n li matrix in köşegenlerinin toplamınu bulan c# programını yazınız)
        **/
        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, n, total;
            total = 0;
            n = Convert.ToInt32(textBox1.Text);
            int[,] matris = new int[n+1,n+1]; // 2D yani matrix [,] koyulduğunda kastımız budur
            for (i = 1; i <= n; i++)
            {                
                for (j = 1; j <= n; j++)
                {
                    matris[i, j] = Convert.ToInt32(Interaction.InputBox($"[{i},{j}] giriniz","Matris Giriniz :","",100,100));
                    if (i == j)
                    {
                        total += matris[i,j];
                    }
                }
            }
            richTextBox1.Text = total.ToString();
        }
    }
}
