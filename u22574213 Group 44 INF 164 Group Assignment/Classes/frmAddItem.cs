using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird.Classes
{
    public partial class frmEditItem : Form
    {
        public frmEditItem()
        {
            InitializeComponent();
        }
        //new datamember for the edited item
        private Items mEditedItems;
        public Items EditedItem
        {
            get { return mEditedItems; }
            set { mEditedItems = value; }
        }
        private void frmEditItem_Load(object sender, EventArgs e)
        {
            txtTitle.Text = EditedItem.Title;
            txtAuthorDirect.Text = EditedItem.Creator;
            dtpDate.Value = EditedItem.Released;
            cbxBookMovie.SelectedItem = EditedItem.ItemType;
            cbxGenre.SelectedItem = EditedItem.Genre;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditedItem.Title = txtTitle.Text;
            EditedItem.Creator = txtAuthorDirect.Text;
            EditedItem.Released = dtpDate.Value;
            EditedItem.ItemType = Convert.ToString(cbxBookMovie.SelectedItem);
            EditedItem.Genre = Convert.ToString(cbxGenre.SelectedItem);
          
            this.Close();
        }
       
    }
}
