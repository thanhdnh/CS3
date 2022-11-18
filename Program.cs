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

    /*AccountDict accdict = new AccountDict();
    accdict.Add(acc1.getId(), acc1);
    accdict.Add(acc2.getId(), acc2);
    accdict.Add(acc3.getId(), acc3);
    IDictionaryEnumerator en = accdict.GetEnumerator();
    while(en.MoveNext())
      System.Console.WriteLine("{0}=>{1}", en.Key, en.Value);*/

    /*Dictionary<string, Account> dict = new Dictionary<string, Account>();
    dict.Add(acc1.getId(), acc1);
    dict.Add(acc2.getId(), acc2);
    dict.Add(acc3.getId(), acc3);
    foreach(KeyValuePair<string, Account> kvp in dict)
      System.Console.WriteLine("{0}=>{1}", kvp.Key, kvp.Value);*/

    /*SortedDictionary<string, Account> sdict = new SortedDictionary<string, Account>();
    sdict.Add(acc2.getId(), acc2);
    sdict.Add(acc3.getId(), acc3);
    sdict.Add(acc1.getId(), acc1);
    foreach(KeyValuePair<string, Account> kvp in sdict)
      System.Console.WriteLine("{0}=>{1}", kvp.Key, kvp.Value);*/

    HTAccount htacc1 = new HTAccount("ID01", "abc", "123", "Hello!");
    HTAccount htacc2 = new HTAccount("ID02", "def", "123", "Hey!");
    HTAccount htacc3 = new HTAccount("ID03", "ijk", "123", "Hi!");
    List<HTAccount> lhtacc = new List<HTAccount>();
    lhtacc.Add(htacc1);
    lhtacc.Add(htacc2);
    lhtacc.Add(htacc3);
    foreach(HTAccount v in lhtacc)
      System.Console.WriteLine(v);

    Console.ReadLine();
  }
}