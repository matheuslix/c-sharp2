
using System;
using static System.Console;
using System.IO;

namespace Conversor
{
    public class decimalTobin
    {
         void decimalToBin(int numero)
        {    int pos = 0;
        int [] vetor = new int[32];
            while (numero/2 != 1)
            {
                vetor[pos] = numero%2;
                numero = numero/2;
                pos++;
            }
            pos++;
            vetor[pos] = numero;

            for (int i = pos; i >= 0; i--)
            {
                WriteLine(vetor[i]);

            }
            
        }
    }
}
