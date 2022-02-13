using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using Exercice_File.Entities;

namespace Exercice_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\Documents\Estudos C#\arquivo.csv";
            string directoryPath = @"D:\Documents\Estudos C#";


            List<Product> products = new List<Product>();

            try
            {

                using (StreamReader streamReader = File.OpenText(filepath))
                {
                    while (!streamReader.EndOfStream)
                    {
                        string vect = streamReader.ReadLine();
                        string[] vectSplit = vect.Split(',');

                        string[] nameProduct = new string[4];
                        double[] priceProduct = new double[4];
                        int[] quantityProduct = new int[4];
                        /* for (int x = 0; x <= 4; x++)
                         {
                             nameProduct[x] = vectSplit[0];
                             priceProduct[x] = double.Parse(vectSplit[x + 1], CultureInfo.InvariantCulture);
                             quantityProduct[x] = int.Parse(vectSplit[x + 2]);
                             products.Add(new Product(nameProduct[0], priceProduct[0], quantityProduct[0]));
                         }*/
                        nameProduct[0] = vectSplit[0];
                        priceProduct[0] = double.Parse(vectSplit[1], CultureInfo.InvariantCulture);
                        quantityProduct[0] = int.Parse(vectSplit[2]);
                        products.Add(new Product(nameProduct[0], priceProduct[0], quantityProduct[0]));

                        nameProduct[1] = vectSplit[3];
                        priceProduct[1] = double.Parse(vectSplit[4], CultureInfo.InvariantCulture);
                        quantityProduct[1] = int.Parse(vectSplit[5]);
                        products.Add(new Product(nameProduct[1], priceProduct[1], quantityProduct[1]));

                        nameProduct[2] = vectSplit[6];
                        priceProduct[2] = double.Parse(vectSplit[7], CultureInfo.InvariantCulture);
                        quantityProduct[2] = int.Parse(vectSplit[8]);
                        products.Add(new Product(nameProduct[2], priceProduct[2], quantityProduct[2]));

                        nameProduct[3] = vectSplit[9];
                        priceProduct[3] = double.Parse(vectSplit[10], CultureInfo.InvariantCulture);
                        quantityProduct[3] = int.Parse(vectSplit[11]);
                        products.Add(new Product(nameProduct[3], priceProduct[3], quantityProduct[3]));

                        foreach (Product p in products)
                        {
                            p.Total();
                        }
                    }

                    Directory.CreateDirectory(directoryPath + "\\out");
                    FileInfo summary = new FileInfo(directoryPath + "\\out" + "\\summary.csv");

                    using (StreamWriter streamWriter = summary.AppendText())
                    {
                        foreach (Product p in products)
                        {
                            streamWriter.WriteLine(p.ToString());
                        }
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(e.Message);
            }


        }
    }
}
