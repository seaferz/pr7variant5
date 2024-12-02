Console.WriteLine("Введите числа (последовательность заканчивается 0):");

        int uniqueCount = 0; // количество уникальных чисел
        int number1 = int.MinValue; // уникальные числа
        int number2 = int.MinValue;
        int number3 = int.MinValue;
        int currentNumber;

        do
        {
            currentNumber = int.Parse(Console.ReadLine());

            if (currentNumber == 0)
                break;

            // проверка на уникальность
            if (currentNumber != number1 && currentNumber != number2 && currentNumber != number3)
            {
                uniqueCount++; 

                // сохраняем уникальное число
                if (number1 == int.MinValue)
                    number1 = currentNumber;
                else if (number2 == int.MinValue)
                    number2 = currentNumber;
                else if (number3 == int.MinValue)
                    number3 = currentNumber;
            }

        } while (true);

        Console.WriteLine($"Количество различных чисел: {uniqueCount}");
    }
}
