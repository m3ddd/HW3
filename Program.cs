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

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


double distance (double x1, double y1, double z1, double x2, double y2, double z2)
{
  double distX = x1-x2;
  double distY = y1-y2;
  double distZ = z1-z2;
  double result = Math.Sqrt(distX*distX + distY*distY + distZ*distZ);
  return result;
}
Console.WriteLine("Введите значения х1 - ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения y1 - ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения z1 - ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения х2 - ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения y2 - ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значения z2 - ");
int z2 = Convert.ToInt32(Console.ReadLine());

double resuntat = Math.Round(distance (x1,y1,z1,x2,y2,z2),2);
Console.Write($"Расстояние между точками 1 и 2 составляет - {resuntat}");

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void TablCub (int N)
{
  int count = 1;
  while (count <= N)
  {
    Console.WriteLine($"Куб {count} составляет - {count*count*count}");
    count ++;
  }
}
Console.Write("Введите значение: ");
int num = Convert.ToInt32(Console.ReadLine());

TablCub(num);
