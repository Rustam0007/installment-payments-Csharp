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
                Console.Write($"Вы продавец или покупатель? Для выбора введите 'S' продавец или 'C' покупатель: ");
                var choiceInput = Console.ReadLine().ToUpper();
                switch (choiceInput)
                {
                    case "S":
                    {
                        var seller = new Sellers();
                        seller.Seller();
                        break;
                    }
                    case "C":
                    {
                        var customer = new Customers();
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