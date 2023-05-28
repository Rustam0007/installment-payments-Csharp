using Instalments.Onbording;

namespace Instalments;

public class Sellers
{
    public void Seller()
    {
        var db = new Query();
        
        Console.WriteLine("Вы можете тобавить у нас в магазине товары в таких категориях: \n ");
        var category = new OnbordingCategory();
        var categoryId = category.Category();

        while (true)
        {
            Console.Write("Введите название продукта который хотите добавить: ");
            var productTitle = Console.ReadLine();
        
            Console.Write("Введите цену товара: ");
            var input = Console.ReadLine();
            if (float.TryParse(input, out var price))
            {
                Console.WriteLine(
                    db.Insert<Product>(productTitle, price, categoryId, "products")
                        ? "Успешно! Ваш товар был добален у нас в магазине. Чтобы посмотреть зайдите как покупатель на наш сервис"
                        : "Упс! Что-то пошло не так попробуйте заново!");
                break;
            }
            Console.Clear();
            Console.WriteLine("Пожалуйста введите корректную цену!");
        }
    }
}