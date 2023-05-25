public class Copiador: Individuo
{
    
    public bool  lastBehaviour = true;
    public override bool Interagir()
    {
        return  lastBehaviour;
    }


    public override void RecebeInteracao(bool interacao)
    {
        lastBehaviour = interacao;
    }
}