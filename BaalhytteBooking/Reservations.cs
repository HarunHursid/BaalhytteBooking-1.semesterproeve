using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BaalhytteBooking
{
    public class Reservations
    {
        private Dictionary<int, Reservation> _reservations;
        private int _id;


        public Reservations() 
        { 
            _reservations = new Dictionary<int, Reservation>();
            
        }

        public Reservations(int Id, Dictionary<int, Reservation> reservations)
        {
            _reservations = reservations;
            _id = Id;
        }

        public int Id
        { 
            get { return _id; }
            set { _id = value; }
        }


        public void RegistrerReservation(Reservation reservation)
        {
            _reservations.Add(reservation.Id, reservation);
        }
        public Reservation GetReservation(int id)
        {
            if (_reservations == null)
                return null;

            foreach (Reservation r in _reservations.Values)
            {
                if (r.Id == id)
                    return r;
            }
            return null;
            //return _reservations[id];
        }

        public void PrintAllReservations()
        {
            if (_reservations == null)
                return;

            foreach (Reservation r in _reservations.Values)
            {
                Console.WriteLine(r);
            }
            //return _reservations;
        }

        public void RemoveReservation(Reservation reservation)
        {
            if (_reservations != null)
            {
                _reservations.Remove(reservation.Id);
            }
        }

        public int NumberOfReservations(ChildGroup CG)
        { 
            int result = 0;

            if (_reservations == null)
                return result;

            foreach (Reservation R in _reservations.Values)
            {
                if (R.Id > 0)
                 result++; 
            }
            return result;
        }

        
    }
}
