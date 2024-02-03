using System;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(string description)
        {
            this.Description = description;
        }
        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used");
        }

    }
}
