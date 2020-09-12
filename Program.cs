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
                Console.WriteLine("Please select your floor preference (1-12)");
                var floorNumber = Int32.Parse(Console.ReadLine());
                if (floorNumber <= 5 && roomType == 1){
                    Console.WriteLine("Chose room # from 1 - 5 Cost is 45.00");
                }else if (floorNumber == 12) {
                    Console.WriteLine("We are sorry, a single bedroom is not available in this floor");
                }else {
                    Console.WriteLine("Chose floor # 6 - 11 cost 55.00");
                }
        //THIS IS WHERE I LEFT OFF - WRITING CONDITIONS FOR THE ROOM TYPE TWO COSTS. 
            }else if (roomType == 2) {
                Console.WriteLine("you chose 2");
                Console.WriteLine("Please select your floor preference (1-12)");

            }else if (roomType == 3) {
                Console.WriteLine("you chose 3");
                Console.WriteLine("Please select your floor preference (1-12)");

            } else{
                Console.WriteLine("invalid choise");
            }
            
        }
    }
}
