using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{

    public class Program
    {
        //Functia pt ex 1
        static string StringInversat(string text)
        {
            try
            {
                char[] sirCaractere = text.ToCharArray();
                Array.Reverse(sirCaractere);
                return new string(sirCaractere);

            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
                
            }

            return text;
        }



        enum OperationType
        {
            Par = 0,
            Impar = 1
        }

        static List<int> ExtrageLista(List<int> listaNumere, OperationType operatie)
        {
            List<int> listaFiltrata = new List<int>();
            foreach (int numar in listaNumere)
                if (operatie == OperationType.Par & numar % 2 == 0)
                {
                    listaFiltrata.Add(numar);
                }
                else if(operatie == OperationType.Impar & numar % 2 == 1)
                {
                    listaFiltrata.Add(numar);
                }
            return listaFiltrata;
                
        }
                

        static void Main(string[] args)
        {
            //Test problema 1
            Console.WriteLine(StringInversat("Soare" ));
            Console.WriteLine();

            //Test problema 2
            List<int> listaNumere = new List<int>() { 3, 5, 2, 4, 4, 3, 1, 8, 10, 6, 4 };
            List<int> numereExtrase = ExtrageLista(listaNumere, OperationType.Par);
            foreach(int numar in numereExtrase)
            {
                Console.Write(numar + " ");
            }

            Console.WriteLine("\n");

            //Test problema 3
            List<Constructie> listaConstructii = new List<Constructie>();
            listaConstructii.Add(new CladireBirou(30.45, "Ialomita", 13, 25.5, "CEVA SRL", 12));
            listaConstructii.Add(new CladireBirou(100.25, "Campului", 24, 30.76, "Maricica", 25));
            listaConstructii.Add(new CladireBirou(120.14, "Giurgiului", 37, 24.89, "Altceva", 24));
            listaConstructii.Add(new Casa(202.17, "Colentina", 49, 30.12, 5, 4));
            listaConstructii.Add(new Casa(203.89, "Alta strada", 53, 20.56, 6, 8));
            foreach (Constructie constructie in listaConstructii) { 
                Console.WriteLine(constructie.ToString());
                Console.WriteLine();
            }
            
        }
    }
}
