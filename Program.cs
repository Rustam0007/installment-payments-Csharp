using Instalments.Onbording;

namespace Instalments;

    public class Program
    {
        static void Main(string[] args)
        {
            var db = new Query();

            Console.WriteLine("Добро пожаловать на магазин AlifShop");

            while (true)
            {
                var category = new OnbordingCategory();
                var categoryId = category.Category();
                
                var product = new OnbordingProduct();
                var productId = product.Product(categoryId);
                if (productId == 0)
                {
                    continue;
                }
                
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
                break;
            }
        }
    }