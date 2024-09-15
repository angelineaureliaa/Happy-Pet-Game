using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422031
{
    public class Chameleon : Pet
    {
        #region data members
        private Color currentColor;
        #endregion

        #region constructors
        public Chameleon(string name, Image picture, Player owner, Color currentColor) : base (name, picture, owner)
        {
            this.currentColor = currentColor;
        }
        #endregion

        #region properties
        public Color CurrentColor { get => currentColor; set => currentColor = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string data = base.DisplayData() +
                          "\nCurrent color: " + this.CurrentColor;

            return data;
        }

        public void ChangeColor(Color newColor)
        {
            this.CurrentColor = newColor;
        }
        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
            base.Owner.Coins += (int)(0.5 * 30 * 100);
            base.Owner.Coins += (int)(0.5 * 50 * 100);
        }

        public void Sleep()
        {
            base.Health += 60;
            base.Energy += 60;
            base.Owner.Coins += (int)(0.5 * 60 * 100);
            base.Owner.Coins += (int)(0.5 * 60 * 100);
        }
        #endregion
    }
}