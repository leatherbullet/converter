using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            const string CommandConvertRublesInDollars = "1";
            const string CommandConvertRublesInEuro = "2";
            const string CommandConvertDollarsInRubles = "3";
            const string CommandConvertDollarsInEuro = "4";
            const string CommandConvertEuroInRubles = "5";
            const string CommandConvertEuroInDollars = "6";
            const string CommandEndSesson = "7";

            float rublesInDollar = 90;
            float rublesInEuro = 100;
            float dollarsInEuro = 0.9f;
            float euroInDollars = 1.1f;
            float walletInRubles;
            float walletInDollars;
            float walletInEuro;
            float userChoice;

            string userInput;

            bool canCycleWork = true;

            Console.WriteLine("введите количество рублей:");
            walletInRubles = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите количество долларов:");
            walletInDollars = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("введите количество евро:");
            walletInEuro = Convert.ToSingle(Console.ReadLine());

            while (canCycleWork == true)
            {   
                Console.Clear();
                Console.WriteLine($"ваш баланс:\n{walletInRubles}рублей\n{walletInDollars}долларов\n{walletInEuro}евро\n");
                Console.WriteLine("выберете действие");
                Console.WriteLine($"{CommandConvertRublesInDollars}- поменять рубли на доллары");
                Console.WriteLine($"{CommandConvertRublesInEuro}- поменять рубли на евро");
                Console.WriteLine($"{CommandConvertDollarsInRubles}- поменять доллары на рубли");
                Console.WriteLine($"{CommandConvertDollarsInEuro}- поменять доллары на евро");
                Console.WriteLine($"{CommandConvertEuroInRubles}- поменять евро на рубли");
                Console.WriteLine($"{CommandConvertEuroInDollars}- поменять евро на доллары");
                Console.WriteLine($"{CommandEndSesson}- выход");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandConvertRublesInDollars://1 
                        Console.Clear();
                        Console.WriteLine("сколько вы хотите купить долларов");
                        userChoice = Convert.ToSingle(Console.ReadLine()); 
                        
                        if(userChoice <= walletInRubles / rublesInDollar )
                        {
                            walletInDollars = walletInDollars + userChoice;
                            walletInRubles -= userChoice * rublesInDollar;
                            Console.WriteLine("операция прошла успешно");
                        }
                        else if (walletInRubles < rublesInDollar * userChoice)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertRublesInEuro://2 
                        Console.Clear();
                        Console.WriteLine("сколько евро вы хотите купить");
                        userChoice = Convert.ToSingle(Console.ReadLine());

                        if (userChoice <= walletInRubles / rublesInEuro)
                        {
                            walletInEuro += userChoice;
                            walletInRubles -= userChoice * rublesInEuro;
                            Console.WriteLine("операция прошла успешно");
                        }
                        else if (walletInRubles < userChoice * rublesInEuro)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertDollarsInRubles://3 
                        Console.Clear();
                        Console.WriteLine("сколько рублей вы хотите купить");
                        userChoice = Convert.ToSingle(Console.ReadLine());

                        if (userChoice <= walletInDollars * rublesInDollar)
                        {
                            walletInRubles += userChoice;
                            walletInDollars -= userChoice / rublesInDollar;
                            Console.WriteLine("операция прошла успешно");
                        }
                        else if (walletInDollars < userChoice / rublesInDollar)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertDollarsInEuro://4 
                        Console.Clear();
                        Console.WriteLine("сколько евро вы хотите купить");
                        userChoice = Convert.ToSingle(Console.ReadLine());

                        if (userChoice <= walletInDollars * dollarsInEuro)
                        {
                            walletInEuro += userChoice;
                            walletInDollars -= userChoice * euroInDollars;
                            Console.WriteLine("операция прошла успешно");
                        }
                        else if (walletInDollars < userChoice * euroInDollars)
                        { 
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertEuroInRubles://5 
                        Console.Clear();
                        Console.WriteLine("сколько рублей вы хотите купить");
                        userChoice = Convert.ToSingle(Console.ReadLine());

                        if (userChoice <= walletInEuro * rublesInEuro)
                        {
                            walletInRubles += userChoice;
                            walletInEuro -= userChoice / rublesInEuro;
                            Console.WriteLine("операция прошла успешно");
                        }
                        else if (walletInEuro < userChoice / rublesInEuro)
                        { 
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandConvertEuroInDollars://6 
                        Console.Clear();
                        Console.WriteLine("сколько долларов вы хотите купить");
                        userChoice = Convert.ToSingle(Console.ReadLine());

                        if (userChoice <= walletInEuro * euroInDollars)
                        {
                            walletInDollars += userChoice;
                            walletInEuro -= userChoice * dollarsInEuro;
                            Console.WriteLine("операция прошла успешно");
                        }
                        else if (walletInEuro < euroInDollars * userChoice)
                        {
                            Console.WriteLine("на вашем балансе не достаточно средств");
                            Console.ReadKey();
                        }
                        break;

                    case CommandEndSesson:
                        canCycleWork = false;
                        break;

                    default:
                        Console.WriteLine("неверный ввод");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
