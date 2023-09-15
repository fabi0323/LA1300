using RandomNumber.V2;
using System;

namespace Random_Number_Generier_Ding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lastGuesses = new int[10];
           
            for (int i = 0; i < lastGuesses.Length; i++)
            {
                lastGuesses[i] = Zufall.Generator();
            }

            int x;
            bool running = true;
            bool start = true;
            int highScore = 20;

            while (running)
            {
                if (start)
                { 
                    x = Zufall.Generator();
                    start = false;
                }
                else
                {
                    x = Algorithm.Algorythmus(lastGuesses);
                }
                Console.WriteLine("Zahl eingeben: ");
                Eingaben.Input(x, ref running, ref lastGuesses,ref highScore);
                
            }
            
        }
    }

    public class Zufall
    {
        public static int Generator()
        {
            int Zahl = new Random().Next(1, 101);
            return Zahl;
        }
    }

    public class Eingaben
    {
        public static void Input(int x, ref bool running, ref int[] lastGuesses,ref int highScore)
        {
            int guesses = 0;
            

            while (running)
            {
                string input = Console.ReadLine();
                guesses++;

                try
                {
                    int y = int.Parse(input);

                    for (int i = lastGuesses.Length - 1; i >= 1; i--)
                    {
                        lastGuesses[i] = lastGuesses[i - 1];
                    }
                    lastGuesses[0] = y;

                    if (y == x)
                    {
                        Console.WriteLine("Richtig");
                        Console.WriteLine("Anzahl Versuche: " + guesses);

                        if (guesses < highScore)
                        {
                            highScore = guesses;
                            Console.WriteLine("Neuer Highscore " + highScore);
                        }
                        else
                        {
                            Console.WriteLine("Bisheriger Highscore " + highScore);
                        }
                        guesses = 0;
                        running = Replay(ref x);
                        break;
                    }
                    else if (y < x)
                    {
                        Console.WriteLine("Zahl zu klein");
                    }
                    else if (y > x)
                    {
                        Console.WriteLine("Zahl zu Groß");
                    }
                }
                catch
                {
                    Console.WriteLine("Ungültige Eingabe");
                }
            }
        }

        public static bool Replay(ref int x)
        {
            Console.WriteLine("P drücken, um nochmal zu spielen");
            string input = Console.ReadLine();

            if (input.Equals("p", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
