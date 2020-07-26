using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop___exercise___3
{
    public class Guest
    {
        private int _id;
        private string _name;

        public Guest(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int GetId()
        {
            return _id;
        }
        public string GetName()
        {
            return _name;
        }

        public override string ToString()
        {
            return $"name: {_name}, id: {_id}";
        }
    }
}
