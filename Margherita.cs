using DecoratorPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteClass
{
    public class Margherita : BasePizza
    {
        public Margherita()
        {
            this.myPrice = 6.99;
        }
    }
}
