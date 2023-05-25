// See https://aka.ms/new-console-template for more information

using System.Linq;
using System.Collections.Generic;

var myStream = new StreamReader("INFLUD21-01-05-2023.csv");
var cabecalho = myStream.ReadLine()?.Split(";");
myStream.Close();

int vacinatedColumn = cabecalho
    .Select((valor, indice) => new { valor, indice })
    .FirstOrDefault(x => x.valor == "VACINA_COV")?.indice ?? -1;

int indiceMorb = cabecalho
    .Select((valor, indice) => new { valor, indice })
    .FirstOrDefault(x => x.valor == "EVOLUCAO")?.indice ?? -1;

int indiceCovid = cabecalho
    .Select((valor, indice) => new { valor, indice })
    .FirstOrDefault(x => x.valor == "CLASSI_FIN")?.indice ?? -1;

var query = get()
    .Where(c => c.IsCovid)
    .Where(c => c.Vacinated)
    .Where(c => c.Dead)
    .Count();

Console.WriteLine(query);


    // var query2= File.ReadAllLines("INFLUD21-01-05-2023.csv").Select(x => x)
    //     .Where(x => (x.Split(';')[indiceMorb] == "1" && x.Split(';')[vacinatedColumn] == "2") ).Count();

    // Console.WriteLine(query2);

    // // .GroupBy(x=>x.Split(";")[4] == "PR")

IEnumerable<Case> get()
{
    StreamReader reader = new StreamReader("INFLUD21-01-05-2023.csv");
    
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var data = line.Split(';');
        var covid = new Case();

        covid.Dead = data[indiceMorb] == "2";
        covid.Vacinated = data[vacinatedColumn] == "1";
        covid.IsCovid = data[indiceCovid] == "5"; // sl kkkk

        yield return covid;
    }

    reader.Close();
}

public class Case
{
    public bool Vacinated { get; set; }
    public bool Dead { get; set; }
    public bool IsCovid { get; set; }
}