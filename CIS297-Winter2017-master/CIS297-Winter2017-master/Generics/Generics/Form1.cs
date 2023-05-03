using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics
{
	public partial class Form1 : Form
	{
		private Barn<Animal> barn;
		private Barn<Plant> silo;
		public Form1()
		{
			InitializeComponent();
			barn = new Barn<Animal>();
			silo = new Barn<Plant>();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			displayItemsLabel.Text = barn.GetContentsOfBarn();
			displayItemsLabel.Text += silo.GetContentsOfBarn();
		}

		private void button2_Click( object sender, EventArgs e )
		{
			barn.add( new Animal()
			{
				Name = nameTextBox.Text,
				Type = typeTextBox.Text
			});

			nameTextBox.Text = string.Empty;
			typeTextBox.Text = string.Empty;
		}

		private void addPlantButton_Click( object sender, EventArgs e )
		{
			silo.add( new Plant()
			{
				Name = plantNameTextBox.Text,
				IsEdible = edibleCheckBox.Checked
			});

			plantNameTextBox.Text = string.Empty;
			edibleCheckBox.Checked = false;
		}
	}
}
