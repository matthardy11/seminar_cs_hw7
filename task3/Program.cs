// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillMaxtrix(int[,] array)
{
  Random rand = new Random();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = rand.Next(0, 10);
    }
  }
}

void ShowMatrix(int[,] array)
{
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write(array[i,j] + "\t");
    }
    System.Console.WriteLine();
  }
}

void ColsAvg(int[,] array)
{
  double result = 0;
  for(int i = 0; i < array.GetLength(1); i++)
  {
    for(int j = 0; j < array.GetLength(0); j++)
    {
      result = result + array[j, i];
    }
    result = result / array.GetLength(1);
    System.Console.WriteLine($"Среднее арифметическое столбца {i+1} равно {result}");
    result = 0;
  }
}

int[,] matrix = new int[5,5];

FillMaxtrix(matrix);
ShowMatrix(matrix);
System.Console.WriteLine();
ColsAvg(matrix);
