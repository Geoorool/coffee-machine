using System;
namespace CoffeeMachineLib.Storage
{
    public interface IStorage
    {
        int GetCoffee(int amount);
        int GetMilk(int amount);
        int GetSugar(int amount);
        void AddCoffee(int amount);
        void AddMilk(int amount);
        void AddSugar(int amount);
        void ClearBucket();
    }
}

