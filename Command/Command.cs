﻿using System;
namespace Command
{
    public interface Command
    {
        public void Execute();

        public void Undo();
    }

}
