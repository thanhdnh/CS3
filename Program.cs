using System.Collections;
using System.Collections.Generic;
class Program
{
  public class Node
  {
    public Node next;
    public object data;
  }
  public class MyStack
  {
    Node top;
    public bool IsEmpty()
    {
      return top == null;
    }
    public void Push(object ele)
    {
      Node n = new Node();
      n.data = ele;
      n.next = top;
      top = n;
    }
    public Node Pop()
    {
      if (top == null)
        return null;
      Node d = top;
      top = top.next;
      return d;
    }
  }

  public class Node2
  {
    public Node2 prev, next;
    public object data;
  }
  public class MyQueue
  {
    Node2 rear, front; public bool IsEmpty()
    {
      return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
      Node2 n = new Node2();
      n.data = ele;
      if (rear == null)
      {
        rear = n; front = n;
      }
      else
      {
        rear.prev = n;
        n.next = rear; rear = n;
      }
    }
    public Node2 Dequeue()
    {
      if (front == null) return null;
      Node2 d = front;
      front = front.prev;
      if (front == null)
        rear = null;
      else
        front.next = null;
      return d;
    }
  }
  static void GenerateStack(MyStack ms, int times)
  {
    Random R = new Random();
    for (int i = 1; i <= times; i++)
      ms.Push(R.Next(1, 100));
  }
  static int SumStack(MyStack ms)
  {
    int Sum = 0;
    MyStack a = new MyStack();
    while (ms.IsEmpty() == false)
    {
      int t = (int)ms.Pop().data;
      Sum += t;
      a.Push(t);
    }
    while (a.IsEmpty() == false)
      ms.Push((int)a.Pop().data);
    return Sum;
  }
  static int FindX(MyStack ms, int x)
  {
    int index = 0;
    int temp = -1;
    MyStack tmp = new MyStack();
    while (!ms.IsEmpty())
    {
      temp = (int)ms.Pop().data;
      tmp.Push(temp);
      if (temp == x)
        break;
      else index++;
    }
    if (ms.IsEmpty() && temp != x)
      index = -1;
    while (tmp.IsEmpty() == false)
      ms.Push((int)tmp.Pop().data);
    return index;
  }
  static int FindX2(MyStack ms, int x)
  {
    MyStack ms1 = new MyStack();
    int count = 0;
    while (!ms.IsEmpty())
    {
      int temp = (int)ms.Pop().data;
      if (temp != x)
      {
        ms1.Push(temp);
        count++;
      }
      else
      {
        while (!ms1.IsEmpty())
          ms.Push(ms1.Pop().data);
        return count;
      }
    }
    return -1;
  }
  static int FindQ(MyQueue mq, int x)
  {
    MyQueue q1 = new MyQueue();
    int index = 0;
    int temp = 0;
    bool flag = false;
    int count = 0;
    while(!mq.IsEmpty())
    {
        temp = (int)mq.Dequeue().data;
        q1.Enqueue(temp);
        if(x == temp && count == 0)
        {
            flag = true;
            count++;
        }
        if(flag == false)
            index++;
    }
    if(x != temp && flag == false)
        index = -1;
    while(!q1.IsEmpty())
        mq.Enqueue((int)q1.Dequeue().data);
    return index;
  }
  static void Main(string[] args)
  {
    Console.Clear();
    MyStack ms = new MyStack();
    //GenerateStack(ms, 10);

    //System.Console.WriteLine("Sum of Stack: {0}", SumStack(ms));
    //ms.Push(1);
    //ms.Push(2); ms.Push(3); ms.Push(4); ms.Push(5);
    //System.Console.WriteLine(FindX(ms, 6));
    //System.Console.WriteLine(FindX2(ms, 6));
    MyQueue mq = new MyQueue();
    mq.Enqueue(1); mq.Enqueue(2); mq.Enqueue(2); mq.Enqueue(3); 
    mq.Enqueue(4); mq.Enqueue(5);
    System.Console.WriteLine(FindQ(mq, 6));
    
    Console.ReadLine();
  }
}