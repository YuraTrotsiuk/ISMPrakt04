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
    public partial class ForConsole3 : Form
    {
        public ForConsole3()
        {
            InitializeComponent();
        }

        private void textBoxN3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRes3_Click(object sender, EventArgs e)
        {
            double a;
            int n;
            bool isOk1 = double.TryParse(textBoxA3.Text, out a);
            bool isOk2 = int.TryParse(textBoxN3.Text, out n);
            if (isOk1 == false || isOk2 == false)
            { 
                MessageBox.Show("Некоректно введено значення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            { 
                double res = ClassLibraryISMPrakt04.Class1.ForConsole3(a,n);
                labelRes3.Text = $"{res}";
                label1.Visible = true;
                labelRes3.Visible = true;
            }
                
            
        }
    }
}
