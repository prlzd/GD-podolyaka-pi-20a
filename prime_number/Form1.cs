using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prime_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            textBox2.Text = "";
            int n = -1;      
            try
            {                  
                n = Convert.ToInt32(textBox1.Text);                 
            }
            catch (FormatException)
            {
                label4.Visible = true;                    
            }
            if (n < 0)
            {
                label4.Visible = true;               
            }
            else
                prime(n);
        }

        void prime(int N)
        {
            int n = 1000;
            int k = 0;
            int len = n + 1;
            int[] primes = new int[len];
            var prim = new List<int>();
            
            for (int i = 0; i < len; i++)
                primes[i] = i;

            for (int i = 2; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (primes[j] == 0)
                        continue;
                    if (j % i == 0)
                    {
                        primes[j] = 0;
                        continue;
                    }
                }
            }
            for (int i = 0; i < len; i++)
            {
                if (primes[i] != 0 && k<N+1 )
                {
                    k++;
                    textBox2.Text = primes[i].ToString();
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        

