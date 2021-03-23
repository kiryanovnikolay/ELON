using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELON
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }
        int click = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            click = click + 1;
            label2.Text = "BLANT: " + click; 
            if (click >= 20)
            {
                MessageBox.Show("GOD JOB DUDE");
                    Close();
            }
        }
    }
}
