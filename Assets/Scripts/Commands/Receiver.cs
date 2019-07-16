using UnityEngine;

public class Receiver
{
    public void Up(Transform player)
    {
        player.Translate(0, 0, .5f);
    }

    public void Down(Transform player)
    {
        player.Translate(0, 0, -.5f);
    }

    public void Left(Transform player)
    {
        player.Translate(-.5f, 0, 0);
    }

    public void Right(Transform player)
    {
        player.Translate(.5f, 0, 0);
    }
}