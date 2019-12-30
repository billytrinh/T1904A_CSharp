using System;
using System.Collections;
using System.Collections.Generic;

namespace T1904A
{
    class Program
    {
        public int number;
        public static int year;
        static void Main(string[] args)
        {
            int x = 10;
            dynamic y;
            y = 20;
            Program p = new Program();
            p.number = 100;
            Program.year = 2020;
            
            Console.WriteLine(x+y);
            string str;
            if (x > 20)
            {
                str = "hello";
            }
            else
            {
                 str = "world";
            }
            Console.WriteLine(str);
            int[] arr = {1, 2, 3, 4, 5};
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j<arr.Length)
            {
                Console.WriteLine(arr[j]);
                j++;
            }
            ShowMenu();
            Program p2 = new Program();
            p2.GetInfo();
            
            Console.WriteLine("Nhap 1 chuoi:");
            string s = Console.ReadLine();
            Console.WriteLine("nhap 1 so nguyen:");
            int n = Convert.ToInt32(Console.ReadLine());
            
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("xin chao");
            List<int> listInt = new List<int>();
            listInt.Add(1);
            listInt.Add(5);
            foreach (int i in listInt)
            {
                Console.WriteLine(i);
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. A");
            Console.WriteLine("2. B");
            Console.WriteLine("3. C");
        }

        void GetInfo()
        {
            Console.WriteLine("Info");
        }
        
    }
}