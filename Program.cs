﻿using HeadFirstStrategyPatternSample.Ducks;
using HeadFirstStrategyPatternSample.Ducks.Implements;

Console.WriteLine("Hello, Strategy Pattern :D");
Console.WriteLine();
Console.WriteLine();


// ducks :D
new MarraldDuck().Display();

new SpottedWhistlingDuck().Display();

new RubberDuck().Display();

var woodenDuck = new WoodenDuck();
woodenDuck.Display();
woodenDuck.SetFlyable(new NowCanFly()); // runtime changeability
woodenDuck.SetSwimable(new NowCanSwim()); // runtime changeability
woodenDuck.Display();
// /ducks
