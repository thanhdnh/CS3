﻿using System.Collections;
using System.Collections.Generic;
class Program{
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
    static void GenerateList1D<T>(List<T> list){
        Random r = new Random();
        for(int i=0; i<5; i++)
            list.Add((dynamic)r.Next(1, 99));
    }
    static T SumList1D<T>(List<T> list){
        T sum = list[0];
        for(int i=1; i<list.Count; i++)
            sum += (dynamic)list[i];
        return sum;
    }
    static void GenerateList2D(List<List<object>> list2d){
        Random r = new Random();
        for(int i=0; i<5; i++){
            List<object> temp = new List<object>();
            for(int j=0; j<6; j++)
                temp.Add(r.Next(1, 99));
            list2d.Add(temp);
        }
    }
    static void PrintList2D(List<List<object>> list2d){
        for(int i=0; i<list2d.Count; i++){
            for(int j=0; j<list2d[i].Count; j++)
                System.Console.Write("{0, 5}", list2d[i][j]);
            System.Console.WriteLine();
        }
    }
    static void GenerateArrayList1D(ArrayList arl){
        Random r = new Random();
        for(int i=0; i<5; i++)
            arl.Add(r.Next(1, 99));
    }
    static int SumArrayList1D(ArrayList arl){
        int sum = 0;
        for(int i=0; i<arl.Count; i++)
            sum += (int)arl[i];
        /*foreach(int v in arl)
            sum += v;*/
        return sum;
    }
    static void Generate_A_L_AL(Array arr, List<int> list, ArrayList arl, int len){
        Random r = new Random();
        for(int i=0; i<len; i++){
            int v = r.Next(1, 99);
            arr.SetValue(v, i);
            list.Add(v);
            arl.Add(v);
        }
    }
    static ulong SumArray(Array arr){
        ulong sum = 0;
        foreach(int v in arr)
            sum += (ulong)v;
        return sum;
    }
    static ulong SumList(List<int> list){
        ulong sum = 0;
        foreach(int v in list)
            sum += (ulong)v;
        return sum;
    }
    static ulong SumArrayList(ArrayList arl){
        ulong sum = 0;
        foreach(int v in arl)
            sum += (ulong)v;
        return sum;
    }
    static void Main(string[] args){
        Console.Clear();
        int len = 1000000;
        Array arr = Array.CreateInstance(typeof(int), len);
        List<int> list = new List<int>();
        ArrayList arl = new ArrayList();
        Generate_A_L_AL(arr, list, arl, len);
        Timing timer = new Timing();
        timer.startTime();
        SumArray(arr);
        timer.StopTime();
        System.Console.WriteLine("Sum Array: {0} ms", timer.Result().TotalMilliseconds);
        timer.startTime();
        SumList(list);
        timer.StopTime();
        System.Console.WriteLine("Sum List: {0} ms", timer.Result().TotalMilliseconds);
        timer.startTime();
        SumArrayList(arl);
        timer.StopTime();
        System.Console.WriteLine("Sum ArrayList: {0} ms", timer.Result().TotalMilliseconds);
        /*ArrayList arl = new ArrayList();
        GenerateArrayList1D(arl);
        System.Console.WriteLine("Sum ArrayList: " + SumArrayList1D(arl));*/
        /*List<List<object>> list2d = new List<List<object>>();
        GenerateList2D(list2d); PrintList2D(list2d);*/
        /*List<float> list = new List<float>();
        GenerateList1D<float>(list);
        System.Console.WriteLine("Sum List: " + SumList1D<float>(list));*/
        /*Array arr2d;
        InitArray2D(out arr2d, new int[2]{3, 4}, new int[2]{0, 0});
        PrintArray2D(arr2d);
        System.Console.WriteLine("Sum Array2D: " + SumArray2D(arr2d));*/
        /*Array arr;
        InitArray1D(out arr, 5, 0);
        PrintArray1D(arr);*/
        /*Array arr = Array.CreateInstance(typeof(int), new int[1]{5}, new int[1]{5});
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            System.Console.WriteLine("arr[{0}]={1}", i, arr.GetValue(i));*/
        Console.ReadLine();
    }
}