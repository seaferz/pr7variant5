﻿/*Дана непустая последовательность чисел, оканчивающаяся нулем. 
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