namespace Instalments.Onbording;

public class OnbordingPeriod
{
    public int Period(int categoryId)
    {
        var db = new Query();
        var periods = new List<Periods>(db.Get<Periods>($"SELECT id, commission, period FROM period WHERE category_id = {categoryId}"));
        foreach (var p in periods)
        {
            Console.WriteLine($"{p.Period} месяцев. Коммиссия {p.Commission}. ID: {p.Id}.");
        }

        var periodId = 0;
        while (true)
        {
            Console.Write("\nДля выбора введите ID срока (для выхода введите 'Z'. Для возврата на категории введите 'W' ): ");
            var input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "Z":
                    Console.WriteLine("\nОх жаль что уходите ):");
                    Environment.Exit(0);
                    break;
                case "W":
                    Console.Clear();
                    return periodId;
            }

            if (int.TryParse(input, out periodId) && periods.Exists(p => p.Id == periodId))
            {
                break;
            }
            Console.WriteLine("Некорректный ввод. Попробуйте еще раз.");
        }
        Console.Clear();
        return periodId;
    }
}