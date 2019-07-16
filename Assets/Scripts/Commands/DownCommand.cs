using UnityEngine;

public class DownCommand : ICommand
{
    private Receiver receiver;

    public DownCommand()
    {
        this.receiver = new Receiver();
    }
    
    public void Execute(Transform player)
    {
        receiver.Down(player);
    }
}
