using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;

// Singleton
public class Singleton {
  // Lazy initialization
  private static Singleton instance = null;
  public int number1;
  public int number2;
  public int number3;

  private Singleton() {
    number1 = 42;
    number2 = 0;
    number3 = -1;
  }
  
  public static Singleton GetInstance() {
    if (instance == null) {
      instance = new();
    }
    return instance;
  }
}

public class Static {
  public static int number1 = 42;
  public static int number2 = 42;
  public static int number3 = 42;

}
