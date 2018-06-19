using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    class Outside : Location
    {
        public Outside(string name)
            : base(name)
        {
        }

        private bool hot;
        public bool Hot { get; }

        public override string GetDescription()
        {
            string description = $"You’re standing in the {Name}. You see exits to the following places: ";
            for (int i = 0; i < Exits.Length; i++)
            {
                description += $" {Exits[i].Name}";
                if (i != Exits.Length - 1)
                    description += ",";
            }
            description += ".";
            if (hot)
                description += " It's very hot here.";
            return description;
        }
    }
}
