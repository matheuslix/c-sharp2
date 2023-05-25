// // See https://aka.ms/new-console-template for more information


// //Faça uma função que recebe um double x e retorna uma função que recebe um valor e retorna valor^x.
// // Use System.Math.Pow para isso.

// FuncaoPotencia  montarFuncao(double valor)
// {
//     double func(double x)
//     {
//     return  Math.Pow(valor ,x);
//     }
//     return func;

// }

// var f = montarFuncao(5);
// Console.WriteLine(f(2));


// public delegate double FuncaoPotencia(double x);


using System;
using System.Collections.Generic;

IEnumerable<int> nums = Enumerable.get();

var collatz = nums.Where(n => n % 4 == 0).
Select(x=> x.Collatz(3)).
Where(n=> n<5);
int numeroQualquer = 69;
numeroQualquer.Collatz(10);
69.Collatz(3);

// Console.WriteLine(collatz);
foreach (var item in collatz)
{
    Console.WriteLine(item);
}




public static class Enumerable
{
    public static IEnumerable<T> Take<T>(
       this IEnumerable<T> coll, int N)
    {
        var it = coll.GetEnumerator();
        for (int i = 0; i < N && it.MoveNext(); i++)
            yield return it.Current;
    }


    public static IEnumerable<int> get()
    {
        for (int i = 0; i < 1000; i++)
            yield return i + 1;
    }

    public static int Collatz(this int n, int qtd)
    {
        for (int i = 0; i < qtd; i++)

        {

            if (n % 2 == 0)

                n /= 2;

            else n = n * 3 + 1;

        }

        return n;
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

        for (int i = 0; i < N && it.MoveNext(); i++) ;
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
        var it = coll.GetEnumerator();
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
        while (it.MoveNext()) ;
        return it.Current;
    }
}
