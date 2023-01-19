using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectMoving
{
    public partial class entername : Form
    {
        public entername()
        {
            InitializeComponent();
        }
        public int sicko = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Wrong name! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.Close();
                sicko = 1;
            }
        }

        private void entername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Wrong name! Try again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    this.Close();
                    sicko = 1;
                }
            }
        }
    }
}
