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
using System.Security.Cryptography;


namespace Doulingo
{
    public partial class Play : Form
    {
        public Play()
        {
            InitializeComponent();
            Music_On.BackColor = Color.Transparent;
            Music_Off.BackColor = Color.Transparent;
        }

        private void Play_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form3 F = new Form3();

            F.ShowDialog();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doulingo D = new Doulingo();

            D.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            Fruit F = new Fruit();

            F.ShowDialog();
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            Object F = new Object();

            F.ShowDialog();
            this.Close();
        }

        SoundPlayer pl = new SoundPlayer();

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
    }
}
