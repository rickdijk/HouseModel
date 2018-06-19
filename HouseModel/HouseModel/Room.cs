using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    class Room : Location
    {
        public Room(string name)
            : base(name)
        {

        }

        private string decoration;
        public string Decoration { get; set; }

        public override string GetDescription()
        {
            string description = $"You’re standing in the {Name}. You see exits to the following places: ";
            for (int i = 0; i < Exits.Length; i++)
            {
                description += $" {Exits[i].Name}";
                if (i != Exits.Length - 1)
                    description += ",";
            }
            description += $". You see {decoration}";
            return description;
        }
    }
}
