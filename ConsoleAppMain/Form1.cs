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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ForConsole1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void ForConsole2_Click(object sender, EventArgs e)
        {
            ForConsole2 form = new ForConsole2();
            form.ShowDialog();
        }

        private void ForConsole3_Click(object sender, EventArgs e)
        {
            ForConsole3 form = new ForConsole3();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ForConsole4 form = new ForConsole4();
            form.ShowDialog();
        }

        private void ForConsole5_Click(object sender, EventArgs e)
        {
            ForConsole5 form = new ForConsole5();
            form.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            WhileConsole1 form = new WhileConsole1();
            form.ShowDialog();
        }

        private void WhileConsole2_Click(object sender, EventArgs e)
        {
            WhileConsole2 form = new WhileConsole2();
            form.ShowDialog();
        }

        private void WhileConsole3_Click(object sender, EventArgs e)
        {
            WhileConsole3 form = new WhileConsole3();
            form.ShowDialog();
        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DoWhileConsole1_Click(object sender, EventArgs e)
        {
            DoWhileConsole1 form = new DoWhileConsole1();
            form.ShowDialog();
        }
    }
}
