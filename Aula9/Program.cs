// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Exemplo<int> dados1 = new Exemplo<int>();
dados1.Valor = 3;



Exemplo<string> dados2 = new Exemplo<string>();

dados2.Valor = "aaaaa";

Exemplo<Exemplo<string>> dados3 = new Exemplo<Exemplo<string>>();

dados3.Valor = dados2;


public class Exemplo<T>
{
    public T Valor {get;set;}
}