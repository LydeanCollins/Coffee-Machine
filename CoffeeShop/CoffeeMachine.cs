using static System.Net.Mime.MediaTypeNames;

namespace CoffeeShop {
    class CoffeeMachine {
        private long machineId;
        private double machineWeight;
        private List<Coffee> coffeeList;
        public CoffeeMachine(long id, double weight, List<Coffee> coffees) {
            this.machineId = id;
            this.machineWeight = weight;
            this.coffeeList = coffees;
        }
        public bool ShowMenu() {
            int menuChoice;
            Console.Clear();
            Console.WriteLine("Welcome to the coffee machine\n");
            Console.WriteLine("Coffee Menu");
            Console.WriteLine("===========\n");
            Console.WriteLine("Coffee Type     Initial Price");
            Console.WriteLine("-----------     -------------\n");
            for (int i=0; i < coffeeList.Count; i++) {
                Console.WriteLine($"{i+1}. {coffeeList[i].Name}\t{coffeeList[i].Price}");
            }
            do {
                Console.Write("\nEnter the number of the coffee you'd like to order (or 0 to exit): ");
                menuChoice = Convert.ToInt32(Console.ReadLine());
            } while (menuChoice < 0 || menuChoice > coffeeList.Count);
            if (menuChoice == 0) {
                return false;
            }
            else {
                Coffee selected = coffeeList[menuChoice - 1];
                Console.WriteLine($"\nYou've ordered {selected.Name}");
                selected.Brew();
                Console.Write("Press Any key to go to main menu... ");
                Console.ReadKey();
                return true;
            }
        }
    }
}
