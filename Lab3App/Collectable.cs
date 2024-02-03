using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal class Collectable : Displayable
    {
        public String Description;

        public CollectionBoard Board;

        public virtual void Display()
        {

        }


        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
        }
    }
}
