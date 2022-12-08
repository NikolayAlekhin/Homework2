/*   Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */ 

Console.WriteLine("Введите число");
string namberOnerStr = Console.ReadLine() ??"";
int nambera =  Convert.ToInt32(namberOnerStr);
if (nambera<6 & nambera>0)
{
    Console.WriteLine( $"{nambera} = нет");
}    
if (nambera<8 & nambera>6)
{
    Console.WriteLine( $"{nambera} = да");
    
}    
if (nambera<9 & nambera<0)
{
    Console.WriteLine( $"{nambera} = ошибка");
    
}