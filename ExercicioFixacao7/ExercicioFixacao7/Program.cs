using System;

namespace ExercicioFixacao7
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalRooms = 10;

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            Rent[] vector = new Rent[10];

            Console.WriteLine("---- Rent ----");
            Console.WriteLine();
            
            string name;
            string email;
            int room;

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Rent #" + (i+1));
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());

                vector[room] = new Rent
                {
                    Name = name,
                    Email = email,
                    NumberRoom = room
                };
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Bussy Rooms:");
            
            for(int i = 0; i < totalRooms; i++)
            {
                if (vector[i] != null)
                {
                    Console.WriteLine(vector[i].NumberRoom
                        + ": "
                        + vector[i].Name
                        + ", "
                        + vector[i].Email);
                }
            }

        }
    }
}
