using FlappyBird.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class AddPlayer : Form
    {
        public AddPlayer()
        {
            InitializeComponent();
        }
        public Players newPlayerRecord = new Players();
        private void AddPlayer_Load(object sender, EventArgs e)
        {

        }

        public void addPrize(string pr) {
            this.newPlayerRecord.Prize = pr;
        }

        public void addCredit( int cr)
        {
            this.newPlayerRecord.Credit = cr;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && cbxPet.Text != "")
            {
                this.newPlayerRecord.UserName = txtUsername.Text;
                this.newPlayerRecord.PetName = cbxPet.Text;
                this.newPlayerRecord.Prize = "";
                this.newPlayerRecord.Credit = 0;

                txtUsername.Text = "";
                cbxPet.Text = "";



                //close this form
                this.Close();
            }
        }
    }
}
