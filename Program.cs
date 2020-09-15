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
        //Conditions if the user selects single room
            if(roomType == 1) { 
                Console.WriteLine("you chose 1");
                Console.WriteLine("Please select your floor preference (1-12)");
                var floorNumber = Int32.Parse(Console.ReadLine());
                if (floorNumber <= 5 && roomType == 1){
                    Console.WriteLine("Chose room # from 1 - 5 Cost is 45.00");
                    var costRoom = 45.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if(numNights >= 4){
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10)/100);
                        
                         Console.WriteLine("The total of your stay is " + totalCost);
                    //if user stays less than 4 nights give regular rate
                    }else {
                        totalCost = numNights * costRoom;
                         Console.WriteLine("The total of your stay is " + totalCost);
                    }
        
                }else if (floorNumber == 12) {
                    Console.WriteLine("We are sorry, a single bedroom is not available in this floor");
                }else if (floorNumber >= 6 && floorNumber <= 11) {
                    Console.WriteLine("single, floor 6-11 cost 55.00");
                }else {
                    Console.WriteLine("sorry we dont have that option");
                }

        //Conditions if the user selects double room
            }else if (roomType == 2) {
                Console.WriteLine("you chose 2");
                Console.WriteLine("Please select your floor preference (1-12)");
                var floorNumber = Int32.Parse(Console.ReadLine());
                if(floorNumber <= 5 && roomType == 2) {
                    Console.WriteLine("double room, floor 1-5 cost 60.00");
                }else if (floorNumber == 12) {
                    Console.WriteLine("double, 12th floor cost is 120.00");
                }else if (floorNumber >= 6 && floorNumber <= 11){
                    Console.WriteLine("double, 6-11 72.00");
                }else {
                    Console.WriteLine("sorry we dont have that option available");
                }
        //Conditions if the user selects a suite
            }else if (roomType == 3) {
                Console.WriteLine("you chose 3");
                Console.WriteLine("Please select your floor preference (1-12)");
                var floorNumber = Int32.Parse(Console.ReadLine());
                if(floorNumber <= 5) {
                    Console.WriteLine("suite room, floor 1-5 cost 130.00");
                }else if (floorNumber == 12) {
                    Console.WriteLine("suite, 12th floor cost is 350.00");
                }else if (floorNumber >= 6 && floorNumber <= 11){
                    Console.WriteLine("suite, 6-11 215.00");
                }else {
                    Console.WriteLine("sorry we dont have that option available");
                }

            } else{
                Console.WriteLine("invalid choise");
            }
            
        }
    }
}
