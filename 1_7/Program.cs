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