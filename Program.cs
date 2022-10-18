// Richard Johnson
// 10-18-22
//

Console.Clear();
bool playAgain = true;
bool isNumber;
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
        Console.WriteLine(" ");
        playAgain = false;
    }
    else if(yesNo == "YES")
    {
        // This will run if the user says YES
        Console.WriteLine(" ");
        Console.WriteLine("Alright.");
        Console.Write("Please enter a first number: ");
        // The two lines below will take the user's input and verify that it is a number
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
                        // This will run if the second input is valid
                        if(numOne > numTwo)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"{numOne} is greater than {numTwo}");
                            Console.WriteLine($"{numTwo} is less than {numOne}");
                            Console.WriteLine(" ");
                        }
                        else if
                        (numOne < numTwo)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"{numOne} is less than {numTwo}");
                            Console.WriteLine($"{numTwo} is greater than {numOne}");
                            Console.WriteLine(" ");
                        }
                        else
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine($"{numOne} is equal to {numTwo}");
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine(" ");
                    }
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Invalid Input");
                Console.WriteLine(" ");
            }


    }
    else
    {
        Console.WriteLine(" ");
        Console.WriteLine("Invalid input");
        Console.WriteLine(" ");
    }
}