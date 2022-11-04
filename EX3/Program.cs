// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.//
Console.WriteLine( "Введите число N" );
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int count = 1;
while(count<=number)
{
   Console.WriteLine(Math.Pow(count,3));
    count++;
}