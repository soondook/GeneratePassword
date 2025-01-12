using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько паролей вы хотите сгенерировать?");
        if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
        {
            for (int i = 0; i < count; i++)
            {
                string password = GeneratePassword();
                Console.WriteLine($"Пароль {i + 1}: {password}");
            }
        }
        else
        {
            Console.WriteLine("Введите корректное число.");
        }
    }

    static string GeneratePassword()
    {
        // Список столиц
        List<string> capitals = new List<string> { "London", "Berlin", "Tokyo", "Paris", "Ottawa", "Moscow", "Rome", "Madrid", "Beijing", "Canberra" };

        // Список штатов
        List<string> usStates = new List<string> { 
            "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut", "Delaware", "Florida", "Georgia", "Hawaii", "Idaho",  "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", 
            "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",  "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada",  "New Hampshire", "New Jersey", "New Mexico", "New York", 
            "Carolina", "Dakota", "Ohio", "Oklahoma", "Oregon",  "Pennsylvania", "Carolina", "Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington", "Virginia", "Wisconsin", "Wyoming" 
            };


        // Список рок-групп
        List<string> bands = new List<string> { "Queen", "Nirvana", "Metallica", "Beatles", "ACDC", "LinkinPark", "PinkFloyd", "LedZeppelin", "DeepPurple", "Radiohead" };

        // Случайный генератор
        Random random = new();
         
        // Выбор штата 
        string usState = usStates[random.Next(usStates.Count)];
        // Выбор случайной столицы и рок-группы
        string capital = capitals[random.Next(capitals.Count)];
        string band = bands[random.Next(bands.Count)];

        // Случайный год от 1980 до 2024
        int year = random.Next(1970, 2025);

        // Список специальных символов
        string specialSymbols = "!@#$%^&";
        char specialSymbol = specialSymbols[random.Next(specialSymbols.Length)];

        // Формирование пароля
        string password = capital + usState + band + year + specialSymbol;

        // Урезание до 16 символов, если необходимо
        if (password.Length > 48)
        {
            password = password[..48];
        }

        return password;
    }
}

