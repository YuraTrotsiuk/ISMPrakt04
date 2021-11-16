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
    public partial class ForConsole2 : Form
    {
        public ForConsole2()
        {
            InitializeComponent();
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRes2_Click(object sender, EventArgs e)
        {
            int n;
            bool isOk = int.TryParse(textBoxN2.Text, out n);
            if (isOk == false)
            { 
                MessageBox.Show("Некоректно введені значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else
            {
                double res = ClassLibraryISMPrakt04.Class1.ForConsole2(n);
                labelRes2.Text = $"{res}";
                labelSum2.Visible = true;
                labelRes2.Visible = true;
            }
        }
    }
}
