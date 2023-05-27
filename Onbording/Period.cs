namespace Instalments.Onbording;

public class OnbordingPeriod
{
    public int Period(int categoryId)
    {
        var db = new Query();
        Console.WriteLine("\nНа какой срок вы хотите брать товар?\n");
        var periodsData = db.Get<Periods>($"SELECT id, commission, period FROM period WHERE category_id = {categoryId}");
        var periods = new List<Periods>(periodsData);
        foreach (var p in periods)
        {
            Console.WriteLine($"{p.Period} месяцев. Коммиссия {p.Commission}. ID: {p.Id}.");
        }

        var periodId = 0;
        while (true)
        {
            Console.Write("\nДля выбора введите ID срока (для выхода введите 'Z'. Для возврата на категории введите 'W' ): ");
            var input = Console.ReadLine();
            switch (input?.ToUpper())
            {
                case "Z":
                    Console.WriteLine("\nОх жаль что уходите ):");
                    Environment.Exit(0);
                    break;
                case "W":
                    Console.Clear();
                    periodId = 0;
                    return periodId;
            }

            if (int.TryParse(input, out periodId))
            {
                if (periods.Exists(p => p.Id == periodId))
                {
                    break;
                }
            }
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
        }
        Console.Clear();
        return periodId;
    }
}