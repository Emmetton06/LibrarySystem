using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    internal class Resistance_Machine
    {
        private int weightStackMax;
        private int equipmentId;
        private string name;
        private bool isAvailable;

        // Public property
        public int WeightStackMax
        {
            get { return weightStackMax; }
            set
            {
                if (value > 0)
                {
                    weightStackMax = value;
                }
                else
                {
                    Console.WriteLine("Error: Weight stack must be greater than zero.");
                }
            }
        }

        // Subclass constructor
        // We accept all parameters, but pass the base attributes up to the superclass using : base()
        public Resistance_Machine(int equipmentId, string name, bool isAvailable, int weightStackMax)
        {
            this.equipmentId = equipmentId;
            this.name = name;
            this.isAvailable = isAvailable;
            this.WeightStackMax = weightStackMax;
        }

        public Resistance_Machine(int equipmentId, string name, bool isAvailable)
        {
            this.equipmentId = equipmentId;
            this.name = name;
            this.isAvailable = isAvailable;
        }
    }
}
