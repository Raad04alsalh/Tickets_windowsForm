namespace WinFormsApp2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			groupBox2 = new GroupBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			label10 = new Label();
			label4 = new Label();
			label5 = new Label();
			label11 = new Label();
			label12 = new Label();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(textBox3);
			groupBox1.Controls.Add(textBox2);
			groupBox1.Controls.Add(textBox1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(12, 41);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(305, 186);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Tickets Sold";
			// 
			// textBox3
			// 
			textBox3.BackColor = Color.DimGray;
			textBox3.BorderStyle = BorderStyle.FixedSingle;
			textBox3.Location = new Point(94, 153);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(125, 27);
			textBox3.TabIndex = 7;
			// 
			// textBox2
			// 
			textBox2.BackColor = Color.DimGray;
			textBox2.BorderStyle = BorderStyle.FixedSingle;
			textBox2.Location = new Point(94, 118);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.DimGray;
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Location = new Point(94, 81);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(30, 155);
			label3.Name = "label3";
			label3.Size = new Size(55, 20);
			label3.TabIndex = 2;
			label3.Text = "Class C";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(30, 120);
			label2.Name = "label2";
			label2.Size = new Size(55, 20);
			label2.TabIndex = 1;
			label2.Text = "Class B";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(32, 81);
			label1.Name = "label1";
			label1.Size = new Size(56, 20);
			label1.TabIndex = 0;
			label1.Text = "Class A";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label12);
			groupBox2.Controls.Add(label11);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label10);
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(label8);
			groupBox2.Controls.Add(label7);
			groupBox2.Controls.Add(label6);
			groupBox2.Location = new Point(389, 41);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(300, 209);
			groupBox2.TabIndex = 1;
			groupBox2.TabStop = false;
			groupBox2.Text = "Revenue Generated";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(192, 192, 0);
			button1.Location = new Point(152, 335);
			button1.Name = "button1";
			button1.Size = new Size(99, 50);
			button1.TabIndex = 2;
			button1.Text = "Caculate Revenue";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = SystemColors.ActiveCaption;
			button2.Location = new Point(317, 337);
			button2.Name = "button2";
			button2.Size = new Size(97, 48);
			button2.TabIndex = 3;
			button2.Text = "Clear";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.RosyBrown;
			button3.Location = new Point(482, 341);
			button3.Name = "button3";
			button3.Size = new Size(101, 39);
			button3.TabIndex = 4;
			button3.Text = "Exit";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(37, 40);
			label6.Name = "label6";
			label6.Size = new Size(56, 20);
			label6.TabIndex = 0;
			label6.Text = "Class A";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(37, 88);
			label7.Name = "label7";
			label7.Size = new Size(55, 20);
			label7.TabIndex = 1;
			label7.Text = "Class B";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(37, 137);
			label8.Name = "label8";
			label8.Size = new Size(55, 20);
			label8.TabIndex = 2;
			label8.Text = "Class C";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(60, 187);
			label9.Name = "label9";
			label9.Size = new Size(45, 20);
			label9.TabIndex = 6;
			label9.Text = "Total:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.BackColor = SystemColors.ControlDark;
			label10.Location = new Point(141, 186);
			label10.Name = "label10";
			label10.Size = new Size(75, 20);
			label10.TabIndex = 7;
			label10.Text = "___________";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(60, 33);
			label4.Name = "label4";
			label4.Size = new Size(229, 40);
			label4.TabIndex = 8;
			label4.Text = "* Enter the number of tickets sold\r\n for each class of seats.";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.BackColor = SystemColors.GradientActiveCaption;
			label5.BorderStyle = BorderStyle.FixedSingle;
			label5.Location = new Point(119, 38);
			label5.Name = "label5";
			label5.Size = new Size(87, 22);
			label5.TabIndex = 8;
			label5.Text = "                   ";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.BackColor = SystemColors.GradientActiveCaption;
			label11.BorderStyle = BorderStyle.FixedSingle;
			label11.Location = new Point(119, 88);
			label11.Name = "label11";
			label11.Size = new Size(79, 22);
			label11.TabIndex = 9;
			label11.Text = "                 ";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.BackColor = SystemColors.GradientActiveCaption;
			label12.BorderStyle = BorderStyle.FixedSingle;
			label12.Location = new Point(119, 135);
			label12.Name = "label12";
			label12.Size = new Size(75, 22);
			label12.TabIndex = 10;
			label12.Text = "                ";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Name = "Form1";
			Text = "Form1";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label3;
		private Label label2;
		private Label label1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Label label8;
		private Label label7;
		private Label label6;
		private Label label10;
		private Label label9;
		private Label label4;
		private Label label12;
		private Label label11;
		private Label label5;
	}
}
