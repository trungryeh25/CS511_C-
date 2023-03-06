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
    public partial class Doulingo : Form
    {
        public Doulingo()
        {
            InitializeComponent();
            Music_On.BackColor = Color.Transparent;
            Music_Off.BackColor = Color.Transparent;
        }

        SoundPlayer pl = new SoundPlayer();


        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            this.Hide();
            Play M = new Play();

            M.ShowDialog();
            this.Close();
        }

        private void Doulingo_Load(object sender, EventArgs e)
        {

        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ranking R = new Ranking();

            R.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 S = new Form4();

            S.ShowDialog();
            this.Close();
        }

        private void Music_Off_Click(object sender, EventArgs e)
        {
            pl.Stop();
        }

        private void Music_On_Click(object sender, EventArgs e)
        {
            pl.SoundLocation = @".\Duolingo.wav";
            pl.Load();
            pl.PlayLooping();
        }
    }
}
