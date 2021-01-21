using System;
using ArchiLogi.TP.Adapter;
using ArchiLogi.TP.Factory;

namespace ArchiLogi.TP
{
    class Program
    {
        /// <summary>
        /// Entré du programme.
        /// </summary>
        /// <param name="args">Arguments.</param>
        static void Main(string[] args)
        {
            AdapterProgram.AdapterMain(args);
            FactoryProgram.FactoryMain(args);

            Console.ReadLine();
        }
    }
}
