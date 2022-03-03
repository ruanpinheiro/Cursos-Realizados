using System;
using System.IO;

CriarDiretoriosGlobo();

CriarArquivo();

var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argetina" ,"argentina.txt");

//MoverArquivo(origem, destino);

CopiarArquivo(origem, destino);


static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }

    if (File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }
    File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }

    if (File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo já existe na pasta de destino");
        return;
    }

    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");

    if (!File.Exists(path))
    {    
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH 0,901");
        sw.WriteLine("Dados atualizado em 20/01/2019");
    }
}

static void CriarDiretoriosGlobo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");

    if (!Directory.Exists(path))
    {

        var dirGlobo = Directory.CreateDirectory(path);
        var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("México");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
}
