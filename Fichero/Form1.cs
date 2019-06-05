using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fichero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seg100 = 100;
        int seg50 = 50;
        int seg25 = 25;
        
         
        private void timer1_Tick(object sender, EventArgs e)
        {            

            seg100--;
            Lbcont.Text = Convert.ToString(seg100);

            if (seg100 == 10)
            {
                MessageBox.Show("Ingresar otra moneda");
            }

        }

        private void btnq1_Click(object sender, EventArgs e)
        {
            
            tim100.Start();
           
            
        }

        private void Lbcont_Click(object sender, EventArgs e)
        {
         
        }

        private void tim50_Tick(object sender, EventArgs e)
        {
           
            seg50--;
            Lbcont.Text = Convert.ToString(seg50);

            if (seg50 == 10)
            {
                MessageBox.Show("Ingresar otra moneda");
            }

        }

        private void tim25_Tick(object sender, EventArgs e)
        {

            seg25--;
            Lbcont.Text = Convert.ToString(seg25);

            if (seg25 == 10)
            {
                MessageBox.Show("Ingresar otra moneda");
            }
        }

        private void btnq05_Click(object sender, EventArgs e)
        {
            tim50.Start();
        }

        private void btnq025_Click(object sender, EventArgs e)
        {
            tim25.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncolgar_Click(object sender, EventArgs e)
        {
            
            Lbcont.Text = "0";
            tim100.Stop();
            //seg100 = 100;

            tim50.Stop();

            tim25.Stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
