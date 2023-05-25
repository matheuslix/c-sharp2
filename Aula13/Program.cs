using System;
using System.Collections.Generic;
using System.Linq;
 
List<int> list = new List<int>();
list.Add(1);
list.Add(2);
list.Add(3);
 
Stack<string> stack = new Stack<string>();
stack.Push("1");
stack.Push("2");
stack.Push("3");

 Console.WriteLine(Enumerable.Count<string>(Enumerable.Skip<string>(stack,1)));
 Console.WriteLine(Enumerable.Count<string>(Enumerable.Append<string>(stack,"aaa")));
 Console.WriteLine(Enumerable.Count<string>(Enumerable.Prepend<string>(stack,"bbb")));
 int[] arrayConvertida = Enumerable.ToArray<int>(list);
 for (int i = 0; i < arrayConvertida.Length; i++)
 {
    Console.WriteLine(arrayConvertida[i]);
 }

// Console.WriteLine(Enumerable.Count<int>(Enumerable.Take<int>(list, 2))); // 2
// Console.WriteLine(Enumerable.Count<string>(Enumerable.Take<string>(stack, 10))); // 3
 
public static class Enumerable
{
    public static IEnumerable<T> Take<T>(
       this IEnumerable<T> coll, int N)
    {
        var it = coll.GetEnumerator();
        for (int i = 0; i < N && it.MoveNext(); i++)
            yield return it.Current;
    }
 
    public static int Count<T>(IEnumerable<T> coll)
    {
        int count = 0;
 
        var it = coll.GetEnumerator();
        while (it.MoveNext())
            count++;
         
        return count;
    }
    
    public static IEnumerable<T> Skip<T>(
        this IEnumerable<T> coll, int N)
    {
        var it = coll.GetEnumerator();
        
        for (int i = 0; i < N && it.MoveNext(); i++);
        while (it.MoveNext())
            yield return it.Current;
        
            
    }
    
    public static IEnumerable<T> Append<T>(
        IEnumerable<T> coll, T obj)
    {
        var it = coll.GetEnumerator();
       
        while (it.MoveNext())
            yield return it.Current;
            
        yield return obj;
    }
    
    public static IEnumerable<T> Prepend<T>(
        IEnumerable<T> coll, T obj)
    {
        
        yield return obj;
        var it = coll.GetEnumerator();
        while (it.MoveNext())
            yield return it.Current;
            
        
    }
    
    public static T[] ToArray<T>(
        IEnumerable<T> coll)
    {
        var it  = coll.GetEnumerator();
        T[] array = new T[Enumerable.Count(coll)];
        int i = 0;

        while (it.MoveNext())
        {
            array[i] = it.Current;
            i++;
        }

        return array;
    }
    
    public static IEnumerable<T> Concat<T>(
        IEnumerable<T> frs, IEnumerable<T> scn)
    {
        var it = frs.GetEnumerator();
        

        while (it.MoveNext())
            yield return it.Current;
    
        it = scn.GetEnumerator();
        while (it.MoveNext())
            yield return it.Current;
    }

    public static T FirstOrDefault<T>(
        IEnumerable<T> coll)
    {
        // default(T)
        var it = coll.GetEnumerator();

       if (it.MoveNext())
            return it.Current;

        else
            return default(T);
        
    }

    public static T LastOrDefault<T>(
        IEnumerable<T> coll)
    {
        var it = coll.GetEnumerator();
        if (!it.MoveNext())
        {
         return default(T); //Lista vazia
        }
        while (it.MoveNext());
         return it.Current;
    }
}
