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

namespace FlappyBird
{
    public partial class FrmInstructions : Form
    {
        public FrmInstructions()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void FrmInstructions_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;
            inputFile = new StreamReader("Instructions.txt");

            string inputAllLines;
            inputAllLines = inputFile.ReadToEnd();
            rtxInstructions.Text = inputAllLines;

            inputFile.Close();
        }
    }
}
