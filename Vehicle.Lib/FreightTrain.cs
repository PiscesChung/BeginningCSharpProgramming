using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Lib {
  class FreightTrain : Train, IHeavyLoadCarrier {
    public string HeavyLoadCarry(int num) => $"FreightTrain is carrying {num}ton goods...";
  }
}
