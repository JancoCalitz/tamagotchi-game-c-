
namespace FlappyBird.Classes
{
    partial class Zelda
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnWake = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnGame = new System.Windows.Forms.Button();
            this.btnCollection = new System.Windows.Forms.Button();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblCredits2 = new System.Windows.Forms.Label();
            this.pbxZelda = new System.Windows.Forms.PictureBox();
            this.pbxZeldaSleep = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZelda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZeldaSleep)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(644, 62);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 39);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update credits";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnWake
            // 
            this.btnWake.Location = new System.Drawing.Point(62, 196);
            this.btnWake.Name = "btnWake";
            this.btnWake.Size = new System.Drawing.Size(109, 47);
            this.btnWake.TabIndex = 19;
            this.btnWake.Text = "Wake Up";
            this.btnWake.UseVisualStyleBackColor = true;
            this.btnWake.Click += new System.EventHandler(this.btnWake_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(349, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 17);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name: Zelda";
            // 
            // btnSleep
            // 
            this.btnSleep.Location = new System.Drawing.Point(62, 196);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(109, 48);
            this.btnSleep.TabIndex = 15;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnGame
            // 
            this.btnGame.Location = new System.Drawing.Point(62, 88);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(109, 48);
            this.btnGame.TabIndex = 14;
            this.btnGame.Text = "Arcade Game";
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnCollection
            // 
            this.btnCollection.Location = new System.Drawing.Point(62, 142);
            this.btnCollection.Name = "btnCollection";
            this.btnCollection.Size = new System.Drawing.Size(109, 48);
            this.btnCollection.TabIndex = 13;
            this.btnCollection.Text = "Collection";
            this.btnCollection.UseVisualStyleBackColor = true;
            this.btnCollection.Click += new System.EventHandler(this.btnCollection_Click);
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(22, 42);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(85, 17);
            this.lblEnergy.TabIndex = 12;
            this.lblEnergy.Text = "Energy: 100";
            // 
            // lblCredits2
            // 
            this.lblCredits2.AutoSize = true;
            this.lblCredits2.Location = new System.Drawing.Point(651, 42);
            this.lblCredits2.Name = "lblCredits2";
            this.lblCredits2.Size = new System.Drawing.Size(84, 17);
            this.lblCredits2.TabIndex = 11;
            this.lblCredits2.Text = "Credits:500 ";
            // 
            // pbxZelda
            // 
            this.pbxZelda.Image = global::FlappyBird.Properties.Resources.images;
            this.pbxZelda.Location = new System.Drawing.Point(256, 77);
            this.pbxZelda.Name = "pbxZelda";
            this.pbxZelda.Size = new System.Drawing.Size(278, 247);
            this.pbxZelda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxZelda.TabIndex = 22;
            this.pbxZelda.TabStop = false;
            // 
            // pbxZeldaSleep
            // 
            this.pbxZeldaSleep.Image = global::FlappyBird.Properties.Resources._26bdbe96d5b844204a0ad981f5394294;
            this.pbxZeldaSleep.Location = new System.Drawing.Point(256, 77);
            this.pbxZeldaSleep.Name = "pbxZeldaSleep";
            this.pbxZeldaSleep.Size = new System.Drawing.Size(278, 247);
            this.pbxZeldaSleep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxZeldaSleep.TabIndex = 21;
            this.pbxZeldaSleep.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(406, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Load ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zelda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxZelda);
            this.Controls.Add(this.pbxZeldaSleep);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnWake);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnGame);
            this.Controls.Add(this.btnCollection);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.lblCredits2);
            this.Name = "Zelda";
            this.Text = "Zelda";
            this.Load += new System.EventHandler(this.Zelda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxZelda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxZeldaSleep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnWake;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.Button btnCollection;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblCredits2;
        private System.Windows.Forms.PictureBox pbxZeldaSleep;
        private System.Windows.Forms.PictureBox pbxZelda;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}