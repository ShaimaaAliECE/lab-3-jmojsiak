using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Treasure : Collectable
    {
        public int Score { get; set; }

        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);

            UpdateTotalScore();
        }
    }
}
