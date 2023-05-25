public class Cooperador:Individuo
{   
    public Cooperador()
    {
        Cooperacao = true;
    }
    public override bool Interagir()
    {
        return true;
    }

    public override void RecebeInteracao(bool interacao)
    {
    
    }
}