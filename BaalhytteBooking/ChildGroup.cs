using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaalhytteBooking
{
    public class ChildGroup
    {
        private int _id;
        private string _name;
        private string _agegroup;
        private int _participans;

        public ChildGroup(int id, string name, string agegroup, int participans)
        {
            _id = id;
            _name = name;
            _agegroup = agegroup;
            _participans = participans;
        }

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; }
        }
            
        public string Name
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public string Agegroup
        { 
            get { return _agegroup; }
            set{_agegroup = value;} 
        }

        public int participans
        { 
            get { return _participans; }
            set { _participans = value;} 
        }


        public override string ToString() 
        { 
            return $"\nGroups Id is: {Id}\nGroups name is: {Name}\nGroups age is: {Agegroup}\nNumber of participans: {participans}";
        }
    }
}
