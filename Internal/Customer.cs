using Instalments.Onbording;

namespace Instalments;

public class OnbordingCustomer
{
    public void Customer()
    {
        var db = new Query();
        while (true)
        {
            Console.WriteLine("У нас в магазине есть такие категории:\n");
            var category = new OnbordingCategory();
            var categoryId = category.Category();
                
            var count = db.Get<Product>($"SELECT * FROM products WHERE category_id = {categoryId}").Count();
            Console.WriteLine($"\nУ нас в этом разделе {count} товара: \n");
            var product = new OnbordingProduct();
            var productId = product.Product(categoryId);
            if (productId == 0)
            {
                continue;
            }
                
            Console.WriteLine("\nНа какой срок вы хотите брать товар?\n");
            var period = new OnbordingPeriod();
            var periodId = period.Period(categoryId);
            if (periodId == 0)
            {
                continue;
            }
            
            var price = db.GetById<Product>(productId, "products");
            var commission = db.GetById<Periods>(periodId, "period");
            
            
            var calculate = new Calculate();
            var result = calculate.CalculatePercent(price.Price, commission.Commission);
                
            Console.WriteLine($"Общая сумма товара равна - {result}");
            Console.WriteLine($"Хотите ли вы купить товар по такой цене {result}? Y/N");
            var input = Console.ReadLine();
            if (input?.ToUpper() == "Y")
            {
                Console.WriteLine("Поздравляем вы успешно купили товар!");
                break;
            }
            Console.WriteLine("Жаль что не купили приходите еще будем ждать вас...");
            break;
        }
    }
}