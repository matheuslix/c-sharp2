// See https://aka.ms/new-console-template for more information

using System;


Empregado empregadoAdmin = new Empregado("Matheus Ferreira", "11052933947", false, "matheuszinho", "04/02/1999");
int ponteiroEmpregado = 0;
Empregado[] vetorEmpregados = new Empregado[100];
Ponto[] vetorPontos = new Ponto[1000];
int ponteiroPonto = 0;
vetorEmpregados[ponteiroEmpregado++] = empregadoAdmin;



Console.WriteLine("Digite seu Usuario");
string mainUser = Console.ReadLine();
Console.WriteLine("Digite sua senha");
string userPassword = Console.ReadLine();
int indiceLogado = 0;
bool loop = true;
int Estado = 1;


while (loop)
{
    switch (Estado)
    {
        case 1:
            for (int i = 0; i < ponteiroEmpregado; i++)
            {
                if (mainUser == vetorEmpregados[i].getCPF())
                {

                    bool isPasswordRight = vetorEmpregados[i].verificaSenha(userPassword);
                    if (isPasswordRight)
                    {
                        indiceLogado = i;
                        Estado = 2;
                        Console.WriteLine("Login feito com sucesso");
                        break;
                    }
                    Console.WriteLine("Senha Incorreta");
                    break;
                }
                Console.WriteLine("Usuario Inválido");
            }
            break;

        case 2:
            Console.WriteLine("Escolha umas das opções");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1 - Inserir Ponto");
            if (vetorEmpregados[indiceLogado].isAdm())
            {
                Console.WriteLine("2 - Listar Empregados");
                Console.WriteLine("3 - Ver estatisticas mensais");
            }

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Estado = 3;
                    break;

                case 2:
                    if (vetorEmpregados[indiceLogado].isAdm())
                    {
                        Estado = 4;
                    }
                    Console.WriteLine("Escolha Inválida");
                    break;

                case 3:
                    if (vetorEmpregados[indiceLogado].isAdm())
                    {
                        Estado = 5;
                    }
                    Console.WriteLine("Escolha Inválida");
                    break;

                default:
                    Console.WriteLine("Escolha Inválida");
                    break;
            }
            break;

            case 3:
                string data;
                string horario;
                string CPF;
                DateTime horarioAtual;
                horarioAtual = DateTime.Now;
            
                Console.WriteLine("Digite a data");
                data = Console.ReadLine();
                Console.WriteLine("Digite horario");
                horario=Console.ReadLine();
                Console.WriteLine("Digite CPF");
                CPF = Console.ReadLine();

                for (int i = 0; i < ponteiroPonto; i++)
                {
                    if (vetorPontos[i].getCPF() == CPF)
                    {
                        if (vetorPontos[i].horaInicio != "0")
                        {
                            
                        }
                        
                        
                    }
                    
                }
                
                Estado = 2;
                break;

                default:
                    break;


    }
}












// empregadoAdmin.criarEmpregado(vetorEmpregados[ponteiroEmpregado++],"Luis","11111111111",false,"lulu","01/01/1900");

// criarEmpregado("Luis","11111111111",false,"lulu","01/01/1900");

void criarEmpregado(string Nome, string Cpf, bool AdminAcess, string Senha, string DataNascimento)
{

    vetorEmpregados[ponteiroEmpregado++] = new Empregado(Nome, Cpf, AdminAcess, Senha, DataNascimento);

}

// Console.WriteLine(vetorEmpregados[ponteiroEmpregado-1].retornaEmpregado());



// bool verificaCPF(Empregado[] vetorEmpregados, string Cpf)
//     {

//         for (int i = 0; i < vetorEmpregados.Length; i++)
//         {
//            if (vetorEmpregados[ponteiroEmpregado -1].getCPF()== Cpf)
//            {
//             return true;
//            }
//         }
//         return false;
//     }


public class Ponto
{
    public Ponto(string CpfEmpregado, string Data, string HoraInicio, string HoraTermino)
    {
        cpfEmpregado = CpfEmpregado;
        data = Data;
        horaInicio = HoraInicio;
        horaTermino = HoraTermino;
    }
    string cpfEmpregado;
    string data;
    public string horaInicio = "0";
    public string horaTermino = "0";

    public string getCPF()
    {
        return cpfEmpregado;
    }

}
public class Empregado
{
    public Empregado(string Nome, string Cpf, bool AdminAcess, string Senha, string DataNascimento)
    {
        nome = Nome;
        cpf = Cpf;
        isAdmin = AdminAcess;
        senha = Senha;
        dataNascimento = DataNascimento;
    }

    public string nome;
    string cpf;
    bool isAdmin;
    string senha;
    string dataNascimento;

    public string retornaEmpregado()
    {

        return $"nome: {nome}   dataNascimento: {dataNascimento}";
    }

    public bool verificaSenha(string Senha)
    {
        if (senha == Senha)
        {
            return true;
        }
        return false;
    }
    public bool isAdm()
    {
        return isAdmin;
    }
    public string getCPF()
    {
        return $"{cpf}";
    }

    //Implementacao #1
    // public string criarEmpregado(Empregado novoEmpregado,string Nome, string Cpf,bool AdminAcess, string Senha, string DataNascimento)
    // {
    //     if (isAdmin)
    //     {
    //         novoEmpregado = new Empregado( Nome,  Cpf, AdminAcess,  Senha,  DataNascimento);
    //         return "Novo Empregado criado com sucesso";
    //     }
    //     return "Acesso Negado";
    // }

    public void criarEmpregado(string Nome, string Cpf, bool AdminAcess, string Senha, string DataNascimento)
    {
        Nome = nome;
        cpf = Cpf;
        isAdmin = AdminAcess;
        senha = Senha;
        dataNascimento = DataNascimento;
    }


}



