namespace FlappyBird
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pbxFlappyBird = new System.Windows.Forms.PictureBox();
            this.pbxPipeTop = new System.Windows.Forms.PictureBox();
            this.pbxPipeBottom = new System.Windows.Forms.PictureBox();
            this.pbxGround = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGround)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(459, 569);
            this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(134, 36);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pbxFlappyBird
            // 
            this.pbxFlappyBird.Image = global::FlappyBird.Properties.Resources.bird;
            this.pbxFlappyBird.Location = new System.Drawing.Point(221, 206);
            this.pbxFlappyBird.Margin = new System.Windows.Forms.Padding(4);
            this.pbxFlappyBird.Name = "pbxFlappyBird";
            this.pbxFlappyBird.Size = new System.Drawing.Size(85, 63);
            this.pbxFlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFlappyBird.TabIndex = 0;
            this.pbxFlappyBird.TabStop = false;
            // 
            // pbxPipeTop
            // 
            this.pbxPipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pbxPipeTop.Location = new System.Drawing.Point(863, -21);
            this.pbxPipeTop.Margin = new System.Windows.Forms.Padding(4);
            this.pbxPipeTop.Name = "pbxPipeTop";
            this.pbxPipeTop.Size = new System.Drawing.Size(99, 165);
            this.pbxPipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPipeTop.TabIndex = 0;
            this.pbxPipeTop.TabStop = false;
            // 
            // pbxPipeBottom
            // 
            this.pbxPipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.pbxPipeBottom.Location = new System.Drawing.Point(689, 380);
            this.pbxPipeBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pbxPipeBottom.Name = "pbxPipeBottom";
            this.pbxPipeBottom.Size = new System.Drawing.Size(96, 174);
            this.pbxPipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPipeBottom.TabIndex = 0;
            this.pbxPipeBottom.TabStop = false;
            // 
            // pbxGround
            // 
            this.pbxGround.Image = global::FlappyBird.Properties.Resources.ground;
            this.pbxGround.Location = new System.Drawing.Point(0, 550);
            this.pbxGround.Margin = new System.Windows.Forms.Padding(4);
            this.pbxGround.Name = "pbxGround";
            this.pbxGround.Size = new System.Drawing.Size(1067, 79);
            this.pbxGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGround.TabIndex = 0;
            this.pbxGround.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1067, 630);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbxFlappyBird);
            this.Controls.Add(this.pbxPipeTop);
            this.Controls.Add(this.pbxPipeBottom);
            this.Controls.Add(this.pbxGround);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeysDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeysUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGround;
        private System.Windows.Forms.PictureBox pbxPipeBottom;
        private System.Windows.Forms.PictureBox pbxPipeTop;
        private System.Windows.Forms.PictureBox pbxFlappyBird;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

