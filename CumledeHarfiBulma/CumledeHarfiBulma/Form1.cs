using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CumledeHarfiBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.ToLower();
       
            char letter = Convert.ToChar(textBox2.Text.ToLower());

            int i=0;

            foreach (char item in text)
            {
              
                if(item==letter)
                {
                    i++;
                    lblResult.Text = i + " adet";
                }
            }
           
        }
    }
}
