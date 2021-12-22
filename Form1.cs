using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace piano
{
    public partial class Form1 : Form
    {       //https://www.youtube.com/watch?v=mQZavCCfvS4
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void Anote_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\infom\source\repos\piano\piano\Resources\A.wav");
            sp.Play();
        }

        private void Bnote_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\infom\source\repos\piano\piano\Resources\B.wav");
            sp.Play();
        }

        private void Cnote_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\infom\source\repos\piano\piano\Resources\C.wav");
            sp.Play();
        }

        private void Dnote_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\infom\source\repos\piano\piano\Resources\D.wav");
            sp.Play();
        }

        private void Enote_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\infom\source\repos\piano\piano\Resources\E.wav");
            sp.Play();
        }

        private void Fnote_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\infom\source\repos\piano\piano\Resources\F.wav");
            sp.Play();
        }

        private void Gnote_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\infom\source\repos\piano\piano\Resources\G.wav");
            sp.Play();
        }
    }
}
