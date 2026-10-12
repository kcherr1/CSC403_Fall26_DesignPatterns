using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;

public enum MultitonType {
  NAME1,
  NAME2,
  NAME3,
  NAME4
}

public class Multiton {
  private static Dictionary<MultitonType, Multiton> instances = null;

  public string Name { get; set; }

  private Multiton(string name) {
    Name = name;
  }

  public static Multiton GetInstance(MultitonType id) {
    if (!instances.ContainsKey(id)) {
      instances.Add(id, new(id.ToString()));
    }
    return instances[id];
  }
}
