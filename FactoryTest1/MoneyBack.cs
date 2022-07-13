﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTest1
{
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "MonyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
        }
    }
}
