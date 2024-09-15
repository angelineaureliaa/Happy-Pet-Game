using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422031
{
    public class Cat : Pet
    {
        #region data members
        private bool vaccinationStatus;
        #endregion

        #region constructors
        public Cat(string name, Image picture, Player owner, bool vaccinationStatus) : base(name, picture, owner)
        {
            this.VaccinationStatus = vaccinationStatus;
        }
        #endregion

        #region properties
        public bool VaccinationStatus { get => vaccinationStatus; set => vaccinationStatus = value; }
        #endregion

        #region methods
        public override string DisplayData()
        {
            string status = "No";
            if (this.VaccinationStatus == true)
            {
                status = "Yes";
            }

            string data = base.DisplayData() +
                          "\nVaccination Status: " + status +
                          "\n";

            return data;
        }

        public override void Feed()
        {
            base.Health += 30;
            base.Energy += 50;
            base.Owner.Coins += (int)(0.5 * 30 * 100);
            base.Owner.Coins += (int)(0.5 * 50 * 100);
        }

        public void Play()
        {
            base.Happiness += 50;
            base.Energy -= 30;
            base.Owner.Coins += (int)(0.5 * 50 * 100);

        }

        public void Sleep()
        {
            base.Happiness += 20;
            base.Energy += 70;
            base.Owner.Coins += (int)(0.5 * 20 * 100);
            base.Owner.Coins += (int)(0.5 * 70 * 100);
        }

        public void Bath()
        {
            base.Health += 30;
            base.Owner.Coins += (int)(0.5 * 30 * 100);

        }

        public void Vaccinate()
        {
            if (this.VaccinationStatus == true)
            {
                if (base.Owner.Coins >= 1000)
                {
                    base.Health += 40;
                    base.Happiness -= 10;
                    this.VaccinationStatus = true;
                    this.Owner.Coins -= 100;

                    base.Owner.Coins += (int)(0.5 * 40 * 100);
                }
                else
                {
                    throw (new ArgumentException("Not enough coins. Vaccination cost = 1000 coins"));
                }
            }
            else
            {
                throw (new ArgumentException("Your pet has already been vaccinated"));
            }
           
        }
        #endregion
    }
}