public class Tolerante : Individuo
{

    public int TimesToCheat;
    public int TimesCheated;

    public Tolerante()
    {
        TimesCheated = 0;
        TimesToCheat = 0;

    }
    public override bool Interagir()
    {
        Random rnd = new Random();
        int prob =  rnd.Next(1,11);
        if(TimesToCheat> 0)
        {
            TimesToCheat--;
            return false;
        }
        if (prob > 1)
        {
            return true;
        }
        return false;
        
    }

    public override void RecebeInteracao(bool interacao)
    {
        if (!interacao)
        TimesCheated++;
        if (TimesCheated >=3)
        {
            TimesCheated = 0;
            TimesToCheat += 3;
        }
    }
}