public class Rabugento: Individuo
{
    public Rabugento()
    {
        
        Cooperacao = true;
    }
    

    
    public override bool Interagir()
    {
       return Cooperacao;
    }

    public override void RecebeInteracao(bool interacao)
    {
        if (!interacao)
            Cooperacao = false;

    }
}