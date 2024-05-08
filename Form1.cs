namespace WinFormsApp2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = "    ";
			textBox2.Text = "    ";
			textBox3.Text = "    ";
			label5.Text = "    ";
			label11.Text = "    ";
			label12.Text = "    ";
			label10.Text = "    ";
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			if(textBox1.Text!="" && textBox2.Text!="" && textBox3.Text!="")
			{
				textBox1.Focus();
				textBox2.Focus();
				textBox3.Focus();
				int class_A = int.Parse(textBox1.Text) * 150;
				int class_B = int.Parse(textBox2.Text) * 100;
				int class_c = int.Parse(textBox3.Text) * 50;
				int sum = class_A + class_B + class_c;
				label5.Text = class_A.ToString();
				label11.Text = class_B.ToString();
				label12.Text = class_c.ToString();
				label10.Text = sum.ToString();
			}
			else
			{
				MessageBox.Show("please fill the boxes!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
		}
	}
}
