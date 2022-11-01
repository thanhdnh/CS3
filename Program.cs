using System.Collections;
using System.Collections.Generic;
class Program
{
  static int SeqSearch(int[] arr, int value)
  {
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == value) return i;
    return -1;
  }
  static int SeqLastSearch(int[] arr, int value)
  {
    int t = -1;
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == value)
        t = i;
    return t;
  }
  static List<int> SeqMultiSearch(int[] arr, int value)
  {
    List<int> list = new List<int>();
    for (int i = 0; i < arr.Length; i++)
      list.Add(i);
    return list;
  }

  static int RecuSearch(int[] arr, int from, int value)
  {
    if (arr.Length == 0 || from == arr.Length)
    {
      return -1;
    }
    else if (arr[from] == value)
    {
      return from;
    }
    else
    {
      return RecuSearch(arr, ++from, value);
    }
  }
  static int SenSearch(int[] A, int value)
  {
    int x = A[A.Length - 1];
    A[A.Length - 1] = value;
    int i = 0;
    for (; i < A.Length; i++)
      if (A[i] == value)
        break;
    A[A.Length - 1] = x;
    if (i < A.Length - 1 || A[A.Length - 1] == value)
      return i;
    else return -1;
  }

  static int BinSearch(int[]A,int value){
    int l=0,r=A.Length-1;
    int m=0;
    while(l<=r){
      m=(l+r)/2;
      if(A[m]<value) l=m+1;
      else if(A[m]>value) r=m-1;
      else if(A[m]==value) return m;
    }
    return -1;
  }
  static int IntegratedBinSearch(int[]A, int value){
    int[] Index = new int[A.Length];
    int[] CopyValue= new int[A.Length];
    for(int i = 0;i<Index.Length;i++)
    {
      Index[i]=i;
      CopyValue[i]=A[i];
    }
    for(int i =0;i<CopyValue.Length-1;i++)
      for(int j = i+1;j<CopyValue.Length;j++)
      if (CopyValue[i]>=CopyValue[j])
      {
        int m = CopyValue[i];
        CopyValue[i] = CopyValue[j];
        CopyValue[j] = m;
        m = Index[i];
        Index[i] = Index[j];
        Index[j] = m;
      }
      return Index[BinSearch(CopyValue,value)];

  }
  static void Main(string[] args)
  {
    Console.Clear();
    int[] arr = new int[10] { 1, 4, 9, 15, 9, 20, 9, 16, 10, 19 };
    int value = 9;
    int[] sarr = new int[6]{2, 6, 7, 9, 11, 15};
    //System.Console.WriteLine(BinSearch(sarr, value));
    System.Console.WriteLine(IntegratedBinSearch(arr,value));
    Console.ReadLine();
  }
}