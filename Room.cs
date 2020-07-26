using oop___exercise___3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
   public abstract class Room
    {
        protected int _roomNumber;
        protected float _price;
        Guest _guest;
        protected bool _isClean;
        protected string _featues;

        protected Room(int roomNumber, float price)
        {
            _roomNumber = roomNumber;
            _price = price;
        }

        internal void SetGuest(Guest g)
        {
            _guest = g;
        }
        protected virtual void SetPrice()
        {
            _price = 50;
        }
        protected abstract void SetFreaturs();
        public Guest GetGuest()
        {
            return _guest;
        }
        public void SetIsClean(bool isclean)
        {
            _isClean = isclean;
        }
        public int GetRoomNumber()
        {
            return _roomNumber;
        }
        public float GetPrice()
        {
            return _price;
        }
        public bool IsClean()
        {
            return _isClean;
        }
        public string GetFeaturs()
        {
            return _featues;
        }

        public override string ToString()
        {
            return $"room number: {_roomNumber}, price: {_price}, is te room clean? {_isClean}, freaturs: {_featues}";
        }
    }
}
