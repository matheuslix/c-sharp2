// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;
using System.IO; // Interação com arquivos



byte[] compact(byte[] originalData)
{
    int tamanho = originalData.Length;
    int aux = 0;
    byte mask = 240;
    if(tamanho%2 == 0)
    {
        WriteLine("Caso par");
        byte[] compactedData = new byte[tamanho/2];
        for (int i = 0; i < tamanho; i+=2)
        {
            compactedData[aux] = (byte)((originalData[i] & mask) | (originalData[i+1]>>4));
            aux++;
        }
        for (int i = 0; i < compactedData.Length; i++)
        {
            WriteLine(compactedData[i]);
        }
        return compactedData;
    }
    else
    {
        WriteLine("Caso impar");
        byte[] compactedData = new byte[(tamanho+1)/2];
        for (int i = 0; i < tamanho; i+=2)
        {
            if (i!=tamanho-1)
            {
               compactedData[aux] = (byte)((originalData[i] & mask) | (originalData[i+1]>>4)); 
            }
            else
            {
                compactedData[aux] = (byte)((originalData[i] & mask));
            }
            aux++;
        }
        for (int i = 0; i < compactedData.Length; i++)
        {
            WriteLine(compactedData[i]);
        }
        return compactedData;
    }

    
}





byte[] decompact(byte[] compactedData, int fillingMode = 0)
{
    byte mask = 0;
    switch (fillingMode)
    {
        case 1:
            mask = 15;
            break;
        case 2: 
            mask = 7;
            break;
        default:
        break;
    }
    int tamanho = compactedData.Length*2;
    byte[] decompactData = new byte[tamanho];
    int aux = 0;
    for (int i = 0; i < compactedData.Length; i++)
    {
        WriteLine(aux);
        WriteLine(i);
        decompactData[aux] = (byte)(compactedData[i] & 240 | mask);
        decompactData[aux+1] = (byte)(compactedData[i] << 4 | mask);
        aux+=2;
    }
    for (int i = 0; i < decompactData.Length; i++)
        {
            WriteLine(decompactData[i]);
        }
    return decompactData;

}


// byte[] original = new byte[]{240,240,237};
// compact(original);
// byte[] original2 = new byte[]{255,17};
// decompact(original2,0);
