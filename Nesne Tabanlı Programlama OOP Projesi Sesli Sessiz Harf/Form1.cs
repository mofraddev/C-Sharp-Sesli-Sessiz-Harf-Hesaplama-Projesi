using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesne_Tabanlı_Programlama_OOP_Projesi_Sesli_Sessiz_Harf
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
            char[] sesli = { 'a', 'e', 'i', 'ı', 'o', 'ö', 'u', 'ü', 'A', 'E', 'İ', 'I', 'O', 'Ö', 'U', 'Ü' };
            int sessiz_harf = 0;
            int sesli_harf = 0;
            int z = 0;
            string kelime = textBox1.Text;
            foreach (char harf in kelime)
            {
                z = 0;
                for (int i = 0; i < sesli.Length; i++)
                {
                    if (sesli[i] == harf)
                    {
                        z++;
                        sesli_harf++;
                    }
                }
                if (z == 0)
                {
                    sessiz_harf++;
                }
            }
            label4.Text = sessiz_harf.ToString();
            label5.Text = sesli_harf.ToString();
        }
    }
}
