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
        // this is all very self explanitory I'm not sure what you want me to say here.
        double[] quarters = { firstQuart, secondQuart, thirdQuart, fourthQuart };
        txtTotal.Text = quarters.Sum().ToString();
        txtAverage.Text = quarters.Average().ToString();
      }
      else
      {
        MessageBox.Show("Please fill out all four fields using only numeric character.");
      }

    }
  }
}
