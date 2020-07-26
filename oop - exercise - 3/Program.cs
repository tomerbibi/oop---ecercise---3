using Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop___exercise___3
{
    class Program
    {
        static void Main(string[] args)
        {
            Suite royal = new Suite(1, 50);
            Guest jack = new Guest(337859034, "jack");
            Reception.CheckIn(jack);
            Reception.CheckOut(royal);
        }
    }
}
