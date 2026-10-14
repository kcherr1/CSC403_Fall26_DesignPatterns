namespace DesignPatterns;

// Component
public abstract class Pizza {
  // operation
  public abstract string GetToppings();

  public void Show() {
    Console.WriteLine("Our pizza contains " + GetToppings());
  }
}

// ConcreteComponent
public class CheesePizza : Pizza {
  public override string GetToppings() {
    Console.WriteLine("Adding the cheese");
    return "cheese";
  }
}

// Decorator
public abstract class PizzaDecorator : Pizza {
  private Pizza pizzaBefore;

  public PizzaDecorator(Pizza pizza) {
    pizzaBefore = pizza;
  }

  public override string GetToppings() {
    return pizzaBefore.GetToppings();
  }
}

// ConcreteDecorator(s)
public class Pepperoni : PizzaDecorator {
  public Pepperoni(Pizza pizza) : base(pizza) { }

  public override string GetToppings() {
    Console.WriteLine("Adding the pepperoni");
    return base.GetToppings() + ", pepperoni";
  }
}

public class Peppers : PizzaDecorator {
  public Peppers(Pizza pizza) : base(pizza) { }

  public override string GetToppings() {
    Console.WriteLine("Adding the peppers");
    return base.GetToppings() + ", peppers";
  }
}

public class Pineapple : PizzaDecorator {
  public Pineapple(Pizza pizza) : base(pizza) { }

  public override string GetToppings() {
    Console.WriteLine("Adding the pineapple");
    return base.GetToppings() + ", pineapple";
  }
}

