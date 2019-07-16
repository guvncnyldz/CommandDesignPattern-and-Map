using System.Collections.Generic;
using UnityEngine;

public class SphereInputMap : MonoBehaviour, InputMap
{
    private IDictionary<KeyCode, ICommand> dict = new Dictionary<KeyCode, ICommand>();
    void Start()
    {
        ICommand up = new UpCommand();
        ICommand down = new DownCommand();
        ICommand left = new LeftCommand();
        ICommand right = new RightCommand();
        
        dict.Add(KeyCode.W,up);
        dict.Add(KeyCode.S,down);
        dict.Add(KeyCode.A,left);
        dict.Add(KeyCode.D,right);
    }

    public void WhenInput(KeyCode key)
    {
        ICommand command;
        dict.TryGetValue(key,out command);
        
        command?.Execute(this.transform);
    }
}
