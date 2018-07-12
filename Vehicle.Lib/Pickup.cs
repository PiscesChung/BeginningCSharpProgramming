using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Lib {
  class Pickup : Car, IHeavyLoadCarrier {
    public string HeavyLoadCarry(int num) => $"Pickup is Carrying {num}ton goods...";
  }
}
