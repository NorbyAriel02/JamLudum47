
public class IdleState : State<PlayerInput>
{

    private Player player;

    public IdleState(Player player)
    {
        this.player = player;
    }

    public override void Enter()
    {
        player.Idle();
    }
    
}
