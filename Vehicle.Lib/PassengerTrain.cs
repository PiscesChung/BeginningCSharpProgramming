using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle.Lib {
  class PassengerTrain : Train, IPassengerCarrier {
    public string PassengerCarry(int num) => $"PassengerTrain is carrying {num} people...";
  }
}
