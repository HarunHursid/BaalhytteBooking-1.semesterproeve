namespace BaalhytteBooking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assaignment 1
            Console.WriteLine();
            Console.WriteLine("Assaignment 1");
            ChildGroup CG1 = new ChildGroup(1, "1.A", "pusling", 25);
            ChildGroup CG2 = new ChildGroup(2, "3.R", "pusling", 28);
            ChildGroup CG3 = new ChildGroup(3, "4.B", "grævling", 20);

            Console.WriteLine(CG1);
            Console.WriteLine(CG2);
            Console.WriteLine(CG3);

            //Assaignment 2
            Console.WriteLine();
            Console.WriteLine("Assaignment 2");
            Reservation R1 = new Reservation(1, DateTime.Now, CG1);
            Reservation R2 = new Reservation(2, DateTime.Now, CG2);
            Reservation R3 = new Reservation(3, DateTime.Now, CG3);
            Reservation R4 = new Reservation(4, DateTime.Now, CG2);
            Console.WriteLine(R1);
            Console.WriteLine();
            Console.WriteLine(R2);
            Console.WriteLine(R3);

            //Assaignment 6
            Console.WriteLine();
            Console.WriteLine("Assaignment 6");
            Console.WriteLine();
            Reservations RS = new Reservations();
            RS.RegistrerReservation(R1);
            RS.RegistrerReservation(R2);
            RS.RegistrerReservation(R3);
            Console.WriteLine("printing all reservations:");
            RS.PrintAllReservations();
            Console.WriteLine();
            Console.WriteLine("getting reservation");
            Console.WriteLine(RS.GetReservation(3));
            Console.WriteLine();
            RS.RemoveReservation(R3);
            Console.WriteLine("removing reservation 3");
            Console.WriteLine();
            Console.WriteLine("printing all reservations again");
            Console.WriteLine();
            RS.PrintAllReservations();

            //Assaignment 7
            Console.WriteLine();
            Console.WriteLine("assaignment 7");
            Console.WriteLine($"number of reservations: {RS.NumberOfReservations(CG2)}");
        }

            //Assaignment 11
            enum age
            {
            pusling,
            tumling,
            pilt,
            væbner,
            grævling,
            seniorgræling
            }

    }
}
      
