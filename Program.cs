using HeadFirstStrategyPatternSample.Ducks;
using HeadFirstStrategyPatternSample.Ducks.Implements;
using HeadFirstStrategyPatternSample.FightCharacters;
using HeadFirstStrategyPatternSample.FightCharacters.Implements;

Console.WriteLine("Hello, Strategy Pattern :D");
Console.WriteLine();
Console.WriteLine();



Console.WriteLine("Let's See Ducks => \n");

new MarraldDuck().Display();

new SpottedWhistlingDuck().Display();

new RubberDuck().Display();

var woodenDuck = new WoodenDuck();
woodenDuck.Display();
woodenDuck.SetFlyBehavior(new NowCanFly()); // runtime changeability
woodenDuck.SetSwimBehavior(new NowCanSwim()); // runtime changeability
woodenDuck.Display();



Console.WriteLine();
Console.WriteLine();
Console.WriteLine();



Console.WriteLine("Let's See Fights => \n");

new King().Fight();

new Queen().Fight();

new Knight().Fight();

new Bowman().Fight();

var shark = new Shark();
shark.Fight();

var swordWeapon = new SwordWeapon();
shark.SetWeaponBehavior(swordWeapon);
Console.WriteLine($"But We change the shark weapon to {swordWeapon.Weapon()}");
shark.Fight("And now ");
