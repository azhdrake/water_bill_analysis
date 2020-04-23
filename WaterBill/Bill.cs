using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
  class Bill
  {
    public string PeriodName { get; set; }
    public double BillValue { get; set; }

    // This is surely much more practical then just using normal doubles.
    public Bill(string periodName, double billValue)
    {
      PeriodName = periodName;
      BillValue = billValue;
    }
  }
}
