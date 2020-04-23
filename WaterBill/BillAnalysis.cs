using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBill
{
  class BillAnalysis
  {
    public double calculateAverage(Bill[] bills)
    { // gets all the bill values into an array and caculates the average.
      double[] billValues = new double[bills.Length];
      for (int i = 0; i < bills.Length; i++)
      {
        billValues[i] = bills[i].BillValue;
      }
      return billValues.Average();
    }
    public double calculateSum(Bill[] bills)
    { // gets all the bill values into an array and caculates the total sum.
      double[] billValues = new double[bills.Length];
      for (int i = 0; i < bills.Length; i++)
      {
        billValues[i] = bills[i].BillValue;
      }
      
      return billValues.Sum();
    }
  }
}
