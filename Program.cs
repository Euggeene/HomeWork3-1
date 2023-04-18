// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine ("Введите пятизначное число ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num>=10000 && num<=99999)
// {
//     string str = Convert.ToString(num);
//     if (str[0] == str[4] && str[1] == str[3])
//     {
//         Console.WriteLine (num + " -палиндром");
//     }
//     else
//     {
//         Console.WriteLine (num + " -не палиндром");  
//     }
// }
// else
// {
//     Console.WriteLine (num + " -не пятизначное число");
// }


// Задача 21:
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату X первой точки");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y первой точки");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z первой точки");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координату X второй точки");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y второй точки");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Z второй точки");
// int Z2= Convert.ToInt32(Console.ReadLine());

// double d=Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));
// d=Math.Round(d,2);
// Console.WriteLine(d);


// Задача 23:
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i=1; i<=N; i++)
// {
// Console.WriteLine(Math.Pow(i,3));
// }