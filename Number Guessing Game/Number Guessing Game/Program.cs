class Program
{
    static void Main(string[] args)
    {
        int number;
        int numberGuess;
        int tries = 0;
        Random random = new Random();

        
         Console.WriteLine("A number was generated, guess the number");
         number = random.Next(1, 11);
         Guess();
         void Guess()
         {
              Console.WriteLine(tries);
              Console.WriteLine("make a guess" + number);
              numberGuess = Convert.ToInt32(Console.ReadLine());
              if (numberGuess == number)
              {
                  Console.WriteLine("youre right, you win");
                  Console.WriteLine("you got it in " + tries + " tries");
                  return;
              }
              else if (numberGuess > number)
              {
                  Console.WriteLine("its a lower number");
                  tries++;
                  Guess();
              }
              else if (numberGuess < number)
              {
                  Console.WriteLine("its a higher number");
                  tries++;
                  Guess();
              }
         }
    }
}

