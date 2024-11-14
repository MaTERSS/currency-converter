/* У пользователя есть баланс в каждой из представленных валют. 
 * Он может попросить сконвертировать часть баланса с одной валюты в другую. 
 * Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y.
 * Курс конвертации должен быть просто прописан в программе. 

По имени переменной курса конвертации должно быть понятно, из какой валюты в какую валюту конвертируется.
В консольном меню будет 6 команд конвертации, на каждый обмен. И для каждого обмена своя переменная с коэффициентом обмена.
Валюта не может быть отрицательной и это стоит учитывать.
Программа должна завершиться тогда, когда это решит пользователь.

В каждом кейсе должна быть одна операция. либо деление, либо умножение.*/
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            const string CommandShowFromRubToUSD = "1";
            const string CommandShowFromRubToEur = "2";
            const string CommandShowFromUSDToRub = "3";
            const string CommandShowFromUSDToEur = "4";
            const string CommandShowFromEurToRub = "5";            
            const string CommandShowFromEurToUSD = "6";
            const string CommandClearConsole = "7";
            const string CommandExit = "8";
                        
            double rubToUsdExchangeRate = 0.010;
            double rubToEurExchangeRate = 0.0096;
            double usdToRubExchangeRate = 98.15;
            double usdToEurExchangeRate = 0.94;
            double eurToRubExchangeRate = 104.08;
            double eurToUsdExchangeRate = 1.06;
            double balanceInRub = 10000;
            double balanceInUsd = 100;
            double balanceInEur = 100;
            int inputAmountCurrency;


            bool isWork = true;        

            while (isWork)
            {
                Console.WriteLine($"Здравствуйте, у вас на балансе {balanceInRub} руб, {balanceInUsd} долларов США, {balanceInEur} евро. \nВы можете выполнить конвертацию валюты.Выберете нужный вариант:\n1.Конвертация из рублей в доллары США.\n2.Конвертация из рублей в евро.\n3.Конвертация из долларов США в рубли.\n4.Конвертация из долларов США в евро.\n5.Конвертация из евро в рубли.\n6.Конвертация из евро в доллары США.\n7.Очистить консоль.\n8.Завершение работы.");

                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case CommandShowFromRubToUSD:                          
                        Console.WriteLine("Введите сумму для конвертации:");
                        inputAmountCurrency = Convert.ToInt32(Console.ReadLine());
                                                
                        if (inputAmountCurrency >= 0 && inputAmountCurrency <= balanceInRub) 
                        {
                            balanceInUsd += inputAmountCurrency * rubToUsdExchangeRate;
                            balanceInRub -= inputAmountCurrency;                        
                        }
                        else
                        {   
                            Console.WriteLine("Введено некоректное значение или на балансе недостаточно средств.");
                        }
                        break;                       

                    case CommandShowFromRubToEur:
                        Console.WriteLine("Введите сумму для конвертации:");
                        inputAmountCurrency = Convert.ToInt32(Console.ReadLine());

                        if (inputAmountCurrency >= 0 && inputAmountCurrency <= balanceInRub)
                        {
                            balanceInEur += inputAmountCurrency * rubToEurExchangeRate;
                            balanceInRub -= inputAmountCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Введено некоректное значение или на балансе недостаточно средств.");                            
                        }
                        break;

                    case CommandShowFromUSDToRub:
                        Console.WriteLine("Введите сумму для конвертации:");
                        inputAmountCurrency = Convert.ToInt32(Console.ReadLine());

                        if (inputAmountCurrency >= 0 && inputAmountCurrency <= balanceInUsd)
                        {
                            balanceInRub += inputAmountCurrency * usdToRubExchangeRate;
                            balanceInUsd -= inputAmountCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Введено некоректное значение или на балансе недостаточно средств.");                           
                        }
                        break;

                    case CommandShowFromUSDToEur:
                        Console.WriteLine("Введите сумму для конвертации:");
                        inputAmountCurrency = Convert.ToInt32(Console.ReadLine());

                        if (inputAmountCurrency >= 0 && inputAmountCurrency <= balanceInUsd)
                        {
                            balanceInEur += inputAmountCurrency * usdToEurExchangeRate;
                            balanceInUsd -= inputAmountCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Введено некоректное значение или на балансе недостаточно средств.");                           
                        }
                        break;

                    case CommandShowFromEurToRub:
                        Console.WriteLine("Введите сумму для конвертации:");
                        inputAmountCurrency = Convert.ToInt32(Console.ReadLine());

                        if (inputAmountCurrency >= 0 && inputAmountCurrency <= balanceInEur)
                        {
                            balanceInRub += inputAmountCurrency * eurToRubExchangeRate;
                            balanceInEur -= inputAmountCurrency;
                        }
                        else
                        {
                            Console.WriteLine("Введено некоректное значение или на балансе недостаточно средств.");                            
                        }
                        break;

                    case CommandShowFromEurToUSD:
                        Console.WriteLine("Введите сумму для конвертации:");
                        inputAmountCurrency = Convert.ToInt32(Console.ReadLine());

                        if (inputAmountCurrency >= 0 && inputAmountCurrency <= balanceInEur)
                        {
                            balanceInUsd += inputAmountCurrency * eurToUsdExchangeRate;
                            balanceInEur -= inputAmountCurrency;                            
                        }
                        else
                        {
                            Console.WriteLine("Введено некоректное значение или на балансе недостаточно средств.");                            
                        }
                        break;

                    case CommandClearConsole:
                        Console.Clear();
                        break;

                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Завершение работы...");
                        break;

                    default:
                        Console.WriteLine("Извините такая команда отсутствует...");
                        break;
                }
            }
        }
    }
}