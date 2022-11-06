using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird.Classes
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            btnWake.Visible = false;

        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            Form Player = new Player();
            Player.ShowDialog();
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            btnSleep.Visible = false;
            btnWake.Visible = true;
        }

        private void btnCollection_Click(object sender, EventArgs e)
        {
            Form Collection = new frmItemCollection();
            Collection.ShowDialog();
        }

        private void btnWake_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            btnSleep.Visible = true;
            btnWake.Visible = false;
        }
      
        private void lblCredits_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmItemCollection frm = new frmItemCollection();
            frm.LabelText = this.lblCredits2.Text;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Save main form file
            StreamWriter outputFile;
            outputFile = new StreamWriter("Harry.txt");
            MessageBox.Show("Your File is saved.");
            outputFile.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load main form file
            StreamReader inputFile;
            inputFile = new StreamReader("Harry.txt");
            inputFile.Close();
        }
    }
}
