
namespace FlappyBird.Classes
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCredits2 = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.btnCollection = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnSleep = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnWake = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCredits2
            // 
            this.lblCredits2.AutoSize = true;
            this.lblCredits2.Location = new System.Drawing.Point(660, 25);
            this.lblCredits2.Name = "lblCredits2";
            this.lblCredits2.Size = new System.Drawing.Size(84, 17);
            this.lblCredits2.TabIndex = 1;
            this.lblCredits2.Text = "Credits:500 ";
            this.lblCredits2.Click += new System.EventHandler(this.lblCredits_Click);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(31, 25);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(85, 17);
            this.lblEnergy.TabIndex = 2;
            this.lblEnergy.Text = "Energy: 100";
            // 
            // btnCollection
            // 
            this.btnCollection.Location = new System.Drawing.Point(34, 124);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(109, 48);
            this.btnCollection.TabIndex = 3;
            this.btnCollection.Text = "Collection";
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(34, 70);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(109, 48);
            this.btnGame.TabIndex = 4;
            this.btnGame.Text = "Arcade Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(34, 178);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(109, 48);
            this.btnSleep.TabIndex = 5;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(358, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 17);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name: Harry";
            // 
            // btnWake
            // 
            this.btnWake.Location = new System.Drawing.Point(34, 178);
            this.btnWake.Name = "btnWake";
            this.btnWake.Size = new System.Drawing.Size(109, 47);
            this.btnWake.TabIndex = 9;
            this.btnWake.Text = "Wake Up";
            this.btnWake.UseVisualStyleBackColor = true;
            this.btnWake.Click += new System.EventHandler(this.btnWake_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(649, 45);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 41);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update credits";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FlappyBird.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(205, 61);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(358, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.png_transparent_cat_and_dog_puppy_pet_shiba_inu_golden_retriever_pembroke_welsh_corgi_cuteness_cartoon_thumbnail;
            this.pictureBox1.Location = new System.Drawing.Point(205, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnWake);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnCollection);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.lblCredits2);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCredits2;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}