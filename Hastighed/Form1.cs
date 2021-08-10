using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastighed
{
    public partial class Form1 : Form
    {
        bool IsKMS = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal number;

            if (IsKMS)
            {
                SpeedType.Text = "M/S";
                number = NumberInput.Value * 3.6M;
            }
            else
            {
                SpeedType.Text = "KM/T";
                number = NumberInput.Value / 3.6M;
            }
            SpeedNumber.Text = Convert.ToString(number);
        }

        private void TypeRadio1_CheckedChanged(object sender, EventArgs e)
        {
            IsKMS = true;
        }

        private void TypeRadio2_CheckedChanged(object sender, EventArgs e)
        {
            IsKMS = false;
        }
    }
}
