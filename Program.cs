using Instalments.Onbording;

namespace Instalments;

    public class Program
    {
        static void Main(string[] args)
        {
            var db = new Query();

            Console.WriteLine("Добро пожаловать на магазин AlifBankShop");
            Console.WriteLine("Запомните все команды которые будут использоватся в приложении вы должны вводит английскими буквами!");

            while (true)
            {
                Console.Write("Вы продавец или покупатель? Для выбора введите 'S' продавец или 'C' покупатель: ");
                var choiceInput = Console.ReadLine();
                switch (choiceInput?.ToUpper())
                {
                    case "S":
                    {
                        var seller = new OnbordingSeller();
                        seller.Seller();
                        break;
                    }
                    case "C":
                    {
                        var customer = new OnbordingCustomer();
                        customer.Customer();
                        break;
                    }
                    default:
                    {
                        Console.Clear();
                        Console.WriteLine("Выберите правильную команду пожалуйста!");
                        continue;
                    }
                }
                break;
            }
        }
    }