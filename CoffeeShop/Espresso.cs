namespace CoffeeShop {
    class Espresso : Coffee {
        private static string[] beanTypes = { 
            "Arabica     ", 
            "Robusta     ", 
            "Liberica    " };
        private static int[] extraPay = { 1, 0, 0 };
        private double extraCost;

        public Espresso(string name, double price) : base(name, price) {
        }
        public override double Price {
            get { return base.Price + extraCost; }
        }
        public override void Brew() {
            int menuChoice;
            Console.WriteLine("Bean Types");
            Console.WriteLine("----------\n");
            for (int i = 0; i < beanTypes.Length; i++) {
                Console.Write($"{i + 1}. {beanTypes[i]}");
                if (extraPay[i] > 0)
                    Console.WriteLine($"+Eur{extraPay[i]}");
                else
                    Console.WriteLine();
            }
            do {
                Console.Write("Choose type of bean for your coffee: ");
                menuChoice = Convert.ToInt32(Console.ReadLine());
            } while (menuChoice < 1 || menuChoice > extraPay.Length);
            this.extraCost = extraPay[menuChoice - 1];
            base.Brew();
        }
    }
}
