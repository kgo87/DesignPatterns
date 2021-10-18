using System;
using System.Text;

namespace Command
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;

        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];
            Command noCommand = new NoCommand();

            for (var i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
        }

        public string toString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Remote Control");
            for (var i = 0; i < onCommands.Length; i++)
            {
                sb.AppendLine("slot " + i + " " + onCommands[i].ToString() + " " + offCommands[i].ToString());
            }
            return sb.ToString();
        }
    }
}
