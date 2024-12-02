/*Дана непустая последовательность чисел, оканчивающаяся нулем. 
Последовательность является невозрастающей. Найти количество различных чисел в 
последовательности*/

Console.WriteLine("Введи последовательность чисел, оканчивающиеся нулем");


/*
 каждый элемент преобразуется в хэш-код, при добавлении числа,
 вычисляет его хэш-код и сравнивает его с существующими элементами
*/
HashSet<int> list = new HashSet<int>(); //хранит уникальные числа 

int x;

do
{
    x = Convert.ToInt32(Console.ReadLine());
    if (x != 0)
    {
        list.Add(x); //добавляем число в HashSet (дубликаты игнорируются)
    }
} while (x != 0);

//вывод
Console.WriteLine($"Количество уникальных чисел: {list.Count}");











or







//три уникальных числа

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
