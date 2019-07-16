using System.Collections.Generic;
using UnityEngine;

public class CubeInputMap : MonoBehaviour, InputMap
{
    private IDictionary<KeyCode, ICommand> dict = new Dictionary<KeyCode, ICommand>();
    void Start()
    {
        ICommand up = new UpCommand();
        ICommand down = new DownCommand();
        ICommand left = new LeftCommand();
        ICommand right = new RightCommand();
        
        dict.Add(KeyCode.UpArrow,up);
        dict.Add(KeyCode.DownArrow,down);
        dict.Add(KeyCode.LeftArrow,left);
        dict.Add(KeyCode.RightArrow,right);
    }

    public void WhenInput(KeyCode key)
    {
        ICommand command;
        dict.TryGetValue(key,out command);
        
        command?.Execute(this.transform);
    }
}
