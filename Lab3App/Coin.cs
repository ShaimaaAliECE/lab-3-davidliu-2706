using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin:Treasure,Displayable
    {
        private int Value;

        public Coin(string Description, int score, int value) : base(Description, score)
        {
            this.Value = value;
        }

        public void UpdateTotalValue() 
        {
            Board.TotalValue += this.Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);

        }

        public override void Display()
        {
            Console.WriteLine("Coin "+this.getDescription()+" is displayed");
        }

        public override void AddMe(List<Collectable> l)
        {
            base.AddMe(l);
           UpdateTotalValue();
        }

    }
}
