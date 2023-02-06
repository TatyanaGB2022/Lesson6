// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] Duplicate(int[] array)
{
  int[] newarray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
  {
    newarray[i] = array[i];
  }
  return newarray;
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

int[] FillArray(int arraylength, int minnumber, int maxnumber)
{
  int[] array = new int[arraylength];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(minnumber, maxnumber + 1);
  }
  return array;
}

int arraylength = 5; //InputInt("Введите длину массива ");
int minnumber = 1; // InputInt("Введите минимальный порог значений массива ");
int maxnumber = 10; //InputInt("Введите максимальный порог значений массива ");

int[] array = FillArray(arraylength, minnumber, maxnumber);
PrintArray(array);
System.Console.WriteLine();

int[] a2 = Duplicate(array);
PrintArray(a2);
System.Console.WriteLine();

array[0] = 100;
PrintArray(array);
System.Console.WriteLine();