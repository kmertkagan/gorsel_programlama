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

namespace matrix5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            string[] ls_str = textBox1.Text.Split(",");
            int[] ls = new int[ls_str.Length];

            for (i = 0; i < ls_str.Length; i++)
            {
                if (int.TryParse(ls_str[i], out int result))
                {
                    ls[i] = result;
                }
            }

            string satir1, satir2;

            int n, m;
            n = ls[0]; m = ls[1];
            int[,] matris = new int[n + 1, m + 1];
            int[,] transpoze = new int[m + 1, n + 1];

            for (i = 1; i <= n; i++)
            {
                satir1 = "";
                for (j = 1; j <= m; j++)
                {
                    matris[i, j] = Convert.ToInt32(Interaction.InputBox($"[{i},{j}] giriniz", "hesaplama", "", 100, 100));
                    satir1 += $"{matris[i, j]} ";               
                }
                listBox1.Items.Add(satir1);
            }
            for (i = 1; i <= m; i++)
            {
                satir2 = "";
                for (j = 1; j <= n; j++)
                {
                    transpoze[i, j] = matris[j, i];
                    satir2 += $"{transpoze[i, j]} ";

                }
                listBox3.Items.Add(satir2);
            }
        }
    }
}
