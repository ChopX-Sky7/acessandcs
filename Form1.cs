using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmPeople = new Form3();
            frmPeople.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frmPlanes = new Form2();
            frmPlanes.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frmFlights = new Form4();
            frmFlights.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frmTicket = new Form5();
            frmTicket.Show();
        }
    }
}
