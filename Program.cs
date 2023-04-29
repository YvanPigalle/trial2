
//Задача: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.



 void Digits (int num)
{
 int seconddgt = num / 10%10;
 int minussecond = num /10%10*-1;
 if (num > 99 && num < 1000)
 {
     Console.WriteLine ($"Second digit is " +seconddgt);
 }
if (num < -99 && num > -1000)
{
 Console.WriteLine ($"Second digit is " +minussecond);
}
}

Console.WriteLine("Input your number: ");
int user_num = Convert.ToInt32(Console.ReadLine());
if (user_num > -100 && user_num < 100 || user_num > 999 || user_num < -999)
{
   Console.WriteLine("Incorrect number!"); 
}
if (user_num > 99 && user_num < 1000 || user_num < -99 && user_num > -1000)
{
Digits (user_num);
}

