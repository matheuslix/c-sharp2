public class cncMachine : Maquina
{
    public cncMachine(string name)
    {
        Name = name;
        Price = 20;
        ProductionPerSecond = 1;
        ProducedQuantity = 0;
        ItensInHold = 0;
        MaxItemCapacity = 60;
        IsBroken = false;
    }

    
}