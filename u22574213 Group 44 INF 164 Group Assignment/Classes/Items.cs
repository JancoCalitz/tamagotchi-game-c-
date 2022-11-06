using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Classes
{
    [Serializable]
    public class Items
    {
        //Data members
        private string mTitle;
        private string mAuthor;
        private DateTime mDate;
        private string mType;
        private string mGenre;
        private double mPrice;

        //Constructors
        //Default
        public Items()
        {
            mTitle = "";
            mAuthor = "";
            mDate = DateTime.Today;
            mType = "";
            mGenre = "";
            mPrice = 0;
        }

        //Overloaded
        public Items(string title, string creator, DateTime date, string type, string genre, double price)
        {
            mTitle = title;
            mAuthor = creator;
            mDate = date;
            mType = type;
            mGenre = genre;
            mPrice = price;
        }

        //Properties
        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        public string Creator
        {
            get { return mAuthor; }
            set { mAuthor = value ; }
        }
        public DateTime Released
        {
            get { return mDate; }
            set { mDate = value; }
        }
        public string ItemType
        {
            get { return mType; }
            set { mType = value; }
        }
        public string Genre
        {
            get { return mGenre; }
            set { mGenre = value; }
        }
        public double Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }
    }
}
