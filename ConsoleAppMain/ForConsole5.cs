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
    public partial class ForConsole5 : Form
    {
        public ForConsole5()
        {
            InitializeComponent();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int n;
            bool isOk = int.TryParse(textBoxN.Text, out n);
            if (isOk == false)
            {
                MessageBox.Show("Некоректно введено значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int res = ClassLibraryISMPrakt04.Class1.ForConsole5(n);
                labelRes.Text = $"{res}";
                label2.Visible = true;
                labelRes.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
