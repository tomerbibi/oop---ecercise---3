using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class RoomService
    {
        internal void CleanRoom(RoomForTwo RFT)
        {
            RFT.SetIsClean(true);
            Console.WriteLine("the bed, sink and bathroom have been cleaned");
        }
        internal void CleanRoom(FamiliRoom FR)
        {
            FR.SetIsClean(true);
            Console.WriteLine("the beds, sink and bathroom have been cleaned");
        }
        internal void CleanRoom(Suite s)
        {
            s.SetIsClean(true);
            Console.WriteLine("the beds, sink and bathrooms, kitchen and jacuzzi have been cleaned");
        }
        internal void CleanRoom(Room r)
        {
            r.SetIsClean(true);
            Console.WriteLine("the room have been cleaned");
        }
    }
}
