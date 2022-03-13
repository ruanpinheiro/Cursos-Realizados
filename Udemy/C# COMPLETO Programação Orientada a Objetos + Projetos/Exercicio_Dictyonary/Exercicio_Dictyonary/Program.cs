using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Exercicio_Dictyonary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Documents\Cursos\Udemy\C# COMPLETO Programação Orientada a Objetos + Projetos\Exercicio_Dictyonary\in.txt";

            Dictionary<string, int> candidatos = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string candidato = line[0];
                        int votos = int.Parse(line[1]);

                        if (candidatos.ContainsKey(candidato))
                        {
                            candidatos[candidato] += votos;
                        }
                        else
                        {
                            candidatos[candidato] = votos;
                        }


                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Excessão gerada" + e.Message);
            }

            foreach (var x in candidatos)
            {
                Console.WriteLine(x.Key + " " + x.Value);
            }
        }
    }
}
