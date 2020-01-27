using System;

namespace trabajo1_part2
{
    class program //clase basica
    {
        //variable de la clase
        static string nombre = "Roberto";
        static void Main(string[] args)//void no regresa nada
        {
            //respondemos con el primer argumento
            if (args[0].Length > 0 && args[0] == nombre)
            {
                Console.WriteLine($"Hola {args[0]} {args[1]}");
            }
            else
            {
                Console.WriteLine("Usar unathorized");
            }
            
        }
        
         
    }
}

