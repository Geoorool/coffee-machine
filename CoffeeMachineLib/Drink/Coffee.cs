using System;
namespace CoffeeMachineLib.Drink
{
    public class Coffee : IDrink
    {
        private int _sugar;
        private int _coffee;
        private int _milk;
        private string _name;

        public Coffee(int coffee, int milk, int sugar, string name) {
            _sugar = sugar;
            _milk = milk;
            _coffee = coffee;
            _name = name;
        }

        public override string ToString() {
            return $"Это {_name} в котором {_coffee} кофе, {_milk} молока, {_sugar} сахара";
        }

        public string GetInfo() {
            return this.ToString();
        }
    }
}

