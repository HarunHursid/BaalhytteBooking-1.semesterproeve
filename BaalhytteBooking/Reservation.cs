using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaalhytteBooking
{
    public class Reservation
    {
        private int _id;
        private DateTime _datetime;
        private ChildGroup _childGroup;



        public Reservation(int Id,DateTime dateTime,ChildGroup childGroup) 
        { 
            _id = Id;
            _datetime = dateTime;
            _childGroup = childGroup;
        }

        public int Id 
        { 
            get { return _id; }
            set { _id = value; }
        }
        public DateTime DateTime 
        { 
            get { return _datetime; }
            set { _datetime = value; }
        }
        public ChildGroup ChildGroup 
        { 
            get { return _childGroup; }
            set { _childGroup = value; }
        }


        public override string ToString() 
        { 
            return $"\nReservation Id: {Id}\ntime of day: {DateTime}\nChildgroup: {ChildGroup}";
        }
    }
}
