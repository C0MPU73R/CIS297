using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAndFiles
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void saveFileDialog1_FileOk( object sender, CancelEventArgs e )
		{

		}

		private void saveButton_Click( object sender, EventArgs e )
		{
			saveFileDialog1.ShowDialog();
		}
	}
}
