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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void билетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аэропортDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аэропортDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.аэропортDataSet.Билеты);

        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.MoveFirst();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.MoveLast();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.MovePrevious();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.билетыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аэропортDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
