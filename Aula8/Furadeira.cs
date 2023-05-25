public class Furadeira : Maquina
{
    public Furadeira(string name)
    {
        Name = name;
        Price = 40;
        ProductionPerSecond = 2;
        ProducedQuantity = 0;
        ItensInHold = 0;
        MaxItemCapacity = 40;
        IsBroken = false;
    }

    
}