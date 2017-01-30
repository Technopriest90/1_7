﻿using System;

// Продемонстрировать одномерный массив
//    class ArrayDemo
//    {
//        static void Main()
//        {
//        int[] sample = new int[10];
//        int i;
//
//        for (i = 0; i < 10; i = i + 1)
//            sample[i] = i;
//        for (i = 0; i < 10; i = i + 1)
//            Console.WriteLine("sample[" + i + "]: " + sample[i]);
//        Console.ReadKey();
//        }
//    }
// Вычислить среднее арифметическое ряда значений
//  class Average
//  {
//      static void Main()
//      {
//          int[] nums = new int[10];
//          int avg = 0;
//  
//          nums[0] = 99;
//          nums[1] = 10;
//          nums[2] = 100;
//          nums[3] = 18;
//          nums[4] = 78;
//          nums[5] = 23;
//          nums[6] = 63;
//          nums[7] = 9;
//          nums[8] = 87;
//          nums[9] = 49;
//  
//          for (int i = 0; i < 10; i++)
//              avg = avg + nums[i];
//  
//          avg = avg / 10;
//  
//          Console.WriteLine("Среднее: " + avg);
//          Console.ReadKey();
//      }
//  }
// Вычислить среднее арифметическое ряда значений
//  class Average
//  {
//      static void Main()
//      {
//          int[] nums = { 99, 10, 100, 18, 78, 23, 63, 9, 87, 49 };
//  
//          int avg = 0;
//  
//          for (int i = 0; i < 10; i++)
//              avg = avg + nums[i];
//          avg = avg / 10;
//  
//          Console.WriteLine("Среднее: " + avg);
//          Console.ReadKey();
//      }
//  }
// Продемонстрировать превышение границ массива
//  class ArrayErr
//  {
//      static void Main()
//      {
//          int[] sample = new int[10];
//          int i;
//  
//          //Воссоздать превышение границ массива
//          for (i = 0; i < 100; i = i + 1)
//              sample[i] = i;
//          Console.ReadKey();
//      }
//  }

//Продемонстрировать двумерный массив

// class TwoD
// {
//     static void Main()
//     {
//         int t, i;
//         int[,] table = new int[3, 4];
// 
//         for(t=0;t<3;t++)
//         {
//             for(i=0;i<4;i++)
//             {
//                 table[t, i] = (t * 4) + i + 1;
//                 Console.Write(table[t, i] + " ");
//             }
//             Console.WriteLine();
//         }
//         Console.ReadKey();
//     }
// }
// Суммировать значения по одной из диагоналей матрицы 3x3x3

//  class ThreeDMatrix
//  {
//      static void Main()
//      {
//          int[,,] m = new int[3, 3, 3];
//          int sum = 0;
//          int n = 1;
//  
//          for (int x = 0; x < 3; x++)
//              for (int y = 0; y < 3; y++)
//                  for (int z = 0; z < 3; z++)
//                      m[x, y, z] = n++;
//          sum = m[0, 0, 0] + m[1, 1, 1] + m[2, 2, 2];
//          Console.WriteLine("Сумма значений по первой диагонали: " + sum);
//          Console.ReadKey();
//      }
//  }
// Продемонстрировать применение ступенчатых массивов

// class jagged
// {
//     static void Main()
//     {
//         int[][] jagged = new int[3][];
//         jagged[0] = new int[4];
//         jagged[1] = new int[3];
//         jagged[2] = new int[5];
// 
//         int i;
// 
//         //Сохранить значения в первом массиве
//         for (i = 0; i < 4; i++)
//             jagged[0][i] = i;
//         //Сохранить значения во втором массиве
//         for (i = 0; i < 3; i++)
//             jagged[1][i] = i;
//         //Сохранить значения в третьем массиве
//         for (i = 0; i < 5; i++)
//             jagged[2][i] = i;
//         //вывести значения из первого массив
//         for (i = 0; i < 4; i++)
//             Console.Write(jagged[0][i]+" ");
//         Console.WriteLine();
//         for (i = 0; i < 3; i++)
//             Console.Write(jagged[1][i] + " ");
//         Console.WriteLine();
//         for (i = 0; i < 5; i++)
//             Console.Write(jagged[2][i] + " ");
//         Console.WriteLine();
//         Console.ReadKey();
//     }
// }

// Присваивание ссылок на массивы.

