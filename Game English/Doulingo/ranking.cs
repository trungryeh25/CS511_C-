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



namespace Doulingo
{
    public partial class Ranking : Form
    {
        public Ranking()
        {
            InitializeComponent();
            Music_On.BackColor = Color.Transparent;
            Music_Off.BackColor = Color.Transparent;
        }


        private void back_pB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Doulingo D = new Doulingo();

            D.ShowDialog();
            this.Close();
        }

        SoundPlayer pl = new SoundPlayer();

        List<Ranking> ra = new List<Ranking>();
        private void Ranking_Load(object sender, EventArgs e)
        {
            string[] sortedScore = File.ReadAllLines(@"./result.txt").OrderByDescending(s => Int32.Parse(s)).ToArray();
            int i = 1;
            listBox1.Items.Add("Rank".ToString() + "\t\t" + "Score".ToString());
            while (i <= 5)
            {
                listBox1.Items.Add("    " + i.ToString() + "\t\t" + sortedScore[i-1].ToString());
                i++;
            }
            
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

    }
}
