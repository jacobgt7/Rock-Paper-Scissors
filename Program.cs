using System;

//function that prints out score and options
//read line for option input
//function that prints hand animations
//read line to continue
//function? to print win or lose

//inside a while loop
//user inputs option
//computer option randomly generated
//the two compared
//logic assigns a point or doesn't
//after while loop display victory/defeat message
//program ends

void Main()
{
    int playerScore = 0;
    int computerScore = 0;

    Console.WriteLine($@"
    ---------------------------
    | Player: {playerScore} | Computer: {computerScore} |
    ---------------------------
    What would you like to throw?
    1) Rock
    2) Paper
    3) Scissors
    ");

    int playerChoice = int.Parse(Console.ReadLine());

}

Main();