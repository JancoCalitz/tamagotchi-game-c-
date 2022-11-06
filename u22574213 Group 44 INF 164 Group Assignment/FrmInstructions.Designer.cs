namespace FlappyBird
{
    partial class FrmInstructions
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
            this.rtxInstructions = new System.Windows.Forms.RichTextBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxInstructions
            // 
            this.rtxInstructions.Location = new System.Drawing.Point(222, 36);
            this.rtxInstructions.Name = "rtxInstructions";
            this.rtxInstructions.Size = new System.Drawing.Size(335, 365);
            this.rtxInstructions.TabIndex = 0;
            this.rtxInstructions.Text = "";
            this.rtxInstructions.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(621, 57);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(96, 48);
            this.btnDone.TabIndex = 1;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // FrmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.rtxInstructions);
            this.Name = "FrmInstructions";
            this.Text = "FrmInstructions";
            this.Load += new System.EventHandler(this.FrmInstructions_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxInstructions;
        private System.Windows.Forms.Button btnDone;
    }
}