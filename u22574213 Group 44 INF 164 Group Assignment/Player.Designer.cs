namespace FlappyBird
{
    partial class Player
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
            this.btnRules = new System.Windows.Forms.Button();
            this.btnPrize = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPlayer = new System.Windows.Forms.DataGridView();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHTML = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRules
            // 
            this.btnRules.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRules.Location = new System.Drawing.Point(243, 345);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(117, 60);
            this.btnRules.TabIndex = 8;
            this.btnRules.Text = "Instructions";
            this.btnRules.UseVisualStyleBackColor = false;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // btnPrize
            // 
            this.btnPrize.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrize.Enabled = false;
            this.btnPrize.Location = new System.Drawing.Point(410, 345);
            this.btnPrize.Name = "btnPrize";
            this.btnPrize.Size = new System.Drawing.Size(110, 60);
            this.btnPrize.TabIndex = 7;
            this.btnPrize.Text = "Collect Prize";
            this.btnPrize.UseVisualStyleBackColor = false;
            this.btnPrize.Click += new System.EventHandler(this.btnPrize_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAdd.Location = new System.Drawing.Point(68, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 60);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Location = new System.Drawing.Point(136, 70);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            this.dgvPlayer.RowHeadersWidth = 51;
            this.dgvPlayer.RowTemplate.Height = 24;
            this.dgvPlayer.Size = new System.Drawing.Size(562, 232);
            this.dgvPlayer.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Location = new System.Drawing.Point(558, 345);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(104, 60);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHTML
            // 
            this.btnHTML.Location = new System.Drawing.Point(308, 446);
            this.btnHTML.Name = "btnHTML";
            this.btnHTML.Size = new System.Drawing.Size(140, 60);
            this.btnHTML.TabIndex = 10;
            this.btnHTML.Text = "Show management ";
            this.btnHTML.UseVisualStyleBackColor = true;
            this.btnHTML.Click += new System.EventHandler(this.btnHTML_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(725, 345);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(109, 60);
            this.btnHome.TabIndex = 12;
            this.btnHome.Text = "Return Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(-1, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(903, 527);
            this.webBrowser1.TabIndex = 11;
            this.webBrowser1.Url = new System.Uri("http://s", System.UriKind.Absolute);
            this.webBrowser1.Visible = false;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(903, 518);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnHTML);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.btnPrize);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPlayer);
            this.Name = "Player";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.Player_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.Button btnPrize;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHTML;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnHome;
    }
}