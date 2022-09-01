// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// >>> Первая задача

// System.Console.WriteLine("Введите два числа:");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// if(a > b){
//     System.Console.WriteLine($"max = {a}, min = {b}");
// }
// else if(b > a){
//         System.Console.WriteLine($"max = {b}, min = {a}");
// }
// else{
//         System.Console.WriteLine($"a и b равны. max = {a}");

// }

// >>>> Вторая задача

// System.Console.WriteLine("Введите три числа:");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());

//  if(a>b & a>c){
//     System.Console.WriteLine($"max = {a}");
//  }
// else if(b>a & b>c){
//          System.Console.WriteLine($"max = {b}");
// }
// else if(c>a & c>b){
//          System.Console.WriteLine($"max = {c}");
// }

// >>>> Третья задача

// System.Console.WriteLine("Введите число:");
// int a = Convert.ToInt32(Console.ReadLine());

// if(a%2==0){
//     System.Console.WriteLine($"Число {a} является четным");
// }
// else{
//         System.Console.WriteLine($"Число {a} является нечетным");
// }

// >>>> Четвертая задача

System.Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= a; i+=2)
{
    Console.Write(i + " ");
}
if(a<2){
    System.Console.WriteLine("Четных чисел, удовлетворяющих условию, нет");
}