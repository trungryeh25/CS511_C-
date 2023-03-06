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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            Music_On.BackColor = Color.Transparent;
            Music_Off.BackColor = Color.Transparent;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doulingo D = new Doulingo();

            D.ShowDialog();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
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
