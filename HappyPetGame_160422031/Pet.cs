using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422031
{
    public class Pet
    {
        #region data members
        private string name;
        private int health;
        private int energy;
        private int happiness;
        private Image picture;
        private Player owner;
        private List<Toy> listOfToys;
        #endregion

        #region constructors
        public Pet(string name, Image picture, Player owner)
        {
            this.Name = name;
            this.Health = 100;
            this.Energy = 100;
            this.Happiness = 100;
            this.Picture = picture;
            this.Owner = owner;
            this.ListOfToys = new List<Toy>();
        }
        #endregion

        #region properties
        public string Name
        {
            get => name;
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw (new ArgumentException("Pet name cannot be empty"));
                }
            }
        }
        public int Health
        {
            get => health;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    health = value;
                }
                else if (value < 10)
                {
                    health = 10;
                }
                else
                {
                    health = 100;
                }
            }
        }
        public int Energy
        {
            get => energy;
            set
            {
                if ( value >= 10 && value <= 100)
                {
                    energy = value;
                }
                else if (value <10)
                {
                    energy = 10;
                }
                else
                {
                    energy = 100;
                }
            }
        }
        public int Happiness
        {
            get => happiness;
            set
            {
                if (value >= 10 && value <= 100)
                {
                    happiness = value;
                }
                else if (value < 10)
                {
                    happiness = 10;
                }
                else
                {
                    happiness = 100;
                }
            }
        }
        public Image Picture { get => picture; set => picture = value; }
        public Player Owner { get => owner; set => owner = value; }
        public List<Toy> ListOfToys { get => listOfToys; set => listOfToys = value; }
        #endregion

        #region methods
        public abstract void Feed();
        public virtual string DisplayData()
        {
            string data = this.Name +
                          "\nHealth: " + this.Health +
                          "\n% Energy: " + this.Energy + "%" +
                          "\n% Happiness: " + this.Happiness + "%" +
                          "\n";

            return data;
        }

        public string GetHealthCondition()
        {
            string condition = "";

            if (this.Health > 80)
            {
                condition = "Very good";
            }
            else if (this.Health >= 61)
            {
                condition = "Good";
            }
            else if (this.Health >= 26)
            {
                condition = "Poor";
            }
            else
            {
                condition = "Very Poor";
            }

            return condition;
        }

        public string GetEnergyCondition()
        {
            string condition = "";

            if (this.Energy >= 76)
            {
                condition = "Strong";
            }
            else if (this.Energy >= 51)
            {
                condition = "Moderate";
            }
            else
            {
                condition = "Weak";
            }

            return condition;
        }

        public string GetHappinessCondition()
        {
            string condition = "";

            if (this.Happiness >= 61)
            {
                condition = "Happy";
            }
            else
            {
                condition = "Unhappy";
            }

            return condition;
        }

        public void BuyToy(Toy newToy)
        {
            if (this.Owner.Coins >= newToy.Price)
            {
                this.ListOfToys.Add(newToy);
                this.Owner.Coins -= newToy.Price;
                this.Happiness += newToy.Benefit;
            }
            else
            {
                throw (new ArgumentException("Not enough coins. Toy's prce = " + newToy.Price));
            }
        }
        #endregion
    }
}