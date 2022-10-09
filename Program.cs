// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. (можно решить через строку, а можно математически)
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int num = int.Parse(Console.ReadLine()!);
// int numMin = 10000;
// int numMax = 99999;
// if ((numMin <= num) && (num <= numMax)){
//     int n1 = num / 10000;
//     int n2 = (num / 1000) % 10;
//     int n3 = (num % 1000) / 100;
//     int n4 = (num % 1000) /10 % 10;
//     int n5 = (num % 1000) % 10;
//     if ((n1 + n2 + n3) == (n3 + n4 + n5)){
//         Console.WriteLine($" Число {num} является палиндроном");
//     }
//     else{
//         Console.WriteLine($"Число {num} не является палиндроном");
//     }

// }
    


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координату ax");
// int ax = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите координату ay");
// int ay = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите координату az");
// int az = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите координату bx");
// int bx = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите координату by");
// int by = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите координату bz");
// int bz = int.Parse(Console.ReadLine()!);

// double ab = Math.Sqrt(Math.Pow(bx - ax, 2)+Math.Pow(by - ay, 2)+Math.Pow(bz - az, 2));
// Console.WriteLine($"{ab:f2}");




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите число: ");
// int N = int.Parse(Console.ReadLine()!);
// int i = 1;
// while (i <= N){
//     int result = Convert.ToInt32(Math.Pow(i, 3));
//     Console.WriteLine($"{result}");
//     i++;
// }