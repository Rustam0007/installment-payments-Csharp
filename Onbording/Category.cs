using System;
using System.Collections.Generic;

namespace Instalments.Onbording
{
    public class OnbordingCategory
    {
        public int Category()
        {
            var db = new Query();
            var categoriesData = db.Get<Categories>("SELECT id, category FROM categories");
            var categories = new List<Categories>(categoriesData);

            Console.WriteLine("У нас в магазине есть такие категории:\n");
            foreach (var category in categories)
            {
                Console.WriteLine($"Категория: {category.Category}. ID: {category.Id}.");
            }

            int categoryId;
            while (true)
            {
                Console.Write("Для выбора категории введите его ID (для выхода введите 'Z'): ");
                var input = Console.ReadLine();
                if (input?.ToUpper() == "Z")
                {
                    Console.WriteLine("\nОх жаль что уходите ):");
                    Environment.Exit(0);
                }

                if (int.TryParse(input, out categoryId))
                {
                    if (categories.Exists(c => c.Id == categoryId))
                    {
                        break;
                    }
                }
                Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
            }
            Console.Clear();
            return categoryId;
        }
    }
}