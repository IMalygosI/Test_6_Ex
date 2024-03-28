using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Test__6
{
    class Program
    {
        public static void Main() {

            Console.WriteLine("Введите размерность массива");//+
            int razmer = Convert.ToInt32(Console.ReadLine());

            int[,] array = { { razmer }, { razmer }, { razmer } };
            massiv array_Conclusion = new massiv(array);

            Console.WriteLine("\n1.Опрпеделить в нем произведение эелементов, квадрат которых меньше 25");//+
            Console.WriteLine(array_Conclusion.Number_One());//+
            Console.WriteLine("\n2.Опрпеделить в нем сумму модулей положительных элементов");//+
            Console.WriteLine(array_Conclusion.Number_Two());//+
            Console.WriteLine("\n3.сума модуле с отрицат. элементом");//+
            Console.WriteLine(array_Conclusion.Number_Three());//+
            /*
            Console.WriteLine("\n4.Опрпеделить в нем среднее геометрическое эелементов, у которых оба индекса четные.");//+
            Console.WriteLine(array_Conclusion.Number_Four());//+
            Console.WriteLine("\n5.Опрпеделить в нем  среднее геометрическое квадратов четных эелементов");//+
            Console.WriteLine(array_Conclusion.Number_Five());//+
            */
            Console.WriteLine("\n6.Опрпеделить в нем Количество тех элементов что при делении на 4 дают 2");//+
            Console.WriteLine(array_Conclusion.Number_Six());//+
            Console.WriteLine("\n7.Опрпеделить в нем произведение тех элементов чей модуль лежит в диапазоне [15; 50]");
            Console.WriteLine(array_Conclusion.Number_Seven());//+


            
        }
    }
}


//Основа +
//int sregarefmet = 0;//среднее арефметичское
//int razmer = Convert.ToInt32(Console.ReadLine());
//Random rand = new Random();
//int[,] array = new int[3, 3];
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = rand.Next(razmer);
//        Console.Write(array[i, j] + " ");
//    }
//}


//    Console.WriteLine("Укажите размерность массива:");
//int razmer = Convert.ToInt32(Console.ReadLine());

////int[] massiv = new int[razmer];

//int[] array = {razmer};
//Console.WriteLine("----------------------------- размер массива:");

//var str = string.Join(" ", array);
//Console.WriteLine(str);




//for (int i = 0; i < razmer; i++)
//{
//    Console.WriteLine("\n1.Опрпеделить в нем произведение эелементов, квадрат которых меньше 25");//+

//    Console.WriteLine("Укажите первое число:");
//    int proizvedenua1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("Укажите второе число:");
//    int proizvedenua2 = Convert.ToInt32(Console.ReadLine());

//    int num_One = proizvedenua1 * proizvedenua2;//произведение двух
//    num_One = num_One * num_One;//квадрат числа
//    if (num_One < 25)
//    {
//        // Console.WriteLine("\nВывод:");
//        massiv[i] = Convert.ToInt32(num_One);
//    }
//    //massiv[i] = Convert.ToInt32(num_One);
//}
//var str = string.Join(" ", massiv);
//Console.WriteLine(str);


/*

for (int i = 0; i < razmer; i++)
{
    Console.WriteLine("\n2.Опрпеделить в нем сумму модулей положительных элементов");//+
    Console.WriteLine("Укажите первый модуль:");
    int sum_modul_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите второй модуль:");
    int sum_modul_2 = Convert.ToInt32(Console.ReadLine());
    if (sum_modul_1 >= 0 && sum_modul_2 >= 0)
    {
        sum_modul_1 = Math.Abs(sum_modul_1);
        sum_modul_2 = Math.Abs(sum_modul_2);
        int sum_One1 = sum_modul_1 + sum_modul_2;//сумму модулей положительных элементов
        //Console.WriteLine("\nВывод:");
        massiv[i] = Convert.ToInt32(sum_One1);
    }
    else
    {
        Console.WriteLine("\nОшибка! Нарушено условие! Был введен отрицательный элемент");
    }
}
var str1 = string.Join(" ", massiv);
Console.WriteLine(str1);

for (int i = 0; i < razmer; i++)
{
    Console.WriteLine("\n3.Опрпеделить в нем среднее арефметическое модулей отрицательных элементов");//+
    Console.WriteLine("Укажите первый модуль:");
    int sum_modul_11 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите второй модуль:");
    int sum_modul_21 = Convert.ToInt32(Console.ReadLine());
    if (sum_modul_11 < 0 && sum_modul_21 < 0)
    {
        sum_modul_11 = Math.Abs(sum_modul_11);
        sum_modul_21 = Math.Abs(sum_modul_21);
        sregarefmet = sum_modul_11 + sum_modul_21;//сумму модулей отр элементов

        for (int j = 0; j < sregarefmet; j++)
        {
            sregarefmet = sregarefmet + massiv[j];
            sregarefmet = sregarefmet / sregarefmet;
            massiv[i] = Convert.ToInt32(sregarefmet);
        }
    }
    else
    {
        Console.WriteLine("\nОшибка! Нарушено условие! Был введен положительный элемент");
    }
}
var str4 = string.Join(" ", massiv);
Console.WriteLine(str4);
Console.WriteLine("Среднееарифметическое будет : " + str4);

//6. 

for (int i = 0; i < razmer; i++)
{
    Console.WriteLine("\n6.Опрпеделить в нем Количество тех элементов что при делении на 4 дают 2");//+
    Console.WriteLine("Укажите первый модуль:");
    int sum_modul_11 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Укажите второй модуль:");
    int sum_modul_21 = Convert.ToInt32(Console.ReadLine());


}
var str5 = string.Join(" ", massiv);
Console.WriteLine(str5);
*/