
namespace FlappyBird.Classes
{
    partial class frmEditItem
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cbxBookMovie = new System.Windows.Forms.ComboBox();
            this.txtAuthorDirect = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(264, 363);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(220, 63);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Apply Changes to Item";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxGenre);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.cbxBookMovie);
            this.groupBox1.Controls.Add(this.txtAuthorDirect);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Location = new System.Drawing.Point(107, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(587, 294);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Items in Collection";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Author/Director:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Title of book/movie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Genre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Item Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Published Date:";
            // 
            // cbxGenre
            // 
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
            "Thriller",
            "Action",
            "Adventure",
            "Romance",
            "Comedy",
            "Horror",
            "Fiction"});
            this.cbxGenre.Location = new System.Drawing.Point(231, 175);
            this.cbxGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(217, 24);
            this.cbxGenre.TabIndex = 16;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(231, 114);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(275, 22);
            this.dtpDate.TabIndex = 15;
            // 
            // cbxBookMovie
            // 
            this.cbxBookMovie.FormattingEnabled = true;
            this.cbxBookMovie.Items.AddRange(new object[] {
            "Book",
            "Movie"});
            this.cbxBookMovie.Location = new System.Drawing.Point(231, 143);
            this.cbxBookMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxBookMovie.Name = "cbxBookMovie";
            this.cbxBookMovie.Size = new System.Drawing.Size(217, 24);
            this.cbxBookMovie.TabIndex = 14;
            // 
            // txtAuthorDirect
            // 
            this.txtAuthorDirect.Location = new System.Drawing.Point(231, 86);
            this.txtAuthorDirect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAuthorDirect.Name = "txtAuthorDirect";
            this.txtAuthorDirect.Size = new System.Drawing.Size(275, 22);
            this.txtAuthorDirect.TabIndex = 13;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(231, 58);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(275, 22);
            this.txtTitle.TabIndex = 12;
            // 
            // frmEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEditItem";
            this.Text = "frmEditItem";
            this.Load += new System.EventHandler(this.frmEditItem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cbxBookMovie;
        private System.Windows.Forms.TextBox txtAuthorDirect;
        private System.Windows.Forms.TextBox txtTitle;
    }
}