using System;
using System.IO;

string textReaderText = "Em linguística, a noção de texto é ampla e ainda aberta a uma definição mais precisa. Grosso modo, pode ser entendido como manifestação linguística das ideias de um autor"
    + " que serão interpretadas pelo leitor de acordo com seus conhecimentos linguísticos e culturais. Seu tamanho é variável."
    + "“Conjunto de palavras e frases articuladas, escritas sobre qualquer suporte”.\n \n" + "“Obra escrita considerada na sua redação original e autêntica (por oposição a sumário, tradução, notas, comentários, etc.)";

Console.WriteLine("Texto original: " + textReaderText);
string linha, paragrafo = null;
var sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if(linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += '\n';
        break;
    }
}

Console.WriteLine($"Texto modificado: {paragrafo}");

int caracterLido;
char caracterConvertido;

var sw = new StringWriter();
sr = new StringReader(paragrafo);

while (true)
{
    caracterLido = sr.Read();
    if(caracterLido == -1)
    {
        break;
    }

    caracterConvertido = Convert.ToChar(caracterLido);

    if(caracterConvertido == '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caracterConvertido);
    }

    Console.WriteLine("Texto armazenado no StringWriter" + sw.ToString());
}