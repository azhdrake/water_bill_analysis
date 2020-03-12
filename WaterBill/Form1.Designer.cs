namespace WaterBill
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtFirstQuar = new System.Windows.Forms.TextBox();
      this.txtSecondQuart = new System.Windows.Forms.TextBox();
      this.txtThirdQuart = new System.Windows.Forms.TextBox();
      this.txtFourthQuart = new System.Windows.Forms.TextBox();
      this.txtAverage = new System.Windows.Forms.TextBox();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.btnCalc = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtFirstQuar
      // 
      this.txtFirstQuar.Location = new System.Drawing.Point(145, 54);
      this.txtFirstQuar.Name = "txtFirstQuar";
      this.txtFirstQuar.Size = new System.Drawing.Size(123, 31);
      this.txtFirstQuar.TabIndex = 0;
      // 
      // txtSecondQuart
      // 
      this.txtSecondQuart.Location = new System.Drawing.Point(145, 110);
      this.txtSecondQuart.Name = "txtSecondQuart";
      this.txtSecondQuart.Size = new System.Drawing.Size(123, 31);
      this.txtSecondQuart.TabIndex = 1;
      // 
      // txtThirdQuart
      // 
      this.txtThirdQuart.Location = new System.Drawing.Point(145, 169);
      this.txtThirdQuart.Name = "txtThirdQuart";
      this.txtThirdQuart.Size = new System.Drawing.Size(123, 31);
      this.txtThirdQuart.TabIndex = 2;
      // 
      // txtFourthQuart
      // 
      this.txtFourthQuart.Location = new System.Drawing.Point(145, 228);
      this.txtFourthQuart.Name = "txtFourthQuart";
      this.txtFourthQuart.Size = new System.Drawing.Size(123, 31);
      this.txtFourthQuart.TabIndex = 3;
      // 
      // txtAverage
      // 
      this.txtAverage.Location = new System.Drawing.Point(484, 234);
      this.txtAverage.Name = "txtAverage";
      this.txtAverage.ReadOnly = true;
      this.txtAverage.Size = new System.Drawing.Size(123, 31);
      this.txtAverage.TabIndex = 4;
      this.txtAverage.TabStop = false;
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(484, 172);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(123, 31);
      this.txtTotal.TabIndex = 5;
      this.txtTotal.TabStop = false;
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(149, 298);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(118, 43);
      this.btnCalc.TabIndex = 4;
      this.btnCalc.Text = "Calculate";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(134, 40);
      this.label1.TabIndex = 6;
      this.label1.Text = "Quarter";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(86, 40);
      this.label2.TabIndex = 7;
      this.label2.Text = "First";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(26, 116);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(136, 40);
      this.label3.TabIndex = 8;
      this.label3.Text = "Second";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(26, 175);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(98, 40);
      this.label4.TabIndex = 9;
      this.label4.Text = "Third";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(26, 234);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(118, 40);
      this.label5.TabIndex = 10;
      this.label5.Text = "Fourth";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(341, 178);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(96, 40);
      this.label6.TabIndex = 11;
      this.label6.Text = "Total";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(341, 240);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(147, 40);
      this.label7.TabIndex = 12;
      this.label7.Text = "Average";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(619, 367);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCalc);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.txtAverage);
      this.Controls.Add(this.txtFourthQuart);
      this.Controls.Add(this.txtThirdQuart);
      this.Controls.Add(this.txtSecondQuart);
      this.Controls.Add(this.txtFirstQuar);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox txtFirstQuar;
        private System.Windows.Forms.TextBox txtSecondQuart;
        private System.Windows.Forms.TextBox txtThirdQuart;
        private System.Windows.Forms.TextBox txtFourthQuart;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

