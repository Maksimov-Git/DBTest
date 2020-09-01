using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addressBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSOPPTESTDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tSOPPTESTDataSet.Address". При необходимости она может быть перемещена или удалена.
            this.addressTableAdapter.Fill(this.tSOPPTESTDataSet.Address);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tSOPPTESTDataSet.Address". При необходимости она может быть перемещена или удалена.
            this.addressTableAdapter.Fill(this.tSOPPTESTDataSet.Address);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tSOPPTESTDataSet.Address". При необходимости она может быть перемещена или удалена.
            this.addressTableAdapter.Fill(this.tSOPPTESTDataSet.Address);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tSOPPTESTDataSet.Address". При необходимости она может быть перемещена или удалена.
            this.addressTableAdapter.Fill(this.tSOPPTESTDataSet.Address);

        }

        private void addressBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSOPPTESTDataSet);

        }

        private void addressBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSOPPTESTDataSet);

        }

        private void addressBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.addressBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tSOPPTESTDataSet);

        }
    }
}
