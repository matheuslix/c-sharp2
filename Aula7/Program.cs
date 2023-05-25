// See https://aka.ms/new-console-template for more information
using System;
// ListInt lista1 = new ListInt();

// for (int i = 0; i < 50; i++)
// {
//     lista1.Add(i);
// }

// for (int i = 0; i < lista1.Length; i++)
// {
//     Console.WriteLine(lista1[i]);
// }

ListaEncadeada lista1 = new ListaEncadeada();
lista1.Add(10);
lista1.Add(99);
lista1.Add(5);
Console.WriteLine(lista1.Length);
Console.WriteLine(lista1[0]);
Console.WriteLine(lista1[1]);
Console.WriteLine(lista1[2]);


class ListInt
{
    public ListInt()
        => lista = new int[3];

    public int Length => ponteiroLista;

    private int[] lista;
    private int ponteiroLista = 0;

    public int this[int index]
    {
        get => lista[index];
        set => lista[index] = value;
    }

    public void Add(int Valor)
    {
        if (ponteiroLista == lista.Length)
        {
            int[] listaAux = lista;
            lista = new int[2 * lista.Length];
            for (int i = 0; i < listaAux.Length; i++)
                lista[i] = listaAux[i];
        }
        lista[ponteiroLista++] = Valor;

        
    }
}

class Node
{

    public int Valor;
    public Node Proximo = null;
}

class ListaEncadeada
{
    
    public int Length = 0;
    public Node First;
    
    public void Add(int Valor) //:)
    {
        if (First == null)
        {
            First = new Node();
            First.Valor = Valor;
            First.Proximo = null;
            Length++;
            return;
        }
        else
        {
            Node Atual = First;
            Node Novo = new Node();
            Novo.Valor = Valor;
            Novo.Proximo = null;
            
            while (Atual.Proximo != null)
            {
                Atual = Atual.Proximo;
            }
            Atual.Proximo = Novo;
            Length++;
        }        
    }

    public int this[int index]
    {
        get
        {
            Node Atual = First;
            int indice= 0;

            while (indice != index)
            {
                Atual = Atual.Proximo;
                indice++;
            }
            return Atual.Valor;
        }

        set
        {
            Node atual = First;
            int indice= 0;
            while (indice != index)
            {
                atual = atual.Proximo;
                indice++;
            }
            atual.Valor = value;
        }
    }
}