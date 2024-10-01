using System.Text.Unicode;
using System;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Currency Converter.");
            Console.WriteLine();//this is just to make the console more readable

            Console.WriteLine("State an amount in SEK to convert.");
            int userInputSek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();//this is just to make the console more readable

            Console.WriteLine("Which currency you want to convert to? (Type 1, 2, 3 or 4)");
            Console.WriteLine("1. EUR");
            Console.WriteLine("2. GBP");
            Console.WriteLine("3. JPY");
            Console.WriteLine("4. USD");

            Console.WriteLine();//this is just to make the console more readable

            string selectedCurrency = Console.ReadLine()!;

            Console.WriteLine();//this is just to make the console more readable

            double convertedAmount = 0;

            switch (selectedCurrency)
            {
                case "1":
                    convertedAmount = userInputSek * 0.08;
                    Console.WriteLine($"{ userInputSek} SEK is { convertedAmount } EUR");
                    break;

                case "2":
                    convertedAmount = userInputSek * 0.07;
                    Console.WriteLine($"{userInputSek} SEK is {convertedAmount} GBP");
                    break;

                case "3":
                    convertedAmount = userInputSek * 13.22;
                    Console.WriteLine($"{userInputSek} SEK is {convertedAmount} JPY");
                    break;

                case "4":
                    convertedAmount = userInputSek * 0.09;
                    Console.WriteLine($"{userInputSek} SEK is {convertedAmount} USD");
                    break;

                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            
        }
    }
}
