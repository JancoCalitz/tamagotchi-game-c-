
namespace FlappyBird.Classes
{
    partial class Welcome
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
            this.btnInstructions = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnHarry = new System.Windows.Forms.Button();
            this.btnZelda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInstructions
            // 
            this.btnInstructions.Location = new System.Drawing.Point(342, 367);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(123, 61);
            this.btnInstructions.TabIndex = 0;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = true;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(281, 83);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(255, 22);
            this.txtUserName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Zelda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Harry";
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(360, 204);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 30);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(361, 204);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnHarry
            // 
            this.btnHarry.BackgroundImage = global::FlappyBird.Properties.Resources.png_transparent_cat_and_dog_puppy_pet_shiba_inu_golden_retriever_pembroke_welsh_corgi_cuteness_cartoon_thumbnail;
            this.btnHarry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHarry.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnHarry.Location = new System.Drawing.Point(508, 134);
            this.btnHarry.Name = "btnHarry";
            this.btnHarry.Size = new System.Drawing.Size(205, 170);
            this.btnHarry.TabIndex = 6;
            this.btnHarry.UseVisualStyleBackColor = true;
            this.btnHarry.Click += new System.EventHandler(this.btnHarry_Click);
            // 
            // btnZelda
            // 
            this.btnZelda.BackgroundImage = global::FlappyBird.Properties.Resources.images2;
            this.btnZelda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZelda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnZelda.Location = new System.Drawing.Point(71, 134);
            this.btnZelda.Name = "btnZelda";
            this.btnZelda.Size = new System.Drawing.Size(208, 170);
            this.btnZelda.TabIndex = 1;
            this.btnZelda.UseVisualStyleBackColor = true;
            this.btnZelda.Click += new System.EventHandler(this.txtZelma_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHarry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnZelda);
            this.Controls.Add(this.btnInstructions);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnZelda;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHarry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
    }
}