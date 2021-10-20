using System;
namespace Command
{
    public class NoCommand:Command
    {
        public NoCommand()
        {
        }

        public void Execute()
        {
            //do nothing;
        }

        public void Undo()
        {
            //do nothing;
        }
    }
}
