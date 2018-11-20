using DecoratorPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteClass
{
    public class Gourmet : BasePizza
    {
        public Gourmet()
        {
            this.myPrice = 7.49;
        }
    }
}
