﻿class Program{
    static void InitArray1D(out Array arr, int len, int lb){
        arr = Array.CreateInstance(typeof(int), new int[1]{len}, new int[1]{lb});
        Random r = new Random();
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            arr.SetValue(r.Next(1, 99), i);
    }
    static void PrintArray1D(Array arr){
        System.Console.Write("Mang 1D: ");
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
    static void InitArray2D(out Array arr, int[] len, int[] lb){
        arr = Array.CreateInstance(typeof(float), len, lb);
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
    static float SumArray2D(Array arr){
        float sum = 0;
        foreach(float v in arr)
            sum += v;
        return sum;
    }
    static void Main(string[] args){
        Console.Clear();
        Array arr2d;
        InitArray2D(out arr2d, new int[2]{3, 4}, new int[2]{0, 0});
        PrintArray2D(arr2d);
        System.Console.WriteLine("Sum Array2D: " + SumArray2D(arr2d));
        /*Array arr;
        InitArray1D(out arr, 5, 0);
        PrintArray1D(arr);*/
        /*Array arr = Array.CreateInstance(typeof(int), new int[1]{5}, new int[1]{5});
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            System.Console.WriteLine("arr[{0}]={1}", i, arr.GetValue(i));*/
        Console.ReadLine();
    }
}