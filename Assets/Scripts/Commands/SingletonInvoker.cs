using System.Collections.Generic;
using UnityEngine;

public class SingletonInvoker
{
    static SingletonInvoker instance;

    public bool replay;

    public List<ICommand> Commands = new List<ICommand>();

    private SingletonInvoker()
    {
    }

    public void AddCommand(ICommand command)
    {
        Commands.Add(command);
    }

    public void ExecuteAllCommand(Transform player)
    {
        foreach (ICommand command in Commands)
        {
            command.Execute(player);
        }
    }

    public static SingletonInvoker GetInstance()
    {
        if (instance == null)
        {
            instance = new SingletonInvoker();
            Debug.Log(instance);
        }

        return instance;
    }
}