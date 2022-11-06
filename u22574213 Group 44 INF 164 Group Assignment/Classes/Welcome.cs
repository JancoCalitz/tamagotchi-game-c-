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

namespace FlappyBird.Classes
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            FrmInstructions myfrmInstructions = new FrmInstructions();
            myfrmInstructions.ShowDialog();
        }

        private void txtZelma_Click(object sender, EventArgs e)
        {
            Zelda frmZelda = new Zelda();
            frmZelda.ShowDialog();
            this.Close();
        }

        private void btnHarry_Click(object sender, EventArgs e)
        {
            Main frmMain = new Main();
            frmMain.ShowDialog();
            this.Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            btnPlay.Visible = true;
            btnStop.Visible = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = FlappyBird.Properties.Resources.Background;
            player.Play();
            btnStop.Visible = true;
            btnPlay.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stream = FlappyBird.Properties.Resources.Background;
            player.Stop();
            btnStop.Visible = false;
            btnPlay.Visible = true;
        }
    }
}
