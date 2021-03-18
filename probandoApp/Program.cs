using System;

namespace probandoApp
{
    class Program
    {
        static void Main(string[] args)
        {

            try {

                int i;

                i = int.Parse(Console.ReadLine());
            }
            catch (System.Exception e) when (e.GetType() != typeof(FormatException)) {} 
             
        }
    }
}
