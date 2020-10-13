using UnityEngine;

public class Collecting : State<PlayerInput>
{
    private Player player;
    private float time = 1f;
    private float currentTime;
    private State<PlayerInput> nextState;
    public Collecting(Player player, State<PlayerInput> nextState, float delay)
    {
        this.player = player;
        this.nextState = nextState;
        this.time = delay;
    }

    public override void Enter()
    {
        player.Collecting();
        currentTime = 0;
    }
    public override State<PlayerInput> Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= time)
        {
            return nextState;
        }
        return null;
    }
}
