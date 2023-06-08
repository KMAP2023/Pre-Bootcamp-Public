public class Enemy
{
    public string Name { get; set; }
    // int _Health { get; set; } // **private when setting it as private must have an underscore in front**
    public int Health { get; set; } //
    public List<Attack> AttackList = new List<Attack>();

    

    public Enemy(string name, int health = 100)
    {
        Name = name;
        // AttackList = attackList;
        Health = health;
    }

    public Attack RandomAttack()
    {
        Random rand = new Random();
        int entropy = rand.Next(0,AttackList.Count); // entropy into the square brackets
        Console.WriteLine($"{AttackList[entropy].Name}");
        return AttackList[entropy];
    }

    public void anotherAttack(Attack strategy)
    {
        AttackList.Add(strategy);
        Console.WriteLine($"a new attack type called {strategy.Name} has been added to the list.");
    } // not necessarily hardcoding an add method of a new attack

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        // logic here to reduce the Targets health by your Attack's DamageAmount
            Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }

    

}