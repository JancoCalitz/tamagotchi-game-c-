using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
    public partial class frmItemCollection : Form
    {
        public frmItemCollection()
        {
            InitializeComponent();
        }
        public string LabelText
        {
            get { return this.lblCredits.Text; }
            set { lblCredits.Text = value; }
        }

        int Credits;
        BindingList<Items> myItems = new BindingList<Items>();
        private void frmItemCollection_Load(object sender, EventArgs e)
        {
            //Already populated when form loads
            Items newItems;
            newItems = new Items("Die Hard", "John McTiernan", new DateTime(1988, 07, 22), "Movie", "Action", 20);
            myItems.Add(newItems);
            newItems = new Items("The Great Gatsby", "F. Scott Fitzgerald", new DateTime(1925, 04, 10), "Book", "Fiction", 15);
            myItems.Add(newItems);

            //Link with datagridview
            dgvCollection.DataSource = myItems;
            Credits = 500;
            for (int i = 0; i < dgvCollection.Rows.Count; i++)
            {
                Credits -= Convert.ToInt32(dgvCollection.Rows[i].Cells[5].Value);
                lblCredits.Text = "Credits: " + Convert.ToString(Credits);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Credits = Credits - Convert.ToInt32(nudPrice.Value);
                lblCredits.Text = "Credits: " + Convert.ToString(Credits);
                Items newItems = new Items(txtTitle.Text, txtAuthorDirect.Text, dtpDate.Value, Convert.ToString(cbxBookMovie.SelectedItem), Convert.ToString(cbxGenre.SelectedItem), Convert.ToInt32(nudPrice.Value));
                myItems.Add(newItems);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot add item.");
            }

            //Clear textboxes
            txtTitle.Text = "";
            txtAuthorDirect.Text = "";
            cbxBookMovie.Text = "";
            cbxGenre.Text = "";
            nudPrice.Value = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int iSelectedItem = dgvCollection.CurrentCell.RowIndex;
            frmEditItem myForm = new frmEditItem();
            myForm.EditedItem = myItems[iSelectedItem];
            myForm.ShowDialog();
            myItems[iSelectedItem] = myForm.EditedItem;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int iSelectedItem = dgvCollection.CurrentCell.RowIndex;
            myItems.RemoveAt(iSelectedItem);
            Credits = 500;
            for (int i = 0; i < dgvCollection.Rows.Count; i++)
            {
                Credits -= Convert.ToInt32(dgvCollection.Rows[i].Cells[5].Value);
                lblCredits.Text = "Credits: " + Convert.ToString(Credits);
            }
        }

        private void btnStat_Click(object sender, EventArgs e)
        {
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < dgvCollection.Rows.Count - 1; i++)
            {
                if (Convert.ToString(dgvCollection[3, i].Value) == "Movie")
                {
                    count1++;
                }
                else if (Convert.ToString(dgvCollection[3, i].Value) == "Book")
                {
                    count2++;
                }
                else
                {
                    MessageBox.Show("Please choose a type.");
                }
            }
            MessageBox.Show("Book: " + count2 + "\n" +
                             "Movie: " + count1);

        }
       
        private void returnHomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Total Credits: " + Convert.ToString(Credits));
            this.Close();
        }
        //Serialize Form
        public void WriteDataToFile(string listName, BindingList<Items>myItems)
        {
            FileStream outFile = new FileStream(listName + ".ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(outFile, myItems);
            outFile.Close();
        }
        //De-Serialize Form
        public void ReadDataFromFile(string listName, BindingList<Items>myItems)
        {
            try
            {
                FileStream inFile = new FileStream(listName + ".ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                myItems.Clear();
                var tempList = (BindingList<Items>)bFormatter.Deserialize(inFile);
                foreach (Items myObject in tempList)
                {
                    myItems.Add(myObject);
                }
                inFile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The File was not found.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteDataToFile("myFile", myItems);
            MessageBox.Show("Your data has been saved.");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ReadDataFromFile("myFile", myItems);
        }
    }
}
