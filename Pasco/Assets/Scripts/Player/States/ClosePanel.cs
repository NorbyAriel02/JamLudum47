
using UnityEngine;

public class ClosePanel : State<PlayerInput>
{
    private Player player;
    private float time = 1f;
    private float currentTime;
    private State<PlayerInput> nextState;
    public ClosePanel(Player player, State<PlayerInput> nextState)
    {
        this.player = player;
        this.nextState = nextState;
    }

    public override void Enter()
    {
        player.SetClose();
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
