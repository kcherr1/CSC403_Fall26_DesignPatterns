namespace DesignPatterns;

internal class Program {
  static void Main(string[] args) {
    Pizza pizza = new CheesePizza();
    pizza = new Peppers(pizza);
    pizza = new Pineapple(pizza);

    pizza.Show();
  }
}
