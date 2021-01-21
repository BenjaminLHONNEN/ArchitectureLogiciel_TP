using System;

namespace ArchiLogi.TP.Adapter
{
    public class AdapterProgram
    {
        /// <summary>
        /// Entré du programme.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public static void AdapterMain(string[] args)
        {
            DotEnvV1 dotEnvV1 = new DotEnvV1();
            DotEnvV2 dotEnvV2 = new DotEnvV2();

            DotEnvV1Parser dotEnvV1Parser = new DotEnvV1Parser(dotEnvV1);
            DotEnvV2Parser dotEnvV2Parser = new DotEnvV2Parser(dotEnvV2);

            DisplayEnvInfo(dotEnvV1Parser);

            Console.WriteLine();

            DisplayEnvInfo(dotEnvV2Parser);

            Console.ReadLine();
        }

        /// <summary>
        /// Affiche les information de l'adapter.
        /// </summary>
        /// <param name="adapter">Adapter.</param>
        static void DisplayEnvInfo(IDotEnvAdapter adapter)
        {
            Console.WriteLine(adapter.Get("Host"));
            Console.WriteLine(adapter.Get("Port"));
            Console.WriteLine(adapter.Get("User"));
            Console.WriteLine(adapter.Get("Password"));
        }
    }
}
