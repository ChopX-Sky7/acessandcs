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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аэропортDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аэропортDataSet1.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.аэропортDataSet1.Сотрудники);

        }

        private void серия_паспортаLabel_Click(object sender, EventArgs e)
        {

        }

        private void код_должностиComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
