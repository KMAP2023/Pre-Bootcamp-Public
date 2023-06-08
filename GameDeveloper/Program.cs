// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Attack dropkick = new Attack("dropkick", 50);
Attack elbow = new Attack("elbow", 25);
Attack slash = new Attack("slash", 90);
Attack icicleStorm = new Attack("icicleStorm", 50);


List<Attack> myAttackList = new List<Attack>()
{
    dropkick,
    elbow,
    slash,
    icicleStorm
};

Enemy Malo = new Enemy("Malo", 150);

Malo.AttackList = myAttackList;
Malo.RandomAttack();

Enemy Thien = new Enemy("Thien", 150);
Thien.AttackList = myAttackList;
Thien.RandomAttack();

Attack stab = new Attack("stab", 25);
// this is a method
Thien.anotherAttack(stab); // invoking the method and adding stab into the attack list

Fighter BettyBoop = new Fighter();
BettyBoop.Rage(Thien);

Ranger Robin = new Ranger();
Console.WriteLine(Robin.Distance);

Caster Merlin = new Caster();
Merlin.Heal(BettyBoop, 40);
Merlin.Heal(Merlin, 40);