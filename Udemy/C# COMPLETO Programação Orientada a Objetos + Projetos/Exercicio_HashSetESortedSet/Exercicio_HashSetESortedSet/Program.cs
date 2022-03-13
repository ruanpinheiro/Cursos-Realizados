using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio_HashSetESortedSet.Entities;

namespace Exercicio_HashSetESortedSet
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> a = new HashSet<Student>();
            HashSet<Student> b = new HashSet<Student>();
            HashSet<Student> c = new HashSet<Student>();
            
            Console.Write("How many students for course A? ");
            int qtdA = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdA; i++)
            {
                a.Add(new Student(int.Parse(Console.ReadLine())));
            }

            Console.Write("How many students for course B? ");
            int qtdB = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdB; i++)
            {
                b.Add(new Student(int.Parse(Console.ReadLine())));
            }

            Console.Write("How many students for course C? ");
            int qtdC = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdC; i++)
            {
                c.Add(new Student(int.Parse(Console.ReadLine())));
            }

            HashSet<Student> abc = new HashSet<Student>(a);

            abc.UnionWith(b);
            abc.UnionWith(c);

            Console.WriteLine("Total students: " + abc.Count());
            
        }
    }
}