namespace SharpGuesser;

class Program {
    static void Main(string[] args) {

        
        //declare out variables 
        int difficultySelection = 0;
        int userInput = 0;
        bool gameIsRunning = true;
        int userPoints = 0;
        int userGuesses = 0;
        
        Random rnd = new Random();
        
        //UI interface 
        Console.WriteLine("=============================");
        Console.WriteLine("* Welcome to Sharp Guesser! *");
        Console.WriteLine("* A Number guessing Game *");
        Console.WriteLine("====By: Christopher M========");
        Console.WriteLine("Please select a difficulty");
        Console.WriteLine("1., Easy 2.,Medium 3.,Hard");
        
        //level selection 
        difficultySelection = Convert.ToInt32(Console.ReadLine());
        switch (difficultySelection) {
            
            case 1:
                userGuesses = 3;
                Console.WriteLine("You selected Easy! Let's begin.");
                break;
            case 2: 
                userGuesses = 5;
                Console.WriteLine("You selected Medium! Let's begin.");
                break;
            case 3:
                userGuesses = 7;
                Console.WriteLine("You selected Hard! Let's begin.");
                break;
        }
    
        //game loop 
        while ( gameIsRunning == true ) {
            
            if (difficultySelection == 1) {
                
                Console.WriteLine("=========================");
                Console.WriteLine("Enter a number between 1 and 3: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                int cpuGuess = rnd.Next(1, 4);
                if (userInput == cpuGuess) {

                    Console.WriteLine("You Guessed Correctly!");
                    userPoints += 1;
                    Console.WriteLine("You earned a point! " + userPoints);
                    
                } else {
                    
                    Console.WriteLine("No quite. Try again!");
                    userGuesses = userGuesses - 1;
                    Console.WriteLine("Guesses left: " + userGuesses);
                }
                
            }else if (difficultySelection == 2) {
                
                Console.WriteLine("=========================");
                Console.WriteLine("Enter a number between 1 and 6: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                
                int cpuGuess = rnd.Next(1, 7);
                if (userInput == cpuGuess) {

                    Console.WriteLine("You Guessed Correctly!");
                    userPoints += 1;
                    Console.WriteLine("You earned a point! " + userPoints);

                } else {
                    
                    Console.WriteLine("No quite. Try again!");
                    userGuesses = userGuesses - 1;
                    Console.WriteLine("Guesses left: " + userGuesses);

                }
                
            }else if (difficultySelection == 3) {
                
                Console.WriteLine("=========================");
                Console.WriteLine("Enter a number between 1 and 10: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                
                int cpuGuess = rnd.Next(1, 11);
                if (userInput == cpuGuess) {

                    Console.WriteLine("You Guessed Correctly!");
                    userPoints += 1;
                    Console.WriteLine("You earned a point! " + userPoints);
                    
                } else {
                    
                    Console.WriteLine("No quite. Try again!");
                    userGuesses = userGuesses - 1;
                    Console.WriteLine("Guesses left: " + userGuesses);

                }
            }

            //if we run out of guesses we exit the game
            if (userGuesses <= 0) {
                
                gameIsRunning = false;
                
            }
        }
        
        //ending message to the player
        Console.WriteLine("=========================");
        Console.WriteLine("Out of lives.");
        Console.WriteLine("Your score: " + userPoints);
        Console.WriteLine("=========================");
    }
}