using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
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

        private void WhenClicked(object sender, EventArgs e)
        {
            textBox6.Text = "\n";
            Color g;
            Color r;
            g = Color.Green;
            r = Color.Red;
            Random objrandom = new Random();
            int rand = objrandom.Next(1, 20);
            if (rand == 1 || rand == 13 || rand == 14 || rand == 18 || rand == 20)
            {                
                textBox6.Text = "You are Winner";
                textBox6.ForeColor = g;
            }
            else
            {              
                textBox6.Text = "You are Loser";
                textBox6.ForeColor = r;
            }
            
        }
    }
}
