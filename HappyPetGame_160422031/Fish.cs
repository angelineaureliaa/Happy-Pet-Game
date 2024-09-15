using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422031
{
    public class Fish : Pet
    {
        #region data members
        private string environment;
        #endregion

        #region constructors
        public Fish(string name, Image picture, Player owner, string environment) : base(name, picture, owner)
        {
            this.Environment = environment;
        }
        #endregion

        #region properties
        public string Environment { get => environment; set => environment = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string data = base.DisplayData() +
                          "\nEnvironment: " + this.Environment;

            return data;
        }

        public override void Feed()
        {
            base.Health += 20;
            base.Energy += 40;
            base.Owner.Coins += (int)(0.5 * 20 * 100);
            base.Owner.Coins += (int)(0.5 * 40 * 100);
        }

        public void Clean()
        {
            if (base.Owner.Coins >= 500)
            {
                base.Health += 60;
                base.Happiness += 50;
                base.Owner.Coins -= 500;
                base.Owner.Coins += (int)(0.5 * 60 * 100);
                base.Owner.Coins += (int)(0.5 * 50 * 100);
            }
            else
            {
                throw (new ArgumentException("Not enough coins. Cleaning cost = 500 coins."));
            }
        }
        #endregion
    }
}