public class Caster : Enemy
{
    public Caster() : base("Puneta", 80)
    {
        Attack Fireball = new Attack("fireball", 25);
        AttackList.Add(Fireball);
        Attack LighteningBolt = new Attack("Lightening bolt", 20);
        AttackList.Add(LighteningBolt);
        Attack StaffStrike = new Attack("Staff Strike", 25);
        AttackList.Add(StaffStrike);
    }

    public void Heal(Enemy Target, int amount)
    {
        Target.Health += amount;
        Console.WriteLine($"{Name} heals {Target.Name} for {amount} HP!");
    }
}