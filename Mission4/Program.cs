// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int InputInt(string message)
{
  System.Console.Write($"{message}: ");
  return int.Parse(Console.ReadLine());
}

int numb = InputInt("введите число");

int[] ToBinary(int numb)
{
  int[] result = new int[10];
  int i = result.Length - 1;
  while (numb > 0)
  {
    result[i] = numb % 2;
    numb /= 2;
    i--;
  }
  return result;
}
void PrintArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
}
System.Console.WriteLine($"Двоичное число от {numb}");
PrintArray(ToBinary(numb));