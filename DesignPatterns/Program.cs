namespace DesignPatterns;

internal class Program {
  static void Main(string[] args) {
    Window win = new();

    win.Resize += Sub1;
    win.Resize += Sub2;
    win.Resize -= Sub2;
    win.Resize += (int w, int h) => Console.WriteLine("lambda got the event");

    win.OnResize(1024, 768);
  }

  public static void Sub1(int w, int h) {
    Console.WriteLine($"Sub 1 got the event: {w}x{h}");
  }
  public static void Sub2(int w, int h) {
    Console.WriteLine($"Sub 2 got the event: {w}x{h}");
  }
}
