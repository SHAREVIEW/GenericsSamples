using System;

namespace Wrox.ProCSharp.Generics
{
    class Program
    {
        static void Main()
        {
            var list1 = new LinkedList();
            list1.AddLast(2);                  //boxing - convert a valnue type to a reference type
            list1.AddLast(4);
            list1.AddLast("6");
                                                        //unboxing - convert a reference type to a valnue type 
            foreach (int i in list1)
            {
                Console.WriteLine(i);       //unboxing
            }
            Console.ReadLine();
        }  
    }
}


/// 装箱：从值类型转为引用类型。如果方法需要把一个对象作为参数，同时
/// 传递一个值类型，装箱操作就会自动进行。另一方面，装箱的值类型可以
///使用拆箱操作转换为值类型。在拆箱时，需要使用类型强制转换运算符。
