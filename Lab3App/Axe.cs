﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(string description)
        {
            Description = description;
        }
        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

    }
}
