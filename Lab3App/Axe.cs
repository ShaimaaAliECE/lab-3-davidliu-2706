using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Axe : Tool, Displayable
    {
        public Axe(string Description) : base(Description)
        {
        }

        public void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }

        

        public override void Display()
        {
            Console.WriteLine("Axe "+ this.getDescription()+" is displayed");
        }
    }
}
