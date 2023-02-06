// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int InputInt(string message)
{
  Console.Write($"{message}: ");
  return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
  Console.Write($"[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]}");
    if ((i + 1) < array.Length)
    {
      Console.Write($", ");
    }
  }
  Console.Write($"]");
}

int number = InputInt("Введите число");

int[] Fibonacci(int number)
{
  int[] array = new int[number];
  array[0] = 0;// по условию
  array[1] = 1;// по условию
  for (int i = 2; i < number; i++)
  {
    array[i] = array[i - 1] + array[i - 2]; 
  }
  return array;
}

PrintArray(Fibonacci(number));