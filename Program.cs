using System;
using System.Collections;
public class Program
{
  static void Main()
  {
    Console.Clear();
    
    Account acc1 = new Account("ID01", "abc", "123", "Hi!");
    Account acc2 = new Account("ID02", "def", "123", "Hello!");
    Account acc3 = new Account("ID03", "ikl", "123", "Hey!");
    AccountDict accdict = new AccountDict();
    accdict.Add(acc1.getId(), acc1);
    accdict.Add(acc2.getId(), acc2);
    accdict.Add(acc3.getId(), acc3);
    IDictionaryEnumerator en = accdict.GetEnumerator();
    while(en.MoveNext())
      System.Console.WriteLine("{0}=>{1}", en.Key, en.Value);

    Console.ReadLine();
  }
}