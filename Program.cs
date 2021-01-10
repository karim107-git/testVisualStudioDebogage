﻿using System;

namespace testDebogage
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.Write("Introduire un nombre : ");
            bool resultat=int.TryParse(Console.ReadLine(),out int myNumber);
            
            
            
            if (resultat) //si l'entrée est un nombre
            {
                maClasse classe = new maClasse("john", "nash", myNumber);
                Console.WriteLine("Hello World!");
                maClasse c = classe;
                Console.WriteLine(c.ToString());
                Console.WriteLine("tout est Ok");
              
            }
            else //si l'entrée n'est pas numérique
            {
                Console.WriteLine("Il faut entrer un entier pour te dire hello world");
            }


           
        
        }
    }
}
