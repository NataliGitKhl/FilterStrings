namespace WordShorter;

static class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.Write("Введите строки через пробел: ");
        var inputArray = Console.ReadLine()?.Split() ?? throw new InvalidOperationException();

        // Пример массива строк для тестирования, если ввод с клавиатуры не используется
        // string[] inputArray = {"apple", "banana", "cat", "dog", "elephant", "fox"};

        // Фильтрация строк
        var resultArray = FilterStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Массив строк с длиной <= 3 символов:");
        foreach (var str in resultArray)
        {
            Console.WriteLine(str);
        }
    }

    private static IEnumerable<string> FilterStrings(string[] arr)
    {
        var count = arr.Count(s => s.Length <= 3);

        // Подсчет количества строк, удовлетворяющих условию

        // Создание массива результатов
        var result = new string[count];
        var index = 0;

        // Заполнение массива результатов
        foreach (var s in arr)
        {
            if (s.Length > 3) continue;
            result[index] = s;
            index++;
        }

        return result;
    }
}