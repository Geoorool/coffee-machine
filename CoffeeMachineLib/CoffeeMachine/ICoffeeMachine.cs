using System;
using CoffeeMachineLib.Drink;

namespace CoffeeMachineLib.CoffeeMachine
{
    public interface ICoffeeMachine
    {
        IDrink MakeDrink();
    }
}

