using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;

// Singleton
public class Singleton {
  private static object lockObj = new object();
  // Lazy initialization
  private volatile static Singleton instance = null;
  public int number1;
  public int number2;
  public int number3;

  private Singleton() {
    number1 = 42;
    number2 = 0;
    number3 = -1;
  }
  
  public static Singleton GetInstance() {
    if (instance == null) { // efficiency
      lock (lockObj) {
        if (instance == null) { // accuracy
          instance = new();
        }
      }
    }
    return instance;
    // t3
    // t2
    // t1
  }
}

public class Static {
  public static int number1 = 42;
  public static int number2 = 42;
  public static int number3 = 42;

}
