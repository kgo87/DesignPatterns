using System;
using System.Text;

namespace Command
{
    public class RemoteControl
    {
        Command[] onCommands;
        Command[] offCommands;
        Command undoCommand;

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

            undoCommand = noCommand;
        }

        public void SetCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            undoCommand.Undo();
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
