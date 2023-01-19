using CoffeeMachineLib.CoffeeMachine;
using CoffeeMachineLib.Drink;
using CoffeeMachineLib.Storage;

var coffeeMachine = new CoffeeMachine(new Storage(100, 31, 31));
for (int i = 0; i < 20; i++)
{
    var drink = coffeeMachine.MakeDrink();
    Console.WriteLine(drink);
}

Console.ReadKey();

