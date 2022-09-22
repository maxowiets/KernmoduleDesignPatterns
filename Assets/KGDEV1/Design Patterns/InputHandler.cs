using System.Collections;
using System.Collections.Generic;
using System.Windows.Input;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private List<KeyCommand> keyCommands = new List<KeyCommand>();

    public void HandleInput()
    {
        foreach (KeyCommand keyCommand in keyCommands)
        {
            keyCommand.command.Execute();
        }
    }

    public void BindInputToCommand(KeyCode key, IGameObjectCommand command)
    {
        keyCommands.Add(new KeyCommand()
        {
            key = key,
            command = command,
        });
    }



    public class KeyCommand
    {
        public KeyCode key;
        public IGameObjectCommand command;
    }
}
