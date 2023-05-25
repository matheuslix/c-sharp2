public static class Mundo
{
    public static List<Individuo> Populacao = new List<Individuo>();
    public static void AddIndividuo<T>(int quantidade)
    where T : Individuo, new()
    {
        for(int i = 0; i < quantidade; i++)

            Populacao.Add(new T());
    }
    public static void Interacao()
    {
        Individuo ind1;
        Individuo ind2;
        int index = 0;
        Random rnd = new Random();
        long days = 0;
        while (Populacao.Count != 0)
        {
            for (int i = 0; i < Populacao.Count; i+=2)
            {
                index = rnd.Next(Populacao.Count);
                ind1 = Populacao[index];
                index += rnd.Next(Populacao.Count -1);
                ind2 = Populacao[index % Populacao.Count];

                bool resposta1 = ind1.Interagir();
                bool resposta2 = ind2.Interagir();
                ind1.RecebeInteracao(resposta2);
                ind2.RecebeInteracao(resposta1);
                
            }

            Console.WriteLine("Days passed " + days);
        }

    }


}