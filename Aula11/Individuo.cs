public abstract class Individuo
{
    public int LastColleagueAction;
    public int MyMoney = 10;
    public bool Cooperacao;
    public abstract bool Interagir();
    public abstract void RecebeInteracao(bool interacao);
     public void Azar()
     {
        Random rnd  = new Random();
        int Numero = rnd.Next(10);
        if (Numero  < 1)
        {
            MyMoney--;
        }


     }

    // public Individuo Duplicar<T>()
    // where T : Individuo,new()
    // {
    //     return new T();
    // }
    
    
    // public Individuo ClonarIndividuo()
    // {

        
    // }

}