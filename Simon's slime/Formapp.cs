using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Reflection;

namespace ObjectMoving
{
    public partial class Formapp : Form
    {

        Random r = new Random();
        SoundPlayer zika = new SoundPlayer("nice.wav");
        SoundPlayer eat = new SoundPlayer("eat.wav");
        SoundPlayer poison = new SoundPlayer("poison.wav");
        int s = 60;
        int sc = 0;
        public int[] niz = new int[20];
        public string[] sad = new string[20];
        public string imena;
        public Formapp()
        {
            InitializeComponent();
       
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                pictureBox2.Location = new Point(r.Next(1, 400), r.Next(30, 400));
                sc++;
                label2.Text = sc.ToString();
                label2.ForeColor = Color.Black;
                eat.Play();
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox5.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox6.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox7.Bounds) || pictureBox2.Bounds.IntersectsWith(pictureBox8.Bounds))
            {
                pictureBox2.Location = new Point(r.Next(1, 400), r.Next(30, 400));   
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                pictureBox3.Location = new Point(r.Next(1, 400), r.Next(30, 400));
                sc=sc-3;
                label2.Text = sc.ToString();
                label2.ForeColor = Color.Red;
                poison.Play();
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))
            {

                pictureBox4.Location = new Point(r.Next(1, 400), r.Next(30, 400));
                sc = sc - 3;
                label2.Text = sc.ToString();
                label2.ForeColor = Color.Red;
                poison.Play();
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox5.Bounds))
            {

                pictureBox5.Location = new Point(r.Next(1, 400), r.Next(30, 400));
                sc = sc - 3;
                label2.Text = sc.ToString();
                label2.ForeColor = Color.Red;
                poison.Play();
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox6.Bounds))
            {

                pictureBox6.Location = new Point(r.Next(1, 400), r.Next(30, 400));
                sc = sc - 3;
                label2.Text = sc.ToString();
                label2.ForeColor = Color.Red;
                poison.Play();
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox7.Bounds))
            {

                pictureBox7.Location = new Point(r.Next(1, 400), r.Next(30, 400));
                sc = sc - 3;
                label2.Text = sc.ToString();
                label2.ForeColor = Color.Red;
                poison.Play();
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox8.Bounds))
            {

                pictureBox8.Location = new Point(r.Next(1, 400), r.Next(30, 400));
                sc = sc - 3;
                label2.Text = sc.ToString();
                label2.ForeColor = Color.Red;
                poison.Play();
            }
            ogr(pictureBox1);
        }
        private void timeleft_Tick(object sender, EventArgs e)
        {
            s--;
            label4.Text = s.ToString();
            if (s == 0)
            {
                timer1.Enabled = false;
                timeleft.Enabled = false;
                label5.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label6.Visible = true;
                label7.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                label8.Visible = true;
                label7.Text = label2.Text;
                upis();
            }
            if (s == 50)
            {
                pictureBox3.Visible = true;
                pictureBox3.Location = new Point(r.Next(1, 400), r.Next(30, 400));
            }
            if (s == 40)
            {
                pictureBox4.Visible = true;
                pictureBox4.Location = new Point(r.Next(1, 400), r.Next(30, 400));
            }
            if (s == 35)
            {
                pictureBox5.Visible = true; 
                pictureBox5.Location = new Point(r.Next(1, 400), r.Next(30, 400));
            }
            if (s == 25)
            {
                pictureBox6.Visible = true;
                pictureBox6.Location = new Point(r.Next(1, 400), r.Next(30, 400));
            }
            if (s == 15)
            {
                pictureBox7.Visible = true;
                pictureBox7.Location = new Point(r.Next(1, 400), r.Next(30, 400));
            }
            if (s == 10)
            {
                pictureBox8.Visible = true;
                pictureBox8.Location = new Point(r.Next(1, 400), r.Next(30, 400));
            }
            if (s == 10)
            {
                label4.ForeColor = Color.Red;
            }
        }
        private void Formapp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -=20;
            }
            else if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 20;
            }
            else if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= 20;
            }
            else if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 20;
            }
        }

        private void Formapp_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            
            
        }
        private void Formapp_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Top = 535;
            this.Height = 507;
            this.Width = 535;
        }
        void ogr(PictureBox picutreBox1)
        {
            if (picutreBox1.Left > ClientSize.Width - picutreBox1.Size.Width)
                picutreBox1.Left = ClientSize.Width - picutreBox1.Size.Width;
            if (picutreBox1.Left < 10)
                picutreBox1.Left = 10;
            if (picutreBox1.Top > ClientSize.Height - picutreBox1.Size.Height)
                picutreBox1.Top = ClientSize.Height - picutreBox1.Size.Height;
            if (picutreBox1.Top < 35)
                picutreBox1.Top = 35;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string[] nik()
        {
            string[] sa = new string[11];
            int i = 0;
            using (StreamReader reader = new StreamReader("TOP10.txt"))
            {
                string s = reader.ReadLine();
                char c = ',';
                while (s != null)
                {
                    if (i == 9)
                    {
                        int n = s.LastIndexOf(c);
                        string a = s.Substring(4, n - 4);
                        sa[i] = a;
                        s = reader.ReadLine();
                        i++;
                    }
                    else
                    {
                        int n = s.LastIndexOf(c);
                        string a = s.Substring(3, n - 3);
                        sa[i] = a;
                        s = reader.ReadLine();
                        i++;
                    }
                }
            }
            return sa;
        }
        public int[] raz()
        {
            int[] raz = new int[11];
            int i = 0;
            using (StreamReader reader = new StreamReader("TOP10.txt"))
            {
                string s = reader.ReadLine();
                char c = ',';
                while (s != null)
                {
                    int n = s.LastIndexOf(c);
                    string a = s.Substring(n + 1, 3);
                    raz[i] = Convert.ToInt32(a);
                    s = reader.ReadLine();
                    i++;
                }
            }
            return raz;
        }
        public int jot = 11;
        void upis()
        {
            
                niz = raz();
                niz[10] = sc;
                sad = nik();
                Array.Sort(niz);
                Array.Reverse(niz);
                for (int o = 0; o < 10; o++)
                {
                    if (niz[o] == sc)
                        jot = o;
                }
                entername pet = new entername();
                pet.ShowDialog();
                if (pet.sicko == 1)
                    imena = pet.textBox1.Text;
                string name = "TOP10.txt";
                using (StreamWriter sr = new StreamWriter(name, false))
                {
                    int jo = 0;
                    for (int o = 0; o < 10; o++)
                    {
                        if (o == jot)

                            sr.WriteLine((o + 1).ToString() + ". " + imena + "," + niz[o].ToString("000"));

                        else
                        {
                            sr.WriteLine((o + 1).ToString() + ". " + sad[jo] + "," + niz[o].ToString("000"));
                            jo++;
                        }
                        
                    }
                    sr.Close();
                }
            
        }
    }
}
