namespace DesignPatterns {
  internal class Program {
    static void Main(string[] args) {
      Singleton s = Singleton.GetInstance();
      Singleton s2 = Singleton.GetInstance();
      Console.WriteLine(s == s2);
    }
  }
}
