using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class MagicWand : Tool, Displayable
    {
        public MagicWand(string Description) : base(Description)
        {
        }

        
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            Console.WriteLine("MagicWand " + this.getDescription() + " is displayed");
        }
    }
}
