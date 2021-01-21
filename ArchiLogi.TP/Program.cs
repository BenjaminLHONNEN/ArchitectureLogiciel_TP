﻿using System;
using ArchiLogi.TP.Adapter;

namespace ArchiLogi.TP
{
    class Program
    {
        static void Main(string[] args)
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

        static void DisplayEnvInfo(IDotEnvAdapter adapter)
        {
            Console.WriteLine(adapter.Get("Host"));
            Console.WriteLine(adapter.Get("Port"));
            Console.WriteLine(adapter.Get("User"));
            Console.WriteLine(adapter.Get("Password"));
        }
    }
}
