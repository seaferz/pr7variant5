
        Console.WriteLine("Введите натуральное число:");
        string input = Console.ReadLine();

        if (!ulong.TryParse(input, out ulong number) || number == 0)
        {
            Console.WriteLine("Ошибка: введите натуральное число больше 0.");
            return;
        }

        int countZero = 0; // Счетчик для 0
        int countNine = 0; // Счетчик для 9

        while (number > 0)
        {
            int digit = (int)(number % 10); // Последняя цифра числа
            if (digit == 0) countZero++;
            if (digit == 9) countNine++;
            number /= 10; // Убираем последнюю цифру
        }

        if (countZero > countNine)
            Console.WriteLine("Цифра 0 встречается чаще.");
        else if (countNine > countZero)
            Console.WriteLine("Цифра 9 встречается чаще.");
        else
            Console.WriteLine("Цифры 0 и 9 встречаются одинаково часто.");
    

