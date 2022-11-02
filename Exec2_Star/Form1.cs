using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string input= inputTextBox.Text;
			int numbers=int.Parse(input);
			string result = string.Empty;
			for (int i = 1; i <= numbers; i++)
			{
				result += new string('*', i) + "\r\n";
				textBox1.Text=result;
			}

			//MessageBox.Show(input);

		}

		private void leftTriangleButton_Click(object sender, EventArgs e)
		{
			string input = inputTextBox.Text;
			int numbers = int.Parse(input);
			string result = string.Empty;
			for (int i = 1; i <= numbers; i++)
			{
				int space=numbers-i;
				int star=i;
				result += new string(' ', space) + new string('*', star) + "\r\n";
				textBox1.Text = result;
			}
		}

		private void isoscelesTriangleButton_Click(object sender, EventArgs e)
		{
			string input = inputTextBox.Text;
			int numbers = int.Parse(input);
			string result = string.Empty;
			for (int i = 1; i <= numbers; i++)
			{
				int space = numbers - i;
				int star = i*2-1;
				result += new string(' ', space) + new string('*', star) + "\r\n";
				textBox1.Text = result;
			}
		}
	}
}
