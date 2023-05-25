// See https://aka.ms/new-console-template for more information


Mat minhaMatriz = Mat.Empty();
Console.WriteLine(Mat.toString(minhaMatriz));
Mat matrizinha = new Mat(new int[] {1,2,3,4,5,6,0,0,1});
Mat matrizinha2 = new Mat(new int[] {1,2,3,4,5,6,0,0,1});

Mat soma =matrizinha.Sum(matrizinha2);
Console.WriteLine(Mat.toString(soma));
soma.Det();