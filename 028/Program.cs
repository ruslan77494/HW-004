/*
Задача 27: Напишите программу,
которая принимает на вход число
 и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12

*/

 
  int SumNumber(int number)
  {
    
    int counte = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counte; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }
Console.Write("Пожалуйста введите число->>> ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр->( {sumNumber } )");
