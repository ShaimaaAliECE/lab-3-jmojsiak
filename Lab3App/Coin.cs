using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Coin : Treasure
    {

        public int Value;

        public Coin(string description, int score, int value)
        {
            Value = value;
            Description = description;
            Score = score;
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;

        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }

    }
}
