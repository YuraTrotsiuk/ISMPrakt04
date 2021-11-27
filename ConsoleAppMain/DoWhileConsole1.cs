using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleAppMain
{
    public partial class DoWhileConsole1 : Form
    {
        public DoWhileConsole1()
        {
            InitializeComponent();
        }
        int sum;
        private void buttonRea_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text);
            sum = sum + n;
            textBoxN.Text = "";


            if (n == 0)
            {
                labelRes.Text = $"{sum}";
                labelRes.Visible = true;
            }
        }

        private void labelRes_Click(object sender, EventArgs e)
        {

        }
    }
}
