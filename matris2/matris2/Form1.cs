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

namespace matris2
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i, j, total_2satir, total_3sutun;
            total_2satir = 0;
            total_3sutun = 0;
            n = Convert.ToInt32(textBox1.Text);
            string matris_view;
            int[,] matris = new int[n + 1, n + 1];
            for (i = 1; i <= n; i++)
            {
                matris_view = "[";
                for (j = 1; j <= n; j++)
                {
                    matris[i, j] = Convert.ToInt32(Interaction.InputBox($"[{i},{j}] giriniz", "baslik", "", 100, 100));
                    if (i == 2)
                    {
                        total_2satir += matris[i, j]; 
                    }
                    if (j == 3)
                    {
                        total_3sutun += matris[i, j];
                    }
                    matris_view += $"{matris[i,j]}  ";
                }
                listBox1.Items.Add(matris_view + "]" );
            }
            textBox2.Text = $"{total_2satir} 2.satır toplamı, {total_3sutun} 3.sütun toplamı ; {total_2satir + total_3sutun} ikisinin de toplamı";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
