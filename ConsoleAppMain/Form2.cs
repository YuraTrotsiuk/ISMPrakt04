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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void labelB_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a,b;
            bool isOk1 = int.TryParse(textBoxA.Text, out a);
            bool isOk2 = int.TryParse(textBoxB.Text, out b);
            if (isOk1 == false || isOk2 == false)
            {
                MessageBox.Show("Некоректно введено значення", "Помилка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                int resultat = ClassLibraryISMPrakt04.Class1.ForConsole1(a, b);
                labelResult.Text = $"{resultat}";
                labelDob.Visible = true;
                labelResult.Visible = true;
            }

        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }

        private void labelDob_Click(object sender, EventArgs e)
        {

        }
    }
}
