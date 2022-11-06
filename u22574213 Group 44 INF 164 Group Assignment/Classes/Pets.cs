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
   public class Pets
    {
        //Data members
        private string mName;
        private int mCredits;
        private int mEnergy;


        //Constructors overloaded
        public Pets(string name, int credits, int energy)
        {
            mName = name;
            mCredits = credits;
            mEnergy = energy;
        }

        //Properties
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public int Credit
        {
            get { return mCredits; }
            set { mCredits = value; }
        }
        public int Energy
        {
            get { return mEnergy; }
            set { mEnergy = value; }
        }
    }
}
