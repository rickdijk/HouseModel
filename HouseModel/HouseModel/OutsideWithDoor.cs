using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name)
            : base(name)
        {

        }

        public string DoorDescription { get; }
        public string DoorLocation { get; set; }
    }
}
