namespace CoffeeShop {
    class Coffee {
        private string name;
        private double price;
        public Coffee(string name, double price) {
            this.name = name;
            Price = price;
        }
        public string Name { 
            get { return name; } 
        }
        public virtual double Price {
            get { return price; }
            set { 
                if (value > 0)
                    price = value; 
            }
        }
        public virtual void Brew() {
            if (HandlePayment()) {
                Console.WriteLine("Brewing coffee..."); Thread.Sleep(500);
                Console.WriteLine($"Preparing {Name}..."); Thread.Sleep(500);
                Console.WriteLine("You can pick up your coffee");
            }
            else {
                Console.WriteLine("Insufficient funds for the chosen coffee");
            }
        }
        public bool HandlePayment() {
            Console.WriteLine($"Please pay Eur{Price} for the selected coffee:");
            double money = Convert.ToDouble(Console.ReadLine());
            if (money == Price) {
                Console.WriteLine("Thank you");
                return true;
            }
            else if (money > Price) {
                Console.WriteLine($"Kindly pick up the Eur{Math.Round(money - Price, 2)} change.");
                return true;
            }
            else { 
                return false;
            }
        }
    }
}
