using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LibrarySystem
{
    public class Equipment
    {
        // Private backing fields
        public int equipmentId
        {
            get { return equipmentId; }
            set { equipmentId = value; }
        }

        public string name
        {
            get { return name; }
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Error: Equipment name cannot be blank.");
                }
            }
        }

        public bool IsAvailable
        {
            get { return IsAvailable; }
            set { IsAvailable = value; }
        }
    }
}