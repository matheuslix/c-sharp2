// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Cliente cliente1 = new Cliente("1111");
// cliente1.Nome  = "Matheus";

// Console.WriteLine(cliente1.Formatar());

// public class Cliente
// {
// public string Nome;
// private string cpf;
//     public string CPF{
//         get
//         {
//             return cpf;
//         }
//         set
//         {
//             cpf = value;
            
//         }
//     }

//     public Cliente(string cpf)
//     {
//         CPF = cpf;
//     }
    
//     public string Formatar()
//     {
//         return $"{Nome} {(CPF)}"; 
//     }
// }

Cliente cliente1 = new Cliente("Matheus","111.111.222-33","Rua loucura");
Console.WriteLine(cliente1.CPF);
public class Cliente
{

    public Cliente(string nome, string Cpf, string endereco)
    {
        CPF = Cpf;
        Nome = nome;
        Endereco = endereco;
        
    }
    public string Nome;
    public string Endereco;
    private long cpf;
    public string CPF 
    {
        get
        {
            return cpf.ToString("000\\.000\\.000\\-00");
        }
        set
        {

             cpf = long.Parse(value.Replace("-","").Replace(".",""));
              
        }

    }

    // public string cpfToString(long cpf)
    // {
        
    //     return cpf.ToString("000.000.000-00");

    // }
    // public long stringToLong(string texto)
    // {
    //     long conversion;
    //     texto = texto.Replace("-",".");
    //     string[]  textoSeparado = texto.Split(".");

    //     string textoFinal = textoSeparado[0] + textoSeparado[1] +textoSeparado[2] +textoSeparado[3];
    //     conversion = long.Parse(textoFinal);

    //     return conversion;
    // }

}
