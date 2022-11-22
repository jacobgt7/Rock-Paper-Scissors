using System;


void Main()
{
    int playerScore = 0;
    int computerScore = 0;

    while (playerScore < 3 && computerScore < 3)
    {
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

        int computerChoice = new Random().Next(1, 4);

        showHand(playerChoice);

        Console.WriteLine("    VS");

        showHand(computerChoice);

        if ((playerChoice == 1 && computerChoice == 3) || (playerChoice == 2 && computerChoice == 1) || (playerChoice == 3 && computerChoice == 2))
        {
            playerScore++;
        }
        else if (playerChoice == computerChoice)
        {
            playerScore += 0;
        }
        else
        {
            computerScore++;
        }


    }

    Console.WriteLine(playerScore == 3 ? "*** YOU WIN!!! ***" : "*** YOU LOSE ***");
}

Main();




void showHand(int choice)
{
    if (choice == 1)
    {
        Console.WriteLine(@"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
        ");
    }
    else if (choice == 2)
    {
        Console.WriteLine(@"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
        ");
    }
    else if (choice == 3)
    {
        Console.WriteLine(@"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
        ");
    }
}