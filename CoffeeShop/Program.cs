using CoffeeShop;

Latte latte = new Latte("SpiceLatte", 2.45);
Espresso plain = new Espresso("Corto", 1);
Americano usa = new Americano("Americano", 1.5);
List<Coffee> coffees = new List<Coffee> { latte, plain, usa };
CoffeeMachine coffeeMachine = new CoffeeMachine(1234567890, 5.0, coffees);
bool keepRunning = true;
while (keepRunning) {
    keepRunning = coffeeMachine.ShowMenu();
}
