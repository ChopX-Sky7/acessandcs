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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void билетыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.аэропортDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аэропортDataSet.Рейсы". При необходимости она может быть перемещена или удалена.
          //  this.билеты//TableAdapter.Fill(this.аэропортDataSet.Рейсы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "аэропортDataSet.Билеты". При необходимости она может быть перемещена или удалена.
            this.билетыTableAdapter.Fill(this.аэропортDataSet.Билеты);

        }

        private void label2_Click(object sender, EventArgs e)   
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn Col = default(System.Windows.Forms.DataGridViewColumn);

            switch (listBox1.SelectedIndex) {
                case 0:
                    Col = dataGridViewTextBoxColumn3; break;
                case 1:
                    Col = dataGridViewTextBoxColumn4; break;
                case 2:
                    Col = dataGridViewTextBoxColumn5; break;
                case 3:
                    Col = dataGridViewTextBoxColumn6; break;
                case 4:
                    Col = dataGridViewTextBoxColumn7; break;
                case 5:
                    Col = dataGridViewTextBoxColumn7; break;
            }
            if (radioButton1.Checked)
            {
                билетыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending);
            }
            else {
                билетыDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending);
                 }
            }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void filtr_Click(object sender, EventArgs e)
        {
            билетыBindingSource.Filter = "Место=" + comboBox1.Text + "";
        }

        private void showall_Click(object sender, EventArgs e)
        {
            билетыBindingSource.Filter = "";
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            int i = 0;
            int j = 0;

            for (i = 0; i < билетыDataGridView.ColumnCount - 1; i++)
            {
                for (j = 0; j < билетыDataGridView.RowCount - 1; j++)
                {
                    билетыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.White;
                    билетыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Black;
                }
            }
            for (i = 0; i < билетыDataGridView.ColumnCount; i++)
            {
                for (j = 0; j < билетыDataGridView.RowCount; j++)
                {
                    var value = билетыDataGridView.Rows[j].Cells[i].Value;
                    if (value != null)
                    {
                        string baseStr = value.ToString();

                        if (baseStr.IndexOf(crit.Text) > -1)
                        {
                            билетыDataGridView.Rows[j].Cells[i].Style.BackColor = Color.Aqua;
                            билетыDataGridView.Rows[j].Cells[i].Style.ForeColor = Color.Blue;
                        }
                    }
                }
            }
        }
    }
}
