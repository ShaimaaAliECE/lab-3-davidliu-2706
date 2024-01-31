using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Collectable
    {
        public CollectionBoard Board;
        private String Description;

        public Collectable(String Description) 
        {
            this.Description = Description;
        }

        public String getDescription()
        {
            return this.Description;
        }

        public virtual void AddMe(List<Collectable> l)
        {
            l.Add(this);
            Console.WriteLine(this.Description+" Collected, Congrats!!!!");
        }

        public virtual void Display() { }
    }
}
