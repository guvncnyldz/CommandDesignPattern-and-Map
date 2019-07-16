using UnityEngine;

public class UpCommand : ICommand
{
    private Receiver receiver;

    public UpCommand()
    {
        this.receiver = new Receiver();
    }

    public void Execute(Transform player)
    {
        receiver.Up(player);
    }
}