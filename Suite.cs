using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Suite : Room
    {
        public Suite(int roomNumber, float price) : base(roomNumber, price)
        {
            SetPrice();
            SetFreaturs();
        }

        protected override void SetFreaturs()
        {
            _featues = "2 king size beds, jacuzzi, 2 bathrooms, kitchen, 2 tv.";
        }

        protected override void SetPrice()
        {
            _price = 150;
        }
    }
}
