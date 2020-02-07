using System;

namespace trabajoclase4
{
    class Program
    {
        //proyecto calculadora
        //se espera recibir los argumentos calor1 (int) valor2 (string)
        //valor3 (int)
        //responder resultado en (int)
        static void Main(string[] args)
        {
            Console.WriteLine("valores");
            int res;
            int val1;
            int val2;
            string oper;

            Console.WriteLine("ingresa numero 1");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa numero 2");
            val2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Que operaciones vas a realizar");
            oper = Console.ReadLine();

            switch (oper)
            {
                case "+":
                    res = val1 + val2;
                    Console.WriteLine("es una suma" + res);
                    break;
                case "-":
                    res = val1 - val2;
                    Console.WriteLine("es una resta" + res);
                    break;
                case "*":
                    res = val1 * val2;
                    Console.WriteLine("es una multiplicacion" + res);
                    break;
                case "/":
                    Console.WriteLine("es una divicion, no se hacer division");
                    break;
                default:
                    Console.WriteLine("los argumentos no concuerdan");
                    break;
            }
        }
    }
}
