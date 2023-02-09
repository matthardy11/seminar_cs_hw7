// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int InputNumber(string str)
{
  int number;
  string text;
  while(true)
  {
    Console.WriteLine(str);
    text = Console.ReadLine();
    if(int.TryParse(text, out number))
    {
      break;
    }
    System.Console.WriteLine("Введено не корректное число, попробуйте ещё раз.");
  }
  return number;
}

void FillArrayMaxtrixDouble(double[,] array)
{
  Random rand = new Random();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = Math.Round((rand.NextDouble() * rand.Next(0, 100)), 3);
    }
  }
}

void ShowArray(double[,] array)
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

int m = InputNumber("Введите m: ");
int n = InputNumber("введите n: ");

double[,] matrix = new double[m, n];

FillArrayMaxtrixDouble(matrix);
ShowArray(matrix);
