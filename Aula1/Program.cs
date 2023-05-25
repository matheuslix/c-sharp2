// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using System.IO; // Interação com arquivos


if(args.Length < 1) // Verifica se foi passado o arquivo no inicio do programa
{
    WriteLine("Adiciona o caminho do arquivo");
    return;
}

string path = args[0];

StreamReader reader = new StreamReader(path);
string code = reader.ReadToEnd();

int p = 0;
int[] memory = new int [1024];


int[] vetorAux = new int [50];
int indiceLoop = -1;

for(int i=0; i<code.Length; i++)
{
    char character = code[i];

    switch (character)
    {
        case '+':
            memory[p]++;
            
            break;
        
        case '-':
            memory[p]--;
            
            break;

        case '<':
            p--;
            if (p<0)
            {
                WriteLine("Memória insuficiente");
                return;
            }
            break;
        
        case '>':
            p++;
            if (p>1023)
            {
                WriteLine("Memória insuficiente");
                return;
            }
            break;
        
        case '.':
            int value = memory[p];
            WriteLine((char) value);
            break;

        case '[': 
        if (memory[p] == 0)
        {
            int innerLoops = 0;
            for (; i < code.Length; i++)
            {
                if (code[i]== '[')
                {
                    innerLoops++;
                }
                else if (code[i]== ']')
                {
                    innerLoops--;
                    if(innerLoops <0)
                    break;
                }
            }
        }
        indiceLoop++;
        vetorAux[indiceLoop] = i;

            break;

        case ']':
            if ((memory[p] > 0))
            {

                i = vetorAux[indiceLoop];
            }
            else
            {
                indiceLoop--;
                
            }
            break;

        case ',':
           ConsoleKeyInfo info =  ReadKey(true);
            int input = (int)info.KeyChar;
            memory[p] = input;
            
            break;
        default:
        WriteLine("a");
            break;
    }
}

