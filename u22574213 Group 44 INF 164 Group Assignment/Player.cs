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
using System.IO;

namespace FlappyBird
{
    public partial class Player : Form
    {
        public Player()
        {
            InitializeComponent();
        }
        AddPlayer myAddForm = new AddPlayer();
        //Data members
        private Players mMyPrizePrize;
        //property
        public Players MyPrizes
        {
            get { return mMyPrizePrize;}
            set { mMyPrizePrize = value; }
        }
        BindingList<Players> playerList = new BindingList<Players>();
        private void btnPrize_Click(object sender, EventArgs e)
        {
            int prizeNo;
            string prize;

            Random prizeGenerator = new Random();
            prizeNo = prizeGenerator.Next(1, 4);

            if (prizeNo == 1)
            {
                prize = "Chew Toy";
            }
            else
            {
                prize = "Squeeky Toy";
            }
            if (prizeNo == 3)
            {
                prize = "Dog toy";
            }
            MessageBox.Show("Your prize is: " + prize);
            playerList.Remove(this.myAddForm.newPlayerRecord);
            this.myAddForm.addPrize(prize);
            playerList.Add(this.myAddForm.newPlayerRecord);
        }

        private void Player_Load(object sender, EventArgs e)
        {
            dgvPlayer.DataSource = playerList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            myAddForm.ShowDialog();
            playerList.Add(myAddForm.newPlayerRecord);
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            FrmInstructions myfrmInstructions = new FrmInstructions();
            myfrmInstructions.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 myGame = new Form1();
            myGame.ShowDialog();
            this.btnPrize.Enabled = true;

            int credits = 9;
           
                playerList.Remove(this.myAddForm.newPlayerRecord);
                this.myAddForm.addCredit(credits);
                playerList.Add(this.myAddForm.newPlayerRecord);

                credits++;
            
            

        }

        private void btnHTML_Click(object sender, EventArgs e)
        {
            string applicationDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string myFile = Path.Combine(applicationDirectory, "../../www/index.html");
            webBrowser1.Url = new Uri("file:///" + myFile);
            webBrowser1.Visible = true;
            webBrowser1.AllowNavigation = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
