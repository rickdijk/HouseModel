using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseModel
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name) 
            : base(name)
        {

        }

        public string DoorDescription => throw new NotImplementedException();
        public string DoorLocation => throw new NotImplementedException();
    }
}
