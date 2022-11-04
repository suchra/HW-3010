// Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом//
 Console.WriteLine( "Введите пятизначное число " );
 int number = Convert.ToInt32(Console.ReadLine());

    int n=number/10000;
    int n1=number/1000%10;
     int n2=number/10%10;
     int n3=number%10;

 if(number>=10000 && number<100000)
  {
     if(n==n3 &&  n1==n2)
     {
   
        Console.WriteLine("Число " +number+ " является палиндромом ");
     }
     else
     {
         Console.WriteLine("Число " +number+ "  не является палиндромом ");
     }
 }
 else
 {
     Console.WriteLine("Это не пятизначное число");
 }