// using System;

// using System.Collections.Generic;

// using System.Linq;



// IEnumerable<int> num = get();

// IEnumerable<int> num4 = num.Where(n => n % 4 == 0);




// var tamanho = num.Count();

// var collatz = num.Select(x => Enumerable.Collatz(x));
















// IEnumerable<int> get()

// {

//     for (int i = 0; i < 1000; i++)

//         yield return i + 1;

// }





// public static class Enumerable

// {

//     public static int Collatz(this int num, int qnt)

//     {

//         for (int i = 0; i < qnt; i++)

//         {

//             if (num % 2 == 0)

//                 num /= 2;

//             else num = num * 3 + 1;

//         }

//         return num;

//     }

//     public static IEnumerable<T> Where<T>(

//       this IEnumerable<T> coll,

//       Func<T, bool> condition

//     )

//     {

//         foreach (var el in coll)

//         {

//             if (condition(el))

//                 yield return el;

//         }

//     }




//     public static IEnumerable<R> Select<T, R>(

//       this IEnumerable<T> coll,

//       Func<T, R> selector

//     )

//     {

//         foreach (var el in coll)

//             yield return selector(el);

//     }




//     public static IEnumerable<T> Take<T>(

//       this IEnumerable<T> coll, int N)

//     {

//         var it = coll.GetEnumerator();

//         for (int i = 0; i < N && it.MoveNext(); i++)

//             yield return it.Current;

//     }




//     public static int Count<T>(IEnumerable<T> coll)

//     {

//         int count = 0;




//         var it = coll.GetEnumerator();

//         while (it.MoveNext())

//             count++;



//         return count;

//     }



//     public static IEnumerable<T> Skip<T>(

//       this IEnumerable<T> coll, int N)

//     {

//         int i = 0;

//         foreach (var el in coll)

//         {

//             if (i++ < N)

//                 continue;



//             yield return el;

//         }

//     }



//     public static IEnumerable<T> Append<T>(

//       IEnumerable<T> coll, T obj)

//     {

//         foreach (var el in coll)

//             yield return el;

//         yield return obj;

//     }



//     public static IEnumerable<T> Prepend<T>(

//       IEnumerable<T> coll, T obj)

//     {

//         yield return obj;

//         foreach (var el in coll)

//             yield return el;

//     }



//     public static T[] ToArray<T>(

//       IEnumerable<T> coll)

//     {

//         int index = 0;

//         T[] array = new T[Count(coll)];




//         var it = coll.GetEnumerator();

//         while (it.MoveNext())

//         {

//             array[index] = it.Current;

//             index++;

//         }




//         return array;

//     }



//     public static IEnumerable<T> Concat<T>(

//       IEnumerable<T> frs, IEnumerable<T> scn)

//     {

//         foreach (var el in frs)

//             yield return el;



//         foreach (var el in scn)

//             yield return el;

//     }




//     public static T FirstOrDefault<T>(

//       IEnumerable<T> coll)

//     {

//         var it = coll.GetEnumerator();

//         if (it.MoveNext())

//             return it.Current;

//         return default(T);

//     }




//     public static T LastOrDefault<T>(

//       IEnumerable<T> coll)

//     {

//         var it = coll.GetEnumerator();

//         if (!it.MoveNext())

//             return default(T);




//         while (it.MoveNext()) ;

//         return it.Current;

//     }

// }