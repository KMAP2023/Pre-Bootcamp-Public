public class Ranger : Enemy
{

    public int Distance { get; set; } = 5;


    public Ranger() : base("Robin Hood", 135)
    {
        Attack ShootAnArrow = new Attack("Shoot An Arrow", 20);
        AttackList.Add(ShootAnArrow);
        Attack ThrowAKnife = new Attack("Throw a Knife", 15);
        AttackList.Add(ThrowAKnife);
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack) //override
    {
        if (Distance < 10)
        {
            Console.WriteLine("can't pull an arrow this close of proxy!");
        }
        else
        {
            base.PerformAttack(Target, ChosenAttack);
        }
    }
        public void Dash()
        {
            Distance = 20;
        }

}