// class AssignARef
// {
//     static void Main()
//     {
//         int i;
// 
//         int[] nums1 = new int[10];
//         int[] nums2 = new int[10];
// 
//         for (i = 0; i < 10; i++) nums1[i] = i;
// 
//         for (i = 0; i < 10; i++) nums2[i] = -i;
//         Console.WriteLine("Содержимое массива nums1: ");
//         for (i = 0; i < 10; i++)
//             Console.Write(nums1[i] + " ");
//         Console.WriteLine();
// 
//         Console.WriteLine("Содержимое массива nums2: ");
//         for (i = 0; i < 10; i++)
//             Console.Write(nums2[i] + " ");
//         Console.WriteLine();
// 
//         nums2 = nums1; //теперь nums2 ссылается на nums1
// 
//         Console.Write("Содержимое массива nums2\n" + "после присваивания: ");
//         for (i = 0; i < 10; i++)
//             Console.Write(nums2[i] + " ");
//         Console.WriteLine();
// 
//         //далее оперировать массивом nums1 посредством переменной ссылки на массив nums2
//         nums2[3] = 99;
// 
//         Console.Write("Содержимое массива nums1 после изменения \n" + "посредством переменной nums2: ");
//         for (i = 0; i < 10; i++)
//             Console.Write(nums1[i] + " ");
//         Console.WriteLine();
//         Console.ReadKey();
// 
//     }
// }

// class LengthDemo
// {
//     static void Main()
//     {
//         int[] nums = new int[10];
// 
//         Console.WriteLine("Длина массива nums равна " + nums.Length);
// 
//         //Использовать свойство Length для инициализации массива nums.
//         for (int i = 0; i < nums.Length; i++)
//             nums[i] = i * i;
//         //А теперь воспользоваться свойством Length для вывода содержимого массива nums
//         Console.Write("Содержимое массива nums: ");
//         for (int i = 0; i < nums.Length; i++)
//             Console.Write(nums[i] + " ");
//         Console.WriteLine();
//         Console.ReadKey();
//     }
// }

// class LengthDemo3D
// {
//     static void Main()
//     {
//         int[,,] nums = new int[10, 5, 6];
//         Console.WriteLine("Длина массива nums равна " + nums.Length);
//         Console.ReadKey();
//     }
// }

// Поменять местами содержимое элементов массива.
// class RevCopy
// {
//     static void Main()
//     {
//         int i, j;
//         int[] nums1 = new int[10];
//         int[] nums2 = new int[10];
// 
//         for (i = 0; i < nums1.Length; i++) nums1[i] = i;
// 
//         Console.Write("Исходное содержимое массива: ");
//         for (i = 0; i < nums2.Length; i++)
//             Console.Write(nums1[i] + " ");
// 
//         Console.WriteLine();
// 
//         //Скопировать элементы массива nums1 в nums2 в обратном порядке
//         if (nums2.Length >= nums1.Length) //проверить, достаточно ли длины массива nums2
//             for (i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
//                 nums2[j] = nums1[i];
//         Console.Write("Содержимое массива в обратном порядке: ");
//         for (i = 0; i < nums2.Length; i++)
//             Console.Write(nums2[i] + " ");
//         Console.WriteLine();
//         Console.ReadKey();
//     }
// 
// }
// class jagged //Продемонстрировать применение свойства Length при обращении со ступенчатыми массивами
// {
//     static void Main()
//     {
//         int[][] network_nodes = new int[4][];
//         network_nodes[0] = new int[3];
//         network_nodes[1] = new int[7];
//         network_nodes[2] = new int[2];
//         network_nodes[3] = new int[5];
// 
//         int i, j;
// 
//         //Сфабриковать данные об использовании ЦП
//         for (i = 0; i < network_nodes.Length; i++)
//             for (j = 0; j < network_nodes[i].Length; j++)
//                 network_nodes[i][j] = i * j + 70;
//         Console.WriteLine("Общее количество узлов сети: " + network_nodes.Length + "\n");
// 
//         for(i=0;i<network_nodes.Length;i++)
//         {
//             for(j=0; j<network_nodes[i].Length;j++)
//             {
//                 Console.Write("Использование в узле сети " + i + " ЦП " + j + ": ");
//                 Console.Write(network_nodes[i][j] + "% ");
//                 Console.WriteLine();
//             }
//             Console.WriteLine();
//         }
//         Console.ReadKey();
//     }
// }


