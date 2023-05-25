using System;
using static System.Console;
using System.IO;


// int num;
// byte num2;
// sbyte num3;
// short num4;
// long num5;
// char caracter1;
// string texto;
// bool aux;
// float num6;
// double num7;
// float f = 0f;
// decimal m = 0m;
// int [] vetorINT = new int[200];
// int [] vetorINT2 = new int[] {1,2,3};

var b = 'a'; // var é um recebe um tipo uma vez apenas, e nao pode mudar
dynamic c = 's'; //dynamic pode alterar o seu tipo durante runtime
int a = 0b00001111;

string decimalToBin(int numero)
        {    
        int pos = 0;
        int aux = 0;
        
        int [] vetor = new int[32];
        string numeroBin = "";
        if (numero == 1)
        {
            numeroBin = numeroBin + (char)('0' + numero);
            return numeroBin;
        }
            while (((int)(numero/2) != 1))
            {
                vetor[pos] = numero%2;
                numero = numero/2;
                pos++;
            }
            pos++;
            numero = (int)(numero/2);
            vetor[pos] = numero;

            for (int i = pos; i >= 0; i--)
            {
                // Write(vetor[i]);
                numeroBin = numeroBin + (char)('0' + vetor[i]);
                aux++;

    }
        
           
            return numeroBin;
        }

void moveBits(int numero, int deslocamento)
        {
        string numeroBin;
         numero = numero << deslocamento;   
         WriteLine("Deslocamento");
        WriteLine(decimalToBin(numero));
        
        }
// int n  = int.Parse(ReadLine()); Recursividade
// int fatorial(int n)
// {
//     if (n< 2)
//     {
//         return 1;
//     }
//     return n * fatorial(n - 1);
// }


WriteLine(decimalToBin(1));
moveBits(1,2);

