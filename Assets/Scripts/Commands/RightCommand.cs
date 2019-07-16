using UnityEngine;

public class RightCommand : ICommand
{
    private Receiver receiver;

    public RightCommand()
    {
        this.receiver = new Receiver();
    }
    
    public void Execute(Transform player)
    {
        receiver.Right(player);
    }
}
