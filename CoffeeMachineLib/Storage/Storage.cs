using System;
namespace CoffeeMachineLib.Storage
{
    public class Storage : IStorage
    {
        private int _coffee;
        private int _sugar;
        private int _milk;
        private int _bucket = 0;

        public Storage(int coffee, int milk, int sugar) {
            _coffee = coffee;
            _milk = milk;
            _sugar = sugar;
        }

        public void AddCoffee(int amount) {
            _coffee += amount;
        }

        public void AddMilk(int amount) {
            _milk += amount;
        }

        public void AddSugar(int amount) {
            _sugar += amount;
        }

        public void ClearBucket() {
            _bucket = 0;
        }

        public int GetCoffee(int amount) {
            if (_coffee > 0) {
                _bucket++;
                return GetProductHelper(ref _coffee, amount);
            }
            return 0;
        }

        public int GetMilk(int amount) {
            return GetProductHelper(ref _milk, amount);
        }

        public int GetSugar(int amount) {
            return GetProductHelper(ref _sugar, amount);
        }

        private int GetProductHelper(ref int product, int amount) {
            if (product > 0) {
                if (product - amount >= 0) {
                    product -= amount;
                    return amount;
                }
                var getCoffeResult = product;
                product = 0;
                return getCoffeResult;
            }
            return 0;
        }
    }
}

