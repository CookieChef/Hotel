using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Hello and welcome to the Carlington Hotel");
            Console.WriteLine("Special Offer, if you stay more than 4 nights get a 10% discount");
            Console.WriteLine("Please indicate the type of room you are looking for");
            Console.WriteLine("Type '1' for single, '2' for double and '3' for a suite");
            var roomType = Int32.Parse(Console.ReadLine());
            //Conditions if the user selects single room
            if (roomType == 1)
            {
                Console.WriteLine("You chose a single bedroom:");
                Console.WriteLine("Please select your floor preference (1-12)");
                var floorNumber = Int32.Parse(Console.ReadLine());
                //conditions if user selects floor 1-5
                if (floorNumber <= 5 && roomType == 1)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $45.00 a night");
                    var costRoom = 45.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a single bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a single bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                    //If user selects the 12th floor, gets an N/A message
                }
                else if (floorNumber == 12)
                {
                    Console.WriteLine("We are sorry, a single bedroom is not available in this floor");
                    //conditions if user selects floor 6 - 11
                }
                else if (floorNumber >= 6 && floorNumber <= 11)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $55.00 a night");
                    var costRoom = 55.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a single bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a single bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                    //if user selects an invalid floor number
                }
                else
                {
                    Console.WriteLine("sorry we dont have that option");
                }

                //Conditions if the user selects double room
            }
            else if (roomType == 2)
            {
                Console.WriteLine("you chose 2");
                Console.WriteLine("Please select your floor preference (1-12)");
                var floorNumber = Int32.Parse(Console.ReadLine());
                if (floorNumber <= 5 && roomType == 2)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $60.00 a night");
                    var costRoom = 60.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a double bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a double bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                }
                else if (floorNumber == 12)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $120.00 a night");
                    var costRoom = 120.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a double bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a double bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                }
                else if (floorNumber >= 6 && floorNumber <= 11)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $72.00 a night");
                    var costRoom = 72.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a double bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a double bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                }
                else
                {
                    Console.WriteLine("sorry we dont have that option available");
                }
                //Conditions if the user selects a suite
            }
            else if (roomType == 3)
            {
                Console.WriteLine("you chose 3");
                Console.WriteLine("Please select your floor preference (1-12)");
                var floorNumber = Int32.Parse(Console.ReadLine());
                if (floorNumber <= 5)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $130.00 a night");
                    var costRoom = 130.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a suite bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a suite bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                }
                else if (floorNumber == 12)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $350.00 a night");
                    var costRoom = 350.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a suite bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a suite bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                }
                else if (floorNumber >= 6 && floorNumber <= 11)
                {
                    Console.WriteLine("Chose floor number " + floorNumber + " the cost for that is $215.00 a night");
                    var costRoom = 215.00;
                    //Asks user how many nights they will be staying
                    Console.WriteLine("How many nights will you be staying?");
                    var numNights = Int32.Parse(Console.ReadLine());
                    var totalCost = numNights * costRoom;
                    //Calculate total based on the nights staying
                    //  if user stayes more than 4 nights, give a 10% off
                    if (numNights >= 4)
                    {
                        totalCost = (numNights * costRoom) - ((numNights * costRoom * 10) / 100);
                        Console.WriteLine("For a suite bedroom at $" + costRoom + " per night, for " + numNights + " nights and a %10 discount: ");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                        //if user stays less than 4 nights give regular rate
                    }
                    else
                    {
                        totalCost = numNights * costRoom;
                        Console.WriteLine("For a suite bedroom at $" + costRoom + " per night, for " + numNights + " nights");
                        Console.WriteLine("The total of your stay is $" + totalCost);
                    }
                }
                else
                {
                    Console.WriteLine("sorry we dont have that option available");
                }

            }
            else
            {
                Console.WriteLine("invalid choise");
            }

        }
    }
}
