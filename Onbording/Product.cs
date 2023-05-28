namespace Instalments.Onbording;

public class OnbordingProduct
{
    public int Product(int categoryId)
    {
        var db = new Query();
        var products = new List<Product>(db.Get<Product>($"SELECT id, title, price FROM products WHERE category_id = {categoryId}"));
        foreach (var product in products)
        {
            Console.WriteLine($"Название: {product.Title}. Цена: {product.Price}. ID товара: {product.Id}.");
        }

        var productId = 0;
        while (true)
        {
            Console.Write("\nВведите iD товара для выбора (для выхода введите 'Z' для возврата на категории введите 'W'): ");
            var input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "Z":
                    Console.WriteLine("\nОх жаль что уходите... ):");
                    Environment.Exit(0);
                    break;
                case "W":
                    Console.Clear();
                    return productId;
            }

            if (int.TryParse(input, out productId) && products.Exists(p => p.Id == productId))
            {
                break;
            }

            productId = 0;
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");

        }
        
        Console.Clear();
        return productId;
    }
}