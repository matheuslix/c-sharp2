
public class Mat
{
    public Mat(int[] valores)
    {

        matriz = new int[3,3];
         for(int i=0;i<3;i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matriz[i,j] = valores[j + 3*i];
                
            }
        }

    }

    private int[,] matriz;

    public Mat Sum( Mat matrizExterna)
    {
         Mat resultado =  Mat.Empty();

         for(int i=0;i<3;i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultado.matriz[i,j]  = this.matriz[i,j] + matrizExterna.matriz[i,j];
                
            }
        }

         return resultado;
    }

    public Mat Sub( Mat matrizExterna)
    {
         Mat resultado = Mat.Empty();

        for(int i=0;i<3;i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultado.matriz[i,j]  = this.matriz[i,j] - matrizExterna.matriz[i,j];
                
            }
        }
         return resultado;
    }

    public Mat Mult( Mat matrizExterna)
    {
         Mat resultado = Mat.Empty();
        

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    resultado.matriz[i,j] = resultado.matriz[i,j] + this.matriz[i,k]*matrizExterna.matriz[k,j];
                }
            }
            
        }

         return resultado;
    }

    public double Det()
    {
        int primeiroTermo = 1;
        int segundoTermo = 1;
        int k=0;
        int z = 3;

        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
        {
            primeiroTermo *= this.matriz[i,k%3];
            k++;
        }
        for (int i = 2; i >= 0; i--)
        {
            segundoTermo *= this.matriz[z%3,i];
            z++;
        }
        k++;
        
        }

        


        double resultado = 0;
        double DiagonalSec = 1;
        double PositiveAux = this.matriz[1,2]*this.matriz[2,3]*this.matriz[3,1]+ this.matriz[1,3]*this.matriz[2,1]*this.matriz[3,2];
        double NegativeAux = this.matriz[1,1]*this.matriz[2,3]*this.matriz[3,2] + this.matriz[1,2]*this.matriz[2,1]*this.matriz[3,3];
        double diagonalPrim = 1;

        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i==j)
                {
                    diagonalPrim *= this.matriz[i,j];
                }
                if (i +j == 4)
                {
                    DiagonalSec *= this.matriz[i,j];
                }
            }
        }
        
        resultado = diagonalPrim + PositiveAux - (DiagonalSec + NegativeAux);

        return resultado;
    }
    public static Mat Empty() =>  new Mat(new int[] {0,0,0,0,0,0,0,0,0});
    

    public static Mat Identity() => new Mat(new int[] {1,0,0,0,1,0,0,0,1});
    

    public static string toString(Mat matriz)
        => $"---------\n{matriz.matriz[0,0]}  {matriz.matriz[0,1]}  {matriz.matriz[0,2]}\n{matriz.matriz[1,0]}  {matriz.matriz[1,1]}  {matriz.matriz[1,2]}\n{matriz.matriz[2,0]}  {matriz.matriz[2,1]}  {matriz.matriz[2,2]}\n---------";


    
    
}