using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Diamond:Treasure, Displayable
    {
        private int Value;
        public Diamond(String name, int score) : base(name,score)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Diamond"+this.getDescription()+" is displayed");
        }
    }
}
