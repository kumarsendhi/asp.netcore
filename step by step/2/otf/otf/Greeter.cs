﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace otf
{
    public interface IGreeter
    {
        string GetGreeting();
    }

    public class Greeter : IGreeter
    {
        public string GetGreeting()
        {
            return "Hello from Greeter";
        }
    }
}
