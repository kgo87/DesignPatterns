﻿using System;
namespace Decorator
{
    public abstract class CondimentDecorator: Beverage
    {
        public abstract override string Description { get; }
    }
}
