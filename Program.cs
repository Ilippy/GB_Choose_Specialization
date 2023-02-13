// Итоговая проверочная работа.
// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения
// на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.
// Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы
// выделяете ее в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито
// одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


class Program
{
    private static void Main(string[] args)
    {
        string[] stringArray = CreateArray();
        string[] arrayLessThan3Chars = GetArrayWithLessThanThreeCharsFromAnotherArray(stringArray);
        Console.Clear();
        Console.WriteLine($"[{string.Join(", ", stringArray)}] -> [{string.Join(", ", arrayLessThan3Chars)}]");
    }

    static string[] CreateArray()
    {
        int sizeOfArray = EnterNumber("Введите длину массива");
        string[] array = new string[sizeOfArray];
        for (int i = 0; i < sizeOfArray; i++)
        {
            Console.WriteLine($"Введите {i + 1}-й элемент массива");
            array[i] = Console.ReadLine()!;
        }
        return array;
    }

    static int EnterNumber(string str)
    {
        System.Console.WriteLine(str);
        string stringNumber = Console.ReadLine()!.Trim();
        int number;
        while (!int.TryParse(stringNumber, out number))
        {
            Console.WriteLine($"Ошибка! {str}");
            stringNumber = Console.ReadLine()!.Trim();
        }
        return number;
    }

    static string[] GetArrayWithLessThanThreeCharsFromAnotherArray(string[] array)
    {
        int sizeOfArray = GetSizeOfArrayWithLessThanThreeChars(array);
        string[] newArray = new string[sizeOfArray];
        int j = 0;
        // string result = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) newArray[j++] += array[i];
        }
        // можно было бы сделать через разделение строки, но если в начальном массиве будут пробелы, то он не корректно разделит
        // используя коллекиции это было сделать проще всего или если использовать библиотеку LINQ
        // string[] newArray = result.Trim().Split(' ');  
        return newArray;
    }
    static int GetSizeOfArrayWithLessThanThreeChars(string[] array)
    {
        int n = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) n++;
        }
        return n;
    }
}