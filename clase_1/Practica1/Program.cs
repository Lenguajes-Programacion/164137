using System;
// importamos la libreria principal.
namespace practica_uno
{
    class program //clase basica
    {
        //variable de la clase
        static string nombre = "Roberto";
        static void Main(string[] args)//void no regresa nada
        {
            //respondemos con el primer argumento
            Console.WriteLine($"Hola {args[0]} {args[1]}");
        }
        if(nombre == "Roberto"){
            Console.WriteLine("Hola");
            }
        else{
             Console.WriteLine("No eres tu");
            }
         
    }
}