public abstract class Maquina
{
    public int Price { get; set; }
    public int ProductionPerSecond { get; set; }
    public int ProducedQuantity { get; set; }
    public int ItensInHold { get; set; }
    public int MaxItemCapacity { get; set; }
    public bool IsBroken { get; set; }

    public string Name { get; set; }

    // public abstract void ProduzirItem();
    public void ProduzirItem()
    {
        if (IsBroken)
            return;
        
        if (ItensInHold >= MaxItemCapacity)
            return;
        
        ItensInHold += ProductionPerSecond;
        ProducedQuantity += ProductionPerSecond;
    }

    public int ColetarItem()
    {
        int Itens = ItensInHold;
        ItensInHold = 0;
        return Itens;
    }


}