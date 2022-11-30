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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аэропортDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
            this.рейсыTableAdapter.Fill(this.аэропортDataSet.Рейсы);

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.MoveLast();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.MoveNext();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.рейсыBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.рейсыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аэропортDataSet);
        }

      
    }
}
