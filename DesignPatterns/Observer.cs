using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns;

public class Window {
  public event Action<int, int> Resize {
		add {
			Console.WriteLine("you subscribed" + value.ToString());
		}
		remove {
      Console.WriteLine("you unsubscribed" + value.ToString());
    }
  }

	public Window() {

	}

	public void OnResize(int w, int h) {
    //Resize(w, h);
	}
}
