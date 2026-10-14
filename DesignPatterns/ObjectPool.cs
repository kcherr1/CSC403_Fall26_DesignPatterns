namespace DesignPatterns;

// Resource
public class Marker {
  public ConsoleColor Color { private get; set; }

  public Marker() {
    Color = ConsoleColor.White;
  }

  public void Draw(string msg) {
    Console.ForegroundColor = Color;
    Console.WriteLine(msg);
    Console.ForegroundColor = ConsoleColor.White;
  }
}

public class ObjectPool<T> where T : class, new()  {
  private readonly Queue<T> pool;

  public ObjectPool(int size) {
    pool = new(size);
    for (int i = 0; i < size; i++) {
      pool.Enqueue(new());
    }
  }

  public T Acquire() {
    if (pool.Count > 0) {
      return pool.Dequeue();
    }
    else {
      return null;
    }
  }

  public void Release(T m) {
    pool.Enqueue(m);
  }
}
