// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй
//  и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int InputInt(string message) //1.
{
  System.Console.Write($"{message}: ");
  return int.Parse(Console.ReadLine());
}

int[] CreateMassive(int len, int minValue, int maxValue) // 2. генерируем массив, len - длина
{
  int[] array = new int[len];
  for (int i = 0; i < array.Length; i++)// пока соблюдается условие
  {
    array[i] = new Random().Next(minValue, maxValue + 1); // array итому присваиваем 
  }
  return array; //возвращаем этот массив
}

void PrintMassive(int[] array) // 3. покажем этот массив на экране
{
  System.Console.Write(array[0]);
  for (int i = 1; i < array.Length; i++)
  {
    System.Console.Write($", {array[i]}");//array[i] -число из массива. Write-не переводит курсор на следующую строку
  }
  System.Console.WriteLine(); // WriteLine - переводит курсор на следующую строчку
}

// массив 2, 4, 3, 1, 6 => 12, 4, 3; 2, 4, 5, 6 => 12, 20
int[] MultiplicationPairs(int[] array) // функция MultiplicationPairs - перемножение пар
{
  int[] resultArray;// создаем массив
  resultArray = new int[array.Length / 2 + array.Length % 2];
  resultArray[resultArray.Length - 1] = array[resultArray.Length - 1];
  for (int i = 0; i < array.Length / 2; i++)
  {
    resultArray[i] = array[i] * array[array.Length - 1 - i];
  }
  return resultArray;
}

int length = InputInt("Введите длину массива");
int[] myArray = CreateMassive(length, 1, 9);
PrintMassive(myArray);
System.Console.WriteLine("Массив произведений пар:");
int[] multiplicatedArray = MultiplicationPairs(myArray);
PrintMassive(multiplicatedArray);