using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class FamiliRoom : Room
    {
        public FamiliRoom(int roomNumber, float price) : base(roomNumber, price)
        {
            SetPrice();
            SetFreaturs();
        }

        protected override void SetFreaturs()
        {
           _featues = "four beds, bathroom, sink.";
        }

        protected override void SetPrice()
        {
            _price = 100;
        }
    }
}
