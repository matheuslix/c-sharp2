// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

long rodada = 0;
long tamanhoPopulacao = 500;
int individuoAtual = 0;
List<Individuo> Populacao = new List<Individuo>();

Mundo.AddIndividuo<Cooperador>(200);
Mundo.AddIndividuo<Copiador>(100);
Mundo.AddIndividuo<Trapaceador>(50);
Mundo.AddIndividuo<Rabugento>(50);
Mundo.AddIndividuo<Tolerante>(100);