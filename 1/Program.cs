/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/




Console.WriteLine("Введите число");
string namberOnerStr = Console.ReadLine() ??"";
int nambera =  Convert.ToInt32(namberOnerStr);
if (nambera>99 && nambera<1000)
{
     int a = ((nambera/10)%10);
     int b = ((nambera/10)%10);
    Console.WriteLine(b);
}




