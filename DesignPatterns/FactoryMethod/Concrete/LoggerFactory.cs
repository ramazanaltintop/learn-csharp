﻿using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Concrete
{
    public class LoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //Business to decide factory
            return new FileLogger();
        }
    }
}
