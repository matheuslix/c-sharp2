using System;
using static System.Console;
using System.IO;


float eval(string texto)
{
   
    float resultado = 0;
    
   
    string[] subStrings = texto.Split(' ');
    // foreach (string item in subStrings)
    // {
    //     WriteLine(item);
    // }
    float[] nums = new float[2];
    int indiceNum=0;
    char operacaoAtual = '\n';
    bool doOperation = false;

    for (int i = 1; i <= subStrings.Length; i++)
    {

        if (i%2 == 0)
        {
            operacaoAtual =  subStrings[i][0];
            WriteLine(operacaoAtual);
        }
        else
        {
            if (indiceNum == 2)
            {
                WriteLine(nums[0]);
                WriteLine(nums[1]);
                switch (operacaoAtual)
                {
                    case '+':
                    
                    resultado = nums[0] + nums[1];
                    WriteLine(resultado);
                        break;
                    case '-':
                    resultado = nums[0] - nums[1];
                        break;
                    case '/':
                    resultado = nums[0] / nums[1];
                        break;
                    case '*':
                    resultado = nums[0] * nums[1];
                        break;
                    default:
                        break;
                }
                indiceNum =0;
            }
            nums[indiceNum] = float.Parse(subStrings[i-1]);
            indiceNum++;

        }
        
    }
    return resultado;

}

eval("10 + 20");