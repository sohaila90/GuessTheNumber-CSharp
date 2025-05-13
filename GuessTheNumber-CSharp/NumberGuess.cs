namespace GuessTheNumber_CSharp;

public class NumberGuess
{
    public void Run()
    {
       Random numberGuess = new Random();
       int num = numberGuess.Next(1, 10);
       Start(num);


    }
    public void Start(int num)
    {
        Console.WriteLine($"Gjett riktig tall: {num}" );
        int.TryParse(Console.ReadLine(),out int numGuess);
        if (numGuess == num)
        {
            Console.WriteLine("Riktig!");
            Console.WriteLine("Vil du spille på nytt?Ja/Nei");
            var input = Console.ReadLine();
            if (input == "ja")
            {
                Run();
            } 
        }
        
        else if (numGuess > num)
        {
            Console.WriteLine("Det var høyt, prøv igjen.");
            Start(num);
        }
        else if (numGuess < num)
        {
            Console.WriteLine("Det var for lavt, prøv igjen.");
            Start(num);
        }else
        {
            Console.WriteLine("Feil!");
            Start(num);
        }
    }
}

// Oppgave: Gjett Tallet!
// Lag et program hvor brukeren skal gjette et tilfeldig
// tall mellom 1-100
// Hver gang brukeren skriver inn et tall vil man få svar fra
// programmet om man
// må høyere eller lavere, helt til man gjetter riktig tall.
// Da skal man få spørsmål om man vil spille på nytt