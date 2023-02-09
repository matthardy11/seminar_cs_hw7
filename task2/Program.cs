// Напишите программу, которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве или же указание, что такого числа нет.

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

void FillMaxtrix(int[,] array)
{
  Random rand = new Random();
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = rand.Next(0, 100);
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

void FindNumberInMatrix(int[,] array, int number)
{
  int count = 0;
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      if(number == array[i, j])
      {
        System.Console.WriteLine($"Искомое число на позиции: [{i}, {j}]");
        count++;
      }
    }
  }
  if (count==0)
  {System.Console.WriteLine($"Числа {number} в массиве нет.");}
}

int number = InputNumber("Введите число");
int[,] matrix = new int[10, 10];

FillMaxtrix(matrix);
ShowMatrix(matrix);
System.Console.WriteLine();
FindNumberInMatrix(matrix, number);
