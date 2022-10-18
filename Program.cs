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
    static void Main(string[] args){
        Console.Clear();
        Array arr;
        InitArray1D(out arr, 5, 0);
        PrintArray1D(arr);
        /*Array arr = Array.CreateInstance(typeof(int), new int[1]{5}, new int[1]{5});
        for(int i=arr.GetLowerBound(0); i<=arr.GetUpperBound(0); i++)
            System.Console.WriteLine("arr[{0}]={1}", i, arr.GetValue(i));*/
        Console.ReadLine();
    }
}