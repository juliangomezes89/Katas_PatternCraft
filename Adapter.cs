public class MarioAdapter : IUnit
{
    public Mario mario;
    public MarioAdapter(Mario mario)
    {
        this.mario = mario;
    }
    public void Attack(Target target)
    {
        target.Health -= this.mario.jumpAttack();
    }
}
