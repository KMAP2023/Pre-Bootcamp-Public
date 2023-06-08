public class Fighter : Enemy
{



    public Fighter() : base("Peach", 120)
    {
        Attack Punch = new Attack("Punch", 20);
        AttackList.Add(Punch);
        Attack Kick = new Attack("Kick", 15);
        AttackList.Add(Kick);
        Attack Tackle = new Attack("Tackle", 25);
        AttackList.Add(Tackle);
    }

    public void Rage(Enemy Target)
    {
        Attack RandRage = RandomAttack();
        // Target.Health = Target.Health - (RandRage.DamageAmount + 10); //this will print out damage but it will not properly assess the damage
        RandRage.DamageAmount += 10;

        PerformAttack(Target, RandRage);
    }

}



