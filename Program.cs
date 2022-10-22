﻿class Program{
    static void GenerateArray1D(out Array arr, int len, int lb){
        arr = Array.CreateInstance(typeof(int), new int[1]{len}, new int[1]{lb});
        Random r = new Random();
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            arr.SetValue(r.Next(1, 99), i);
    }
        static void PrintArray1D(Array arr){
        foreach(int v in arr)
            System.Console.Write(v + " ");
        System.Console.WriteLine();
    }
    static int SumArray1D(Array arr){
        int sum = 0;
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            sum += (int)arr.GetValue(i);
        /*foreach(int v in arr)
            sum += v;*/
        return sum;
    }
    static void GenerateArray2D(out Array arr, int len1, int len2, int lb1, int lb2){
        arr = Array.CreateInstance(typeof(float), new int[2]{len1,len2}, new int[2]{lb1,lb2});
        Random r = new Random();
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
                arr.SetValue(r.NextSingle()*10, i, j);
    }
    static void PrintArray2D(Array arr){
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++){
            for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
                System.Console.Write("{0, 12}", arr.GetValue(i, j));
            System.Console.WriteLine();
        }
    }
    static void PrintUnderArray2D(Array arr){
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++){
            for(int j=arr.GetLowerBound(1); j<=arr.GetUpperBound(1); j++)
                if(i>=j)
                    System.Console.Write("{0, 12}", arr.GetValue(i, j));
                else
                    System.Console.Write("{0, 12}", "");
            System.Console.WriteLine();
        }
    }
    static void PrintUnderArray2D2(Array arr){
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++){
            for(int j=arr.GetLowerBound(1); j<=arr.GetLowerBound(1) + i -1; j++)
                    System.Console.Write("{0, 12}", arr.GetValue(i, j));
            System.Console.WriteLine();
        }
    }
    static void GenerateList1D<T>(List<T> list, int times){
        Random r = new Random();
        for(int i=0; i<times; i++)
            list.Add((dynamic)r.Next(1, 10)*10);
    }
    static void PrintList1D<T>(List<T> list){
        /*for(int i=0; i<list.Count; i++)
            System.Console.Write("{0, 5}", list[i]);*/
        foreach(T v in list)//T hoac dynamic hoac var
            System.Console.Write("{0, 5}", v);
    }
    static T SumList<T>(List<T> list){
        T sum = list[0];
        for(int i=1; i<list.Count; i++)
            sum += (dynamic)list[i];
        /*foreach(T v in list)
            sum += (dynamic)v;
        sum -= (dynamic)list[0];*/
        return sum;
    }
    static void Main(string[] args){
        Console.Clear();

        List<float> list = new List<float>();
        GenerateList1D<float>(list, 5);
        PrintList1D<float>(list);
        System.Console.WriteLine("\nSum List1D: {0}", SumList<float>(list));

        /*Array arr;
        GenerateArray2D(out arr, 5, 5, 1, 1);
        PrintArray2D(arr);
        System.Console.WriteLine();
        PrintUnderArray2D(arr);
        PrintUnderArray2D2(arr);*/

        /*Array arr;
        GenerateArray1D(out arr, 5, 1);
        PrintArray1D(arr);
        System.Console.WriteLine("Tong Array: {0}", SumArray1D(arr));*/

        /*Array arr = Array.CreateInstance(typeof(int), new int[1]{5}, new int[1]{1});
        System.Console.WriteLine("Chi so duoi {0}", arr.GetLowerBound(0));
        System.Console.WriteLine("Chi so tren {0}", arr.GetUpperBound(0));
        System.Console.WriteLine("Length {0}", arr.GetLength(0));
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            System.Console.WriteLine("arr[{0}]={1}", i, arr.GetValue(i));
        
        for(int i=arr.GetLowerBound(0); i<arr.GetLowerBound(0)+arr.GetLength(0); i++)
            System.Console.WriteLine("arr[{0}]={1}", i, arr.GetValue(i));*/
        Console.ReadLine();
    }
}