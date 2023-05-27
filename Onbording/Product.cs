namespace Instalments.Onbording;

public class OnbordingProduct
{
    public int Product(int categoryId)
    {
        var db = new Query();
        var count = db.Get<Product>($"SELECT * FROM products WHERE category_id = {categoryId}").Count();
        Console.WriteLine($"\nУ нас в этом разделе {count} товара: \n");
        var productsData = db.Get<Product>($"SELECT id, title, price FROM products WHERE category_id = {categoryId}");
        var products = new List<Product>(productsData);
        foreach (var product in products)
        {
            Console.WriteLine($"Название: {product.Title}. Цена: {product.Price}. ID товара: {product.Id}.");
        }
            
        var productId = 0;
        while (true)
        {
            Console.Write("\nВведите iD товара для выбора (для выхода введите 'Z' для возврата на категории введите 'W'): ");
            var input = Console.ReadLine();
            switch (input?.ToUpper())
            {
                case "Z":
                    Console.WriteLine("\nОх жаль что уходите... ):");
                    Environment.Exit(0);
                    break;
                case "W":
                    Console.Clear();
                    productId = 0;
                    return productId;
            }

            if (int.TryParse(input, out productId))
            {
                if (products.Exists(p => p.Id == productId))
                {
                    break;
                }
               
            }

            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");

        }
        
        Console.Clear();
        return productId;
    }
}