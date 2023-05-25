public class Trapaceador: Individuo
{

    public Trapaceador()
    {
        Cooperacao = false;
    }
    public override bool Interagir()
    {
        return Cooperacao;
    }

    public override void RecebeInteracao(bool interacao)
    {
        
    }
}