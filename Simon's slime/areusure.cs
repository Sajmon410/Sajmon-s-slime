using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectMoving
{
    public partial class areusure : Form
    {
        public areusure()
        {
            InitializeComponent();
        }

        private void areusure_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif",12);
            label3.Font = new Font("Microsoft Sans Serif", 12);
            label2.Location = new Point(ClientSize.Width / 2 - label2.Size.Width - 10, pictureBox1.Size.Height + label1.Size.Height + 20);
            label3.Location = new Point(ClientSize.Width / 2 + 10, pictureBox1.Size.Height + label1.Size.Height + 20);
            Formapp stara = new Formapp();
            stara.niz = stara.raz();
            stara.sad = stara.nik();
            Array.Sort(stara.niz);
            Array.Reverse(stara.niz);
            for (int i = 0; i < 10; i++)
            {
                string sa = "";
                string saa = "";
                if (i == stara.jot)
                {
                    sa = (i + 1).ToString() + ". " + stara.imena;
                    saa = stara.niz[i].ToString();
                }
                else
                {
                    sa = (i + 1).ToString() + ". " + stara.sad[i];
                    saa = stara.niz[i].ToString();
                }
                label2.Text += sa + "\n";
                label3.Text += saa + "\n";
            }
            label2.Location = new Point(ClientSize.Width / 2 - label2.Size.Width - 50, pictureBox1.Size.Height + label1.Size.Height + 20);
            label3.Location = new Point(ClientSize.Width / 2 + 50, pictureBox1.Size.Height + label1.Size.Height + 20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
