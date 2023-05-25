using System;
using static System.Console;

Maquina[] MyMachines = new Maquina[20];
int cncCount = 0;
int furadeiraCount = 0;
Maquina[] LojaMachines = new Maquina[2];
LojaMachines[0] = new cncMachine("0");
LojaMachines[1] = new Furadeira("0");
int ponteiroMaquinas = 0;
int MyItens = 0;
ConsoleKeyInfo key_pressed;
WriteLine("____________Instruções___________________\n");
WriteLine("Espaço -> Produz 1 Bico Injetor\n");
WriteLine("s -> Abrir loja\n");
WriteLine("i -> Inventario de Máquinas\n");
int Estado = 0;
DateTime tempoReferencia = DateTime.Now;
DateTime tempoAtual;
TimeSpan diffTime;

while (true) // loop principal game
{
    switch (Estado)
    {
        case 0:

            while (!KeyAvailable) // Loop que roda até o usuario pressionar algo
            {


                // funcao contar tempo, e chamar incrementa producao das maquinas
                tempoAtual = DateTime.Now;
                diffTime = tempoAtual - tempoReferencia;
                if (diffTime.TotalSeconds >= 1)
                {
                    for (int i = 0; i < ponteiroMaquinas; i++)
                    {
                        MyMachines[i].ProduzirItem();
                    }
                    Console.Clear();
                    WriteLine($"Seus bicos {MyItens}");
                    tempoReferencia = DateTime.Now;
                }
                


            }
            key_pressed = Console.ReadKey(true);

            switch (key_pressed.Key)
            {

                case ConsoleKey.Spacebar:
                    Console.Clear();
                    WriteLine($"Seus bicos {MyItens}");

                    MyItens++;


                    break;
                case ConsoleKey.S:
                    WriteLine("Abrindo a loja");
                    Estado = 1;
                    break;
                case ConsoleKey.I:
                    WriteLine("Abrindo Inventario de Maquinas");
                    Estado = 2;
                    break;
                default:
                    break;
            }
            break;


        case 1:// Caso a Loja esteja aberta
            int pos;
            Console.Clear();
            WriteLine("Selecione uma maquina para comprar");
            WriteLine("1 - Máquina CNC\n    Preço: 100\n    Producao por segundo: 1 ");
            WriteLine("2 - Máquina Furadeira\n    Preço: 20\n    Producao por segundo: 2 ");
            while (Estado == 1)
            {
                while (!KeyAvailable) // Loop que roda até o usuario pressionar algo
                {

                }
                key_pressed = Console.ReadKey(true);
                switch (key_pressed.Key)
                {
                    case ConsoleKey.D1:
                        pos = ((int)ConsoleKey.D1 - 48) - 1;
                        ComprarItem(pos);

                        break;

                    case ConsoleKey.D2:
                        pos = ((int)ConsoleKey.D2 - 48) - 1;
                        ComprarItem(pos);
                        break;

                    case ConsoleKey.Backspace:
                        Estado = 0;
                        break;
                    default:
                        break;
                }


            }

            break;
        case 2:// Caso maquinario esteja aberto
            bool myLoop = true;
            WriteLine("Suas Maquinas:\n");
            for (int i = 0; i < ponteiroMaquinas; i++)
            {
                WriteLine($"({i}) {MyMachines[i].Name} -> Estoque: {MyMachines[i].ItensInHold}");
            }

            while (myLoop)
            {
                while (!KeyAvailable) // Loop que roda até o usuario pressionar algo
                {


                }
                key_pressed = Console.ReadKey(true);
                switch (key_pressed.Key)
                {

                    case ConsoleKey.Backspace:
                        Estado = 0;
                        myLoop = false;
                        break;

                    case ConsoleKey.C:
                        WriteLine("Coletando bicos");
                        for (int i = 0; i < ponteiroMaquinas; i++)
                        {
                            MyItens += MyMachines[i].ItensInHold;
                            MyMachines[i].ItensInHold = 0;
                        }

                        break;

                    default:
                        break;
                }
            }
            break;
    }
}


void ComprarItem(int pos)
{
    WriteLine(pos);
    if (MyItens >= LojaMachines[pos].Price) // se o usuario pode comprar
    {

        MyItens -= LojaMachines[pos].Price;


        switch (pos)
        {
            case 0:
                MyMachines[ponteiroMaquinas++] = new cncMachine($"cnc {cncCount++}");



                WriteLine("Compra de CNC MACHINE efetuada com sucesso");
                break;
            case 1:
                MyMachines[ponteiroMaquinas++] = new Furadeira($"furadeira {furadeiraCount++}");


                WriteLine("Compra de Furadeira efetuada com sucesso");
                break;

        }
    }
    else
    {
        WriteLine("Você não pode comprar este item ainda");
        WriteLine("Pressione Backspace para retornar");
    }
}