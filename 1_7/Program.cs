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