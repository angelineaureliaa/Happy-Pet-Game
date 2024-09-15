using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422031
{
    public class Toy
    {
        #region data members
        private string name;
        private int price;
        private int benefit;
        private Image picture;
        #endregion

        #region constructors
        public Toy(string name, int price, int benefit, Image picture)
        {
            this.name = name;
            this.price = price;
            this.benefit = benefit;
            this.picture = picture;
        }
        #endregion

        #region properties
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int Benefit { get => benefit; set => benefit = value; }
        public Image Picture { get => picture; set => picture = value; }
        #endregion

        #region methods
        public string DisplayData()
        {
            string data = "Name: " + this.Name +
                          "\nPrice" + this.Price + " coins" +
                          "\nBenefit " + this.Benefit + "%";

            return data;
        }
        #endregion
    }
}