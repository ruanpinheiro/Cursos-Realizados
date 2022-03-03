using System.IO;
using System;

var path = @"D:\Documents\Cursos\Dio\Directory and DirectoryInfo\Directory and DirectoryInfo\bin\Debug\net5.0\globo";

using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeletd;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine($"Monitorando eventos na pasta {path}");
Console.WriteLine("Pressione [enter] para finalizar....");
Console.ReadLine();


void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnDeletd(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o arquivo {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"O arquivo {e.OldName} foi renomado para {e.Name}");
}