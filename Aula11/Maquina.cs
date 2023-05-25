public class Maquina
{
    int limiteMaximoRnd;
    public Maquina (int qtdPopupalacao)
    {
        limiteMaximoRnd = qtdPopupalacao;

    }


    public int EscolhePessoa()
    {
        Random rnd = new Random();
        return rnd.Next(0,limiteMaximoRnd);

    }


   
}