﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest1
{
    public class PlatiniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new Titanium();
        }
    }
}