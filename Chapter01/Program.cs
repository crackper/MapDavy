﻿using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace Chapter01
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new Workflow1());

            Console.WriteLine("Precione ENTER PARA SALIR");
            Console.WriteLine("Precione ENTER PARA SALIR");
            Console.WriteLine("Precione ENTER PARA SALIR");
            Console.ReadLine();   
        }
    }
}
