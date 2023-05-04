using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите латинский символ:");
        char latinChar = Console.ReadLine()[0]; // Вводим латинский символ и сохраняем его в переменную

        char cyrillicChar = GetCyrillicEquivalent(latinChar); // Получаем кириллический символ

        if (cyrillicChar != '\0')
        {
            int latinCharCode = (int)latinChar; // Получаем числовой код исходного латинского символа
            int cyrillicCharCode = (int)cyrillicChar; // Получаем числовой код кириллического символа

            Console.WriteLine($"Символ: {cyrillicChar} ({latinCharCode}) [{cyrillicCharCode}]");
        }
        else
        {
            Console.WriteLine("Для введенного латинского символа нет кириллического эквивалента.");
        }
    }

    static char GetCyrillicEquivalent(char latinChar)
    {
        // Строки с соответствиями латинских и кириллических символов
        // Дополните их, если нужно добавить еще символов
        string latinChars = "abcekmoptyx";
        string cyrillicChars = "абсекмортхух";

        int index = latinChars.IndexOf(char.ToLower(latinChar)); // Ищем индекс латинского символа в строке

        if (index != -1)
        {
            return cyrillicChars[index]; // Возвращаем кириллический символ с соответствующим индексом
        }
        else
        {
            return '\0'; // Возвращаем null-символ, если нет кириллического эквивалента
        }
    }
}

