using System;

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
