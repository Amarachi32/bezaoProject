/*
PSEUDO CODE FOR A GUESIING GAME

1) generate a random number say from 1 to 100
2) a user inputs a guessNumber
3) use a while loop to validate the guessNumber
4) if the guessNumber is valid compare it with the secret number; 
5)  If the guessNumber is correct display the secret number
6) If the guessNumber is lower than the secret number display that is too low
) if the guessNumber is higher than the secret number display that the guess is high
8) continue to input guess using while loop until the secret number is guessed correctly 
9) once you get the value it display the secret number and number of attempts you make



*/

namespace guessGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(100);
        
            
            Console.WriteLine("Input number between 1-100: ");
            int guessNumber = Convert.ToInt32(Console.ReadLine());
            int numberOfTries = 1;
            
            

            while ((guessNumber <= 100) && (guessNumber != secretNumber))
            {
                numberOfTries++;
                Console.WriteLine("wrong guess; try again {0}:", guessNumber > secretNumber ? "too high": "too low");
                
                guessNumber = Convert.ToInt32(Console.ReadLine());
                
                
                
                    /* checkmate the inputed values*/
                // numberOfTries--;
                // Console.WriteLine("invalid input; {0}:", guessNumber > 100 ? "same value": "out of range");
                // guessNumber = Convert.ToInt32(Console.ReadLine());

               
            }
                 Console.WriteLine($" you won; the secret number is {secretNumber}");
                 Console.WriteLine(" thank you for playing; it took you {0} attempts", numberOfTries);
                 
          
        }
    }
}





