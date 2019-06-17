using System;

namespace Wrox.ProCSharp.Generics
{
  class Program
  {
    static void Main()
    {
      var list2 = new LinkedList<int>();
      list2.AddLast(1);
      list2.AddLast(3);
      list2.AddLast(5);

      foreach (int i in list2)
      {
        Console.WriteLine(i);
      }

      var list3 = new LinkedList<string>();   // no boxing - valnue types are stored in the List<int>
      list3.AddLast("2");
      list3.AddLast("four");
      list3.AddLast("foo");
                                                                    // no boxing, no cast needed
      foreach (string s in list3)
      {
        Console.WriteLine(s);     
      }
    }
  }
}


///List<T>类范类型定义为int，所以int类型在JIT编译器动态生成的类中使用，不再进行装箱和拆箱
///拆箱、装箱操作容易，但性能损失较大
///system.collections.generic名称空间的List<T>类不使用对象，而是在使用时定义类型。