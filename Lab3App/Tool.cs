using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Tool:Collectable
    {
        public Tool(string Description) : base(Description)
        {}

        public virtual void DoAction()
        {
            Console.WriteLine(this.GetType().Name+" is Used");
        }

        public override void AddMe(List<Collectable> l)
        {
            base.AddMe(l);
            DoAction();
        }



    }
}