// class Jagged // Продемонстрировать неявно типизированный ступенчатый массив
// {
//     static void Main()
//     {
//         var jagged = new[]
//         {
//             new[] {1,2,3,4},
//             new[] {9,8,7},
//             new[] {11,12,13,14,15}
//         };
// 
//         for(int j =0;j<jagged.Length;j++)
//         {
//             for (int i = 0; i < jagged[j].Length; i++)
//                 Console.Write(jagged[j][i] + " ");
//             Console.WriteLine();
//         }
//         Console.ReadKey();
// 
// 
//     }
// }

// class ForeachDemo   //Использовать оператор цикла foreach
// {
//     static void Main()
//     {
//         int sum = 0;
//         int[] nums = new int[10];
// 
//         //Задать первоначальные значения элементов массива nums.
//         for (int i = 0; i < 10; i++)
//             nums[i] = i;
//         //Использовать цикл foreach для вывода значений элементов массива и подсчета их суммы
//         foreach (int x in nums)
//         {
//             Console.WriteLine("Значение элемента равно: " + x);
//             sum += x;
//         }
// 
//         Console.WriteLine("Сумма равна: " + sum);
//         Console.ReadKey();
//     }
// 
// }

// class ForeachDemo   //использовать оператор break для преждевременного завершения цикла foreach
// {
//     static void Main()
//     {
//         int sum = 0;
//         int[] nums = new int[10];
// 
//         //Задать первоначальные значения элементов массива nums
//         for (int i = 0; i < 10; i++)
//             nums[i] = i;
// 
//         //Использовать цикл foreach для вывода значений элементов массива и подсчета их суммы
//         foreach(int x in nums)
//         {
//             Console.WriteLine("Значение элемента равно: " + x);
//             sum += x;
//             if (x == 4) break; //прервать цикл, как только индекс массива достигнет 4
//         }
//         Console.WriteLine("Сумма первых 5 элементов: " + sum);
//         Console.ReadKey();
//     }
// 
// }

// class ForeachDemo2 // Использовать оператор цикла foreach для обращения к двумерному массиву
// {
//     static void Main()
//     {
//         int sum = 0;
//         int[,] nums = new int[3, 5];
// 
//         //Задать  первоначальные значения элементов массива nums
//         for (int i = 0; i < 3; i++)
//             for (int j = 0; j < 5; j++)
//                 nums[i, j] = (i + 1) * (j + 1);
// 
//         //Использовать цикл foreach для вывода значений элементов массива и подсчета их суммы
//         foreach(int x in nums)
//         {
//             Console.WriteLine("Значени элементов равно: " + x);
//             sum += x;
//         }
//         Console.WriteLine("Сумма равна: " + sum);
//         Console.ReadKey();
//     }
// }

//     class Search    //Поиск в массиве с помощью оператора цикла foreach
// {
//     static void Main()
//     {
//         int[] nums = new int[10];
//         int val;
//         bool found = false;
// 
//         //Задать первоначальные значения элементов массива nums.
//         for (int i = 0; i < 10; i++)
//             nums[i] = i;
// 
//         val = 5;
// 
//         //Использовать цикл foreach для поиска заданного значения в массиве nums.
//         foreach(int x in nums)
//         {
//             if(x==val)
//             {
//                 found = true;
//                 break;
//             }
//         }
// 
//         if (found)
//             Console.WriteLine("Значение найдено!");
//         Console.ReadKey();
//     }
// 
// }

// class StringDemo // Создать и ввести символьную строку
// {
//     static void Main()
//     {
//         char[] charray = { 'Э', 'т', 'о', ' ', 'с', 'т', 'р', 'о', 'к', 'а', '.' };
//         string str1 = new string(charray);
//         string str2 = "Ещё одна строка.";
// 
//         Console.WriteLine(str1);
//         Console.WriteLine(str2);
//         Console.ReadKey();
//     }
// }

