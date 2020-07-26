using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class RoomForTwo : Room
    {
        public RoomForTwo(int roomNumber, float price) : base(roomNumber, price)
        {
            SetPrice();
            SetFreaturs();
        }

        protected override void SetFreaturs()
        {
            _featues = "bed for two peaple, bathroom, sink.";
        }
    }
}
