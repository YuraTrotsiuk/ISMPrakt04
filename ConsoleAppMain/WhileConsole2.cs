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
    public partial class WhileConsole2 : Form
    {
        public WhileConsole2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,res;
            bool isOk = int.TryParse(textBoxN.Text, out n);
            if (isOk == false)
            {
                MessageBox.Show("Некоректно введено значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                res = ClassLibraryISMPrakt04.Class1.WhileConsole2(n);
                labelK.Text = $"{res}";
                label1.Visible = true;
                labelK.Visible = true;
            }

        }
    }
}
