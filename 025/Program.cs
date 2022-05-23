
/*
Задача 25: Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exponentiation(int n, int n1)
{
  int result = 1;
  for(int i=1; i <= n1; i++)
  {
    result = result * n;
  }
    return result;
}

  Console.Write(" Пожалуйста Введите Первое Число:   ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write(" Пожалуйста Введите Второе Число:   ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine($"Ответ--> {exponentiation}");



 