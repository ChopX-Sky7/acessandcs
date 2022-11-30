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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void самолетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.самолетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аэропортDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аэропортDataSet.Самолеты". При необходимости она может быть перемещена или удалена.
            this.самолетыTableAdapter.Fill(this.аэропортDataSet.Самолеты);

        }

        private void самолетыDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
