using DecoratorPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteClass
{
    public class ExtraCheeseTopping : ToppingsDecorator
    {
        public ExtraCheeseTopping(BasePizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            this.myPrice = 0.99;
        }
    }
}
