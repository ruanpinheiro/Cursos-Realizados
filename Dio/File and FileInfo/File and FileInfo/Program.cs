using System;
using System.IO;


namespace File_and_FileInfo
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite o nome do arquivo: ");
           
            var nome = Console.ReadLine();
            
            nome = LimparNome(nome);
                    
            var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

            CriarArquivo(path);



            static string LimparNome(string nome)
            {
                foreach (var @char in Path.GetInvalidFileNameChars())
                {
                    nome = nome.Replace(@char, '-');
                }

                return nome;
            }

            static void CriarArquivo(string path)
            {
                try
                {
                    Console.WriteLine("Digite enter para finalizar...");
                    Console.ReadLine();

                    using var sw = File.CreateText(path);
                    sw.WriteLine("Está é a linha 1 do arquivo");
                    sw.WriteLine("Está é a linha 2 do arquivo");
                    sw.WriteLine("Está é a linha 3 do arquivo");

                }
                catch (Exception)
                {

                    Console.WriteLine("O nome do arquivo está inválido");
                }
                
            }
        }
    }
}
