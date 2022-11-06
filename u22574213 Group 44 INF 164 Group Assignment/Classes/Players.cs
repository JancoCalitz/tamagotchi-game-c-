using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBird.Classes
{
    public class Players
    {
        //Data members 
        private string mUserName;
        private string mPetName;
        private string mPrize;
        private int mCredits;


        //Constructors
        //Default
        public Players()
        {
            mUserName = "";
            mPetName = "";
            mPrize = "";
            mCredits = 0;
        }
        //Overloaded
        public Players(string userName, string petName, string prize, int credit )
        {
            mUserName = userName;
            mPetName = petName;
            mPrize = prize;
            mCredits = credit;
        }

        //Properties
        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }
        public string PetName
        {
            get { return mPetName; }
            set { mPetName = value; }
        }
        public int Credit
        {
            get { return mCredits; }
            set { mCredits= value; }
        }
        public string Prize
        {
            get { return mPrize; }
            set { mPrize = value; }
        }
        
        

    }
}
