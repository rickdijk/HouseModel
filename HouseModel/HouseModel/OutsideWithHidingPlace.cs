using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) 
            : base(name, hot)
        {
            HidingPlaceName = hidingPlace;
        }

        public string HidingPlaceName { get; private set; }
    }
}
