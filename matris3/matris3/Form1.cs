using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic; // 

namespace matris3
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, n; 
            double kupler, kareler;
            string matris_view;
            // çift indeksli i = 1 ve j = 1 , matris[i,j] küpü alınır çünkü i + j = 2 dir
            n = Convert.ToInt32(textBox1.Text);
            int[,] matris = new int[n+1, n+1];
            
            kareler = 0;
            kupler= 0;

            for (i = 1; i <= n; i++)
            {
                matris_view = "";
                for (j = 1; j <= n; j++)
                {
                    matris[i, j] = Convert.ToInt32(Interaction.InputBox($"[{i},{j}] giriniz", "baslik", "", 100, 100));
                    
                    if ((i + j) % 2 == 0)
                    {
                        kupler += Math.Pow(matris[i, j], 3);
                    }
                    else
                    {
                        kareler += Math.Pow(matris[i, j], 2);                        
                        
                    }
                    matris_view += $"{matris[i, j]} ";
                }
                listBox1.Items.Add($"{matris_view} ");
            }
            textBox2.Text = $"{kupler} çiftlerin küpü, {kareler} teklerin karesi";
        }
    }
}
