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

namespace matris4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k, n, m;
            string satir1, satir2, satir3;

            string[] ls_str = textBox1.Text.Split(' ');
            int[] ls = new int[ls_str.Length];

            for (i = 0; i < ls_str.Length; i++)
            {
                if (int.TryParse(ls_str[i], out int sayi))
                {
                    ls[i] = sayi;
                }
                else
                {
                    MessageBox.Show("Doğru Griniz");
                }
            }
            n = ls[0]; m = ls[1];

            int[,] matris = new int[n + 1, m + 1];
            int[,] matris2 = new int[n + 1, m + 1];
            int[,] matris_total = new int[n + 1, m + 1];


            for (i = 1; i <= n; i++)
            {
                satir1 = "";satir2 = "";satir3 = "";
                for (j = 1; j <= m; j++)
                {
                    matris[i, j] = Convert.ToInt32(Interaction.InputBox($"1.matris için [{i},{j}] :", "hesaplama", "", 100, 100));
                    matris2[i, j] = Convert.ToInt32(Interaction.InputBox($"2.matris için [{i},{j}] :", "hesaplama", "", 100, 100));

                    matris_total[i, j] = matris[i, j] + matris2[i, j];
                    satir1 += $"{matris[i, j]} ";
                    satir2 += $"{matris2[i, j]} ";
                    satir3 += $"{matris_total[i, j]} ";
                }

                listBox1.Items.Add(satir1);
                listBox2.Items.Add(satir2);
                listBox3.Items.Add(satir3);
            }
        }
    }
}
