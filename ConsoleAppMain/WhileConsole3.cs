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
    public partial class WhileConsole3 : Form
    {
        public WhileConsole3()
        {
            InitializeComponent();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int p;
            double res;
            bool isOk = int.TryParse(textBoxP.Text, out p);
            if (isOk == false)
            {
                MessageBox.Show("Некоректно введено значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                res = ClassLibraryISMPrakt04.Class1.WhileConsole3(p);
                labelS.Text = $"{res}";
                label1.Visible = true;
                labelS.Visible = true;
                res = ClassLibraryISMPrakt04.Class1.WhileConsole31(p);
                labelDay.Text = $"{res}";
                label3.Visible = true;
                labelDay.Visible = true;
            }
        }
    }
}
