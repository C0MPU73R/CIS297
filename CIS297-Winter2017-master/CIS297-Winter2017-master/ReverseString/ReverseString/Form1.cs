using System;
using System.Text;
using System.Windows.Forms;

namespace ReverseString
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			Reverse( numberOfTimes: 2, toReverse: textBox1.Text );
		}

		private void Reverse( string toReverse, int numberOfTimes = 1 )
		{
			StringBuilder builder = new StringBuilder();

			for ( int index = 0; index < toReverse.Length; index++ )
			{
				builder.Append( toReverse.Substring( toReverse.Length - 1 - index, 1 ) );
			}

			label1.Text = builder.ToString();
		}
	}
}
