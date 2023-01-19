using CoffeeMachineLib.Drink;
using CoffeeMachineLib.Storage;

namespace CoffeeMachineLib.CoffeeMachine;
public class CoffeeMachine : ICoffeeMachine
{
    private readonly IStorage _storage;

    public CoffeeMachine(IStorage storage) {
        _storage = storage;
    }

    public IDrink MakeDrink() {
        return new Coffee(_storage.GetCoffee(8), _storage.GetMilk(3), _storage.GetSugar(2), "Капучино");
    }
}

