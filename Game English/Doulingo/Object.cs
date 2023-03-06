using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Reflection;

namespace Doulingo
{
    public partial class Object : Form
    {
        public Object()
        {
            InitializeComponent();
            Music_On.BackColor = Color.Transparent;
            Music_Off.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play R = new Play();

            R.ShowDialog();
            this.Close();
        }

        List<Image> img_5 = new List<Image>(5);
        List<Image> img_12 = new List<Image>();
        List<String> label_5 = new List<String>(5);
        List<String> label_12 = new List<String>(12);
        int sco, r, c = 0;

        SoundPlayer pl = new SoundPlayer();

        private bool check_image(List<Image> imgs, int num, int length)
        {
            for (int i = 0; i < length; i++)
                if (img_5[i] == img_12[num])
                {
                    return false;
                }
            return true;
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doulingo D = new Doulingo();

            D.ShowDialog();
            this.Close();
        }

        private void Music_On_Click(object sender, EventArgs e)
        {
            pl.SoundLocation = @".\Duolingo.wav";
            pl.Load();
            pl.PlayLooping();
        }

        private void Music_Off_Click(object sender, EventArgs e)
        {
            pl.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (int.Parse(countdown.Text) != 0)
            {
                int futureText = int.Parse(countdown.Text) - 1;
                countdown.Text = futureText.ToString();
            }
            else
            {
                timer1.Stop();
                result_Click(sender, new EventArgs());
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            string dir = @".\o\";
            foreach (var myFile in Directory.GetFiles(dir, "*.jpg", SearchOption.AllDirectories))
            {
                img_12.Add(Image.FromFile(myFile));
                label_12.Add(Path.GetFileNameWithoutExtension(myFile));
            }
            int i = 0;
            img_5.Clear();
            Random rand = new Random();
            while (i < 5)
            {
                int num = rand.Next(0, 12);
                if (check_image(img_5, num, img_5.Count()))
                {
                    img_5.Add(img_12[num]);
                    label_5.Add(label_12[num]);
                    i++;
                }
            }

            pictureBox1.BackgroundImage = img_5[0];
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Tag = label_5[0];
        }


        private void result_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower().Trim() == pictureBox1.Tag.ToString().ToLower().Trim())
            {
                MessageBox.Show("Nice!!!");
                textBox1.Text = string.Empty;
                sco += 2;
                Point_txt.Text = $"{sco}";
                countdown.Text = "30";
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Nicetry!");
                textBox1.Text = string.Empty;
                countdown.Text = "30";
                timer1.Start();
            }

            c += 1;
            if (c == 5)
            {
                c += 1;
                MessageBox.Show("Game over ! \n Your point: " + sco.ToString());
                string final_point = sco.ToString();
                string result_path = @"./result.txt";
                using (StreamWriter sw = File.AppendText(result_path))
                {
                    sw.WriteLine(final_point);
                }
                timer1.Stop();
                Close();
            }
            else
            {
                pictureBox1.Image = img_5[c];
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
                pictureBox1.Tag = label_5[c];
            }
            r += 1;
            Right_txt.Text = $"{r}/5";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                result_Click(sender, new EventArgs());
            }
        }
    }
}