// using System.Globalization;
// class StrOps
// {
//     static void Main()
//     {
//         string str1 = "Программировать в .NET лучше всего на C#.";
//         string str2 = "Программировать в .NET лучше всего на C#.";
//         string str3 = "Строки в C# весьма эффектины.";
//         string strUp, strLow;
//         int result, idx;
// 
//         Console.WriteLine("str1: " + str1);
//         Console.WriteLine("Длина строки str1: " + str1.Length);
// 
//         // Создать варианты строки str1, набранные прописными и строчными буквами
//         strLow = str1.ToLower(CultureInfo.CurrentCulture);
//         strUp = str1.ToUpper(CultureInfo.CurrentCulture);
//         Console.WriteLine("Вариант строки str1, " + "набранный строчными буквами\n   " + strLow);
//         Console.WriteLine("Вариант строки str1, " + "набранный прописными буквами\n   " + strUp);
// 
//         Console.WriteLine();
// 
//         //Вывести строку str1 посимвольно.
//         Console.WriteLine("Вывод строки str1 посимвольно.");
//         for (int i = 0; i < str1.Length; i++)
//             Console.Write(str1[i]);
//         Console.WriteLine("\n");
//         //Сравнить строки способом порядкового сравнения.
//         if (str1 == str2)
//             Console.WriteLine("str1 == str2");
//         else
//             Console.WriteLine("str1 != str2");
//         if (str1 == str3)
//             Console.WriteLine("str1 == str3");
//         else
//             Console.WriteLine("str1 != str3");
//         // Сравнить строки с учетом культурной среды
//         result = string.Compare(str3, str1, StringComparison.CurrentCulture);
//         if (result == 0)
//             Console.WriteLine("Строки str1 и str3 равны");
//         else if (result < 0)
//             Console.WriteLine("Строка str1 меньше строки str3");
//         else
//             Console.WriteLine("Строка str1 больше строки str3");
// 
//         Console.WriteLine();
// 
//         //Присвоить новую строку переменной str2.
//         str2 = "Один Два Три Один";
//         //Поиск подстроки
//         idx = str2.IndexOf("Один", StringComparison.Ordinal);
//         Console.WriteLine("Индекс первого вхождения подстроки <Один>: " + idx);
//         idx = str2.LastIndexOf("Один", StringComparison.Ordinal);
//         Console.WriteLine("Индекс последнего вхождения подстроки <Один>: " + idx);
//         Console.ReadKey();
//     }
// }

// class StringArrays // Продемонстрировать массивы строк
// {
//     static void Main()
//     {
//         string[] str = { "Это", "очень", "простой", "тест." };
// 
//         Console.WriteLine("Исходный массив: ");
//         for (int i = 0; i < str.Length; i++)
//             Console.Write(str[i] + " ");
//         Console.WriteLine("\n");
// 
//         //Изменить строку.
//         str[1] = "тоже";
//         str[3] = "до предела тест!";
// 
//         Console.WriteLine("Видоизмененный массив: ");
//         for (int i = 0; i < str.Length; i++)
//             Console.Write(str[i] + " ");
//         Console.ReadKey();
//     }
// }
// class ConvertDigitsToWords
// {
//     static void Main() //вывести отдельные цифры целого числа словами
//     {
//         int num;
//         int nextdigit;
//         int numdigits;
//         int[] n = new int[20];
// 
//         string[] digits = { "нуль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
// 
//         num = 1908;
// 
//         Console.WriteLine("Число: " + num);
// 
//         Console.Write("Число словами: ");
// 
//         nextdigit = 0;
//         numdigits = 0;
// 
//         // Получить отдельные цифры и сохранить их в массиве n.
//         // Эти цифры сохраняются в обратном порядке.
//         do
//         {
//             nextdigit = num % 10;
//             n[numdigits] = nextdigit;
//             numdigits++;
//             num = num / 10;
//         } while (num > 0);
//         numdigits--;
//         //вывести полученные слова.
//         for (; numdigits >= 0; numdigits--)
//             Console.Write(digits[n[numdigits]] + " ");
// 
//         Console.WriteLine();
//         Console.ReadKey();
// 
//     }
// }
//class SubStr // Применить метод Substring()
//{
//    static void Main()
//    {
//        string orgstr = "В C# упрощается обращение со строками.";
//
//        //сформировать подстроку
//        string substr = orgstr.Substring(5, 20);
//        Console.WriteLine("orgstr: " + orgstr);
//        Console.WriteLine("substr: " + substr);
//        Console.ReadKey();
//    }
//}

//     class StringSwitch //Продемонстрировать управление оператором switch посредством строк. 
// { static void Main()
//     {
//         string[] strs = { "один", "два", "три", "два", "один" };
// 
//         foreach(string s in strs) {
//             switch(s)
//             {
//                 case "один":
//                     Console.Write(1);
//                     break;
//                 case "два":
//                     Console.Write(2);
//                     break;
//                 case "три":
//                     Console.Write(3);
//                     break;
//             }
//         }
//         Console.WriteLine();
//         Console.ReadKey();
//     }
// 
// }