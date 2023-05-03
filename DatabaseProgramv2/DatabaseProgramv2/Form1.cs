using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProgramv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





       

        private void month_Enter_Button_Click(object sender, EventArgs e)
        {
            //get the selected month's index after hitting enter
            int index = monthComboBox.SelectedIndex;

        }

        private void transactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void transactionsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    }
}
