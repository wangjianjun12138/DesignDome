﻿using SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    interface IFactory
    {
         IAnimal CreateInstance();
    }
}
