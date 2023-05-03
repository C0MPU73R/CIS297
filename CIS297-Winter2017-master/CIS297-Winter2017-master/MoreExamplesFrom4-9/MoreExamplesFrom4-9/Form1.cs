using System;
using System.Windows.Forms;

namespace MoreExamplesFrom4_9
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			Shift();
		}

		private void Shift()
		{
			int valueToShiftBy = Convert.ToInt32( textBox2.Text );
			string startingText = textBox1.Text;
			char[] letters = startingText.ToCharArray();
			for ( int index = 0; index < letters.Length; index++ )
			{
				char letter = letters[ index ];
				int unicodeValue = (int)letter;
				unicodeValue += valueToShiftBy;
				letters[ index ] = (char)unicodeValue;
			}

			// this won't work - letter can't be changed
			//foreach ( char letter in letters )
			//{
			//	letter += valueToShiftBy;
			//}

			label1.Text = new string( letters );
		}
	}
}
