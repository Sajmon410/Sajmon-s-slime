using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObjectMoving
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Formapp druga = new Formapp();
            druga.ShowDialog();
            druga.timeleft.Start();
            druga.timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            howtoplay treca = new howtoplay();
            treca.ShowDialog();
        }
        private void FormView_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            areusure cet = new areusure();
            cet.ShowDialog();
        }
    }
}
