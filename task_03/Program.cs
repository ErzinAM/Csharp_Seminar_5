﻿// Задание 3.
int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] CreateArray(int m, int n)
{
  int[,] array = new int[m, n];
  return array;
}

void PrintArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrayRandom(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
  return array;
}

int SumRowArray(int[,] array)
{
  int[] sumArr = new int[array.GetLength(0)];
  Console.WriteLine($"Сумма элементов строки: ");
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sumArr[i] += array[i, j];
    }
    Console.WriteLine($"{i + 1} -> {sumArr[i]}");
  }
  int minSum = sumArr[0];
  int minRow = 1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (sumArr[i] < minSum)
    {
      minSum = sumArr[i];
      minRow = i + 1;
    }
  }
  return minRow;
}

int[,] array = CreateArray(Prompt("Введите количество строк: "), Prompt("Введите количество столбцов: "));
array = FillArrayRandom(array);
PrintArray(array);
int row = SumRowArray(array);
Console.WriteLine($"Наименьшая сумма элементов в {row} строке.");