// See https://aka.ms/new-console-template for more information
using System;

namespace SeniorC 
{
    //En C# 9.0 era obligatorio el: static void Main(string[] args)
    class Program
    {
        public static void Main(){
            string inicial = "Hola tu cachorro";
            Console.WriteLine(inicial + (new TestAttribute().GetAnyText()));
        }
        //Console.WriteLine("Luego de C9");
        
    }   
    //Hasta aquí resumen de una estructura C#, necesito el namespace,
    // necesito la clase que sea del mismo nombre del archivo CS
    // y a partir de C# no es necesario en Main

}

