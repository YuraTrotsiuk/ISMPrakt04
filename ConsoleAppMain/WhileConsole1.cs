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
    public partial class WhileConsole1 : Form
    {
        public WhileConsole1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            bool isOk = int.TryParse(textBoxN.Text, out n);
            if (isOk == false)
            {
                MessageBox.Show("Некоректно введено значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double res = ClassLibraryISMPrakt04.Class1.WhileConsole1(n);
                labelRes.Text = $"{res}";
                label2.Visible = true;
                labelRes.Visible = true;
            }
        }
    }
}
