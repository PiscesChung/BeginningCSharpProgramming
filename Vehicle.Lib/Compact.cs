using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Lib {
  class Compact : Car, IPassengerCarrier {
    public string PassengerCarry(int num) => $"Compact is carrying {num} people...";
  }
}
