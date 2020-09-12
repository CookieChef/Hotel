using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Carlington Hotel");
            Console.WriteLine("Please indicate the type of room you are looking for");
            Console.WriteLine("Type '1' for single, '2' for double and '3' for a suite");
            var roomType = Int32.Parse(Console.ReadLine());
            if(roomType == 1) { 
                Console.WriteLine("you chose 1");

            }else if (roomType == 2) {
                Console.WriteLine("you chose 2");
            }else if (roomType == 3) {
                Console.WriteLine("you chose 3");
            } else{
                Console.WriteLine("invalid choise");
            }
            
        }
    }
}
