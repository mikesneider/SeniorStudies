// See https://aka.ms/new-console-template for more information
using System;

namespace SeniorC 
{
    //En C# 9.0 era obligatorio el: static void Main(string[] args)
    class Program
    {
        public static void Main(){
            string? inicial = "Hola CSharp 11 \n ";
            //como C# puedo poner el ? para que me acepte un valor NULL
            Console.WriteLine(inicial );
            new TestAttribute().GetAnyText(); //llamo a la función Main de GetAttribute

        }
        
        public void NovedadAtributte()
        {
            //Primero, Attribute es para crear un tipo de objeto (type) particular utilizando herencia
            //https://docs.microsoft.com/es-ES/dotnet/api/system.attribute?view=net-6.0
            
        }    
    }   
    //Hasta aquí resumen de una estructura C#, necesito el namespace,
    // necesito la clase que sea del mismo nombre del archivo CS
    // y a partir de C# no es necesario en Main PERO
    // sin el namespace ni nada, esto sirve para hacer un console program para Azure o GutHubAction
    //Y sin el namespace vale la pena para hacer el seguimiento. 

}

