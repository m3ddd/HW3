// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

static bool IsPalindrome(int number)
{
  // переводи int в string
  string num = number.ToString();
  // я не смог понять как сдлеать через цикл поэтом решли просто перевернуть (или отзеркалить) строку, 
  // до этого так не умел делать, учился в процессе =)
  // переворачиваем строкe
  char[] reversed_num = num.ToCharArray();
  Array.Reverse(reversed_num);
  string reversed_num_str = new string(reversed_num);
  // проверяем палиндром или нет
  if (num == reversed_num_str) 
  {
     return true;
  }
    return false;
  }

Console.WriteLine("Введите ваше число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (IsPalindrome(number)) 
{
  Console.WriteLine($"Вы ввели число {number} оно палиндром");
}
else
{
  Console.WriteLine($"Вы ввели число {number} оно не палиндром");
}
