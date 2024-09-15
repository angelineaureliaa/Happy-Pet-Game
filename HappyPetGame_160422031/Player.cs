using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyPetGame_160422031
{
    public class Player
    {
        #region data members
        private string name;
        private int coins;
        private DateTime lastPlay;
        #endregion

        #region constructors
        public Player(string name)
        {
            this.Name = name;
            this.Coins = 100;
            this.LastPlay = DateTime.Now;
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
                    throw (new ArgumentException("Player name cannot be empty"));
                }
            }
        }
        public int Coins { get => coins; set => coins = value; }
        public DateTime LastPlay { get => lastPlay; set => lastPlay = value; }
        #endregion

        #region methods
        public string DisplayData()
        {
            string data = this.Name +
                          "\nCoins: " + this.Coins +
                          "\n";

            return data;
        }
        #endregion
    }
}