// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

int InputInt(string message)
{
  System.Console.Write($"{message}: ");
  return int.Parse(Console.ReadLine()); //int.Parse преобразует из строки в целое число
}
int a = InputInt("Введите число а");
int b = InputInt("Введите число b");
int c = InputInt("Введите число c");

bool Ygol(int a, int b, int c)
{
  if (a < b + c && b < a + c && c < a + b)
    return true;
  else
  {
    return false;
  }
}
if (Ygol(a, b, c))
{
  System.Console.WriteLine("Является треугольником");

}
else
{
  System.Console.WriteLine("Не является треугольником");
}