using UnityEngine;

public class LeftCommand : ICommand
{
    private Receiver receiver;

    public LeftCommand()
    {
        this.receiver = new Receiver();
    }
    
    public void Execute(Transform player)
    {
        receiver.Left(player);
    }
}
