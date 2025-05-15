namespace GuessTheNumber_CSharp;

public class NumberGuess2
{

    public void Run()
    {
        Random randomNumber = new Random();
        int correctNumbers = randomNumber.Next(1, 1);
        int guess = 0; // for å bruke til å gjette
        int attempts = 0; // brukes til hvor mange ganger man har gjettet
        Console.WriteLine("Welcome to: Guess the number");
        Console.WriteLine("Please enter a number between 1 and 10");
        while (true) // denne får det som er under her til å kjøre hele tiden
        {
            
            string input = Console.ReadLine(); // lagrer det user skriver inn
            // Start(num);
            GuessNumber(input, correctNumbers, attempts, guess); // disse para sender til guessnumber func
        }
    }

    private static void GuessNumber(string input, int correctNumbers, int attempts, int guess) // denne tar imot fra run()
    {

        int inputAsNum = int.Parse(input); // kommer inn fra string input, her har vi endret fra string til int

        if (inputAsNum == correctNumbers)
        {
            Console.WriteLine("Yess, correct!");

        }
        else if (inputAsNum > correctNumbers)
        {
            Console.WriteLine("Too high");
        }
        else if (inputAsNum < correctNumbers)
        {
            Console.WriteLine("Too low");
        }

}

    // public  void Start(int num)
    // {
    // Console.WriteLine("Gjett riktig tall:");
    // string readLine = Console.ReadLine();
    // Console.WriteLine(readLine);
    //
    // int guessNum = 0;
    // if (guessNum > num)
    // {
    //     Console.WriteLine("Det var for høyt");
    // }
    // else if (guessNum < num)
    // {
    //     Console.WriteLine("Det var for lavt");
    // }
    // else if (guessNum == num)
    // {
    //     Console.WriteLine("Riktig!");
    // }
    // else
    // {
    //     int input = 0;
    //     if (guessNum == num)
    //     {
    //     Console.WriteLine("Riktig!");
    //     }
    // }
    // }
    }
    

