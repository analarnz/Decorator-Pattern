﻿using DecoratorPattern.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteClass
{
    public class JalapenoTopping : ToppingsDecorator
    {
        public JalapenoTopping(BasePizza pizzaToDecorate)
            : base(pizzaToDecorate)
        {
            this.myPrice = 1.49;
        }
    }
}
