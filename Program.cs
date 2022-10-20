// Richard Johnson
// 10-18-22
//

Console.Clear();
bool playAgain = true;
bool isNumber;
bool numInput = true;
int numOne = 0;
int numTwo = 0;

//This is where the loop begins
while(playAgain == true)
{
    // 
    Console.WriteLine("Would you like to compare two numbers, and see which one is greater than or less than the other?");
    Console.Write("YES or NO: ");
    string yesNo = Console.ReadLine();
    yesNo = yesNo.ToUpper();

    if(yesNo == "NO")
    {
        // This will run if the user says NO
        Console.WriteLine(" ");
        Console.WriteLine("Then Goodbye");
        playAgain = false;
    }
    else if(yesNo == "YES")
    {
        // This will run if the user says YES
        Console.WriteLine(" ");
        Console.WriteLine("Alright.");
        Console.Write("Please enter a first number: ");
        // The two lines below will take the user's input and verify that it is a number
        numInput = true;
        while(numInput == true)
        {
        string inputOne = Console.ReadLine();
        isNumber = Int32.TryParse(inputOne, out numOne);
            if(isNumber == true)
            {
                // This will run if the number is valid
                Console.WriteLine(" ");
                Console.Write("Now enter a second number: ");
                string inputTwo = Console.ReadLine();
                isNumber = Int32.TryParse(inputTwo, out numTwo);
                    if(isNumber == true)
                    {
                        // If the second input is valid, the program will continue and print the inputs in the console
                        if(numOne > numTwo)
                        {
                            // If numOne is greater than numTwo, the top line will show the greater number before
                            // the lower one, while the bottom line will show the lower number first
                            Console.WriteLine(" ");
                            Console.WriteLine($"{numOne} is greater than {numTwo}");
                            Console.WriteLine($"{numTwo} is less than {numOne}");
                            Console.WriteLine(" ");
                            numInput = false;
                        }
                        else if
                        (numOne < numTwo)
                        {
                            // If numOne is less than numTwo, the top like will show the lower number before the
                            // greater number, and the bottom line will show the greater number first
                            Console.WriteLine(" ");
                            Console.WriteLine($"{numOne} is less than {numTwo}");
                            Console.WriteLine($"{numTwo} is greater than {numOne}");
                            Console.WriteLine(" ");
                            numInput = false;
                        }
                        else
                        {
                            // If numOne is equal to numTwo, there will only be one line with them being printed,
                            // as there is no need to have multiple lines when both inputs are equal numbers
                            Console.WriteLine(" ");
                            Console.WriteLine($"{numOne} is equal to {numTwo}");
                            Console.WriteLine(" ");
                            numInput = false;
                        }
                    }
                    else
                    {
                        //
                        Console.WriteLine(" ");
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine(" ");
                    }
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Input");
                Console.Write("Please enter a valid number: ");
            }
        }
            


    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Invalid input");
        Console.WriteLine(" ");
    }
}