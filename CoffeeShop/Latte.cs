using System.Diagnostics;

namespace CoffeeShop {
    class Latte : Coffee {
        private static string[] milkTypes = { 
            "Cow's milk        ", 
            "Soya milk         ", 
            "Almond milk       ", 
            "Lactose free milk "};

        private static int[] extraPay = { 0, 1, 1, 1 };

        private double extraCost;

        public Latte(string name, double price) : base(name, price) {
        }

        public override double Price {
            get { return base.Price + extraCost; }
        }

        public override void Brew() {
            int menuChoice;
            Console.WriteLine("Milk Types");
            Console.WriteLine("----------\n");
            for (int i = 0; i < milkTypes.Length; i++) {
                Console.Write($"{i + 1}. {milkTypes[i]}");
                if (extraPay[i] > 0)
                    Console.WriteLine($"+Eur{extraPay[i]}");
                else
                    Console.WriteLine();
            }
            do {
                Console.Write("Choose type of milk for your coffee: ");
                menuChoice = Convert.ToInt32(Console.ReadLine());
            } while (menuChoice < 1 || menuChoice > extraPay.Length);
            this.extraCost = extraPay[menuChoice - 1];
            base.Brew();
        }
    }
}
