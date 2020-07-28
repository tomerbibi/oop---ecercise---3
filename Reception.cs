using System;
using oop___exercise___3;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Hotel
{
   public static class Reception
    {
        private const int _numberOfRooms = 10;
        private static int _numberOfGuests;
        private static Room[] _rooms = new Room[_numberOfRooms];
        private static RoomService _roomService = new RoomService();
         public static Room CheckIn(Guest g)
        {
            _numberOfGuests++;
            for (int i = 0; i < _numberOfRooms; i++)
            {
                if (_rooms[i].GetGuest() == null)
                {
                    _rooms[i].SetGuest(g);
                    return _rooms[i];
                }
            }
            Console.WriteLine("sorry we dont have any available room");
            return null;
        }
        public static void CheckOut(Room r)
        {
            r.SetGuest(null);
        }
        public static bool ISRoomFree(Room r)
        {
            if (r.GetGuest() == null)
            {
                return false;
            }
            return true;
        }
        private static void SendRoomService(Room r)
        {
            _roomService.CleanRoom(r);
        }
    }
}
