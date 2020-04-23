using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBill
{
  public partial class Form1 : Form
  {
    BillAnalysis billAnalysis = new BillAnalysis();
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      // Data validation.
      bool firstNumeric = Double.TryParse(txtFirstQuar.Text, out double firstQuart);
      bool secondNumeric = Double.TryParse(txtSecondQuart.Text, out double secondQuart);
      bool thirdNumeric = Double.TryParse(txtThirdQuart.Text, out double thirdQuart);
      bool fourthNumeric = Double.TryParse(txtFourthQuart.Text, out double fourthQuart);

      if(firstNumeric && secondNumeric && thirdNumeric && fourthNumeric)
      {
        Bill firstQuarterBill = new Bill("First Quarter", firstQuart);
        Bill secondQuarterBill = new Bill("Second Quarter", secondQuart);
        Bill thirdQuarterBill = new Bill("Third Quarter", thirdQuart);
        Bill fourthQuarterBill = new Bill("Fourth Quarter", fourthQuart);

        // Puts data into array and analyses it.
        Bill[] quarters = { firstQuarterBill, secondQuarterBill, thirdQuarterBill, fourthQuarterBill };
        txtTotal.Text = billAnalysis.calculateSum(quarters).ToString();
        txtAverage.Text = billAnalysis.calculateAverage(quarters).ToString();
      }
      else
      {
        MessageBox.Show("Please fill out all four fields using only numeric character.");
      }

    }
  }
}
