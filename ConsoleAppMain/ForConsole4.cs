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
    public partial class ForConsole4 : Form
    {
        public ForConsole4()
        {
            InitializeComponent();
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            int a, b;
            bool isOk1 = int.TryParse(textBoxA.Text, out a);
            bool isOk2 = int.TryParse(textBoxB.Text, out b);
            if (isOk1 == false || isOk2 == false)
                MessageBox.Show("Некоректно введено значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int res = ClassLibraryISMPrakt04.Class1.ForConsole4(a, b);
                labelRes.Text = $"{res}";
                label1.Visible = true;
                labelRes.Visible = true;
            }
        }
    }
}
