using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Sem_2
{

	enum Operand
	{
		PLUS,
		MINUS,
		MULTIPLY,
		DIVIDE,
		RESULT
	}

	public partial class Form1 : Form
	{

		double FirstNum;
		Operand Operation;

		private Button num_7;
		private TextBox textBox1;
		private Button plus;
		private Button num_9;
		private Button num_8;
		private Button num_5;
		private Button num_6;
		private Button num_4;
		private Button num_2;
		private Button num_3;
		private Button result;
		private Button num_1;
		private Button dot;
		private Button num_0;
		private Button divide;
		private Button multiply;
		private Button minus;
		private Button c_ce;
		private TextBox History;

		public Form1()
		{

			textBox1 = new TextBox();
			num_7 = new Button();
			num_5 = new Button();
			num_6 = new Button();
			num_4 = new Button();
			num_2 = new Button();
			num_3 = new Button();
			result = new Button();
			num_1 = new Button();
			divide = new Button();
			dot = new Button();
			plus = new Button();
			num_9 = new Button();
			num_8 = new Button();
			num_0 = new Button();
			multiply = new Button();
			minus = new Button();
			c_ce = new Button();
			History = new TextBox();

			// 
			// textBox1
			// 
			textBox1.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			textBox1.Location = new Point(22, 12);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(260, 41);
			textBox1.TabStop = false;
			textBox1.TextAlign = HorizontalAlignment.Right;
			// 
			// num_7
			// 
			num_7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_7.Location = new Point(22, 146);
			num_7.Name = "num_7";
			num_7.Size = new Size(60, 60);
			num_7.Text = "7";
			num_7.UseVisualStyleBackColor = true;
			num_7.Click += new System.EventHandler(Button_Click);
			// 
			// num_5
			// 
			num_5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_5.Location = new Point(89, 212);
			num_5.Name = "num_5";
			num_5.Size = new Size(60, 60);
			num_5.Text = "5";
			num_5.UseVisualStyleBackColor = true;
			num_5.Click += new System.EventHandler(Button_Click);
			// 
			// num_6
			// 
			num_6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_6.Location = new Point(156, 212);
			num_6.Name = "num_6";
			num_6.Size = new Size(60, 60);
			num_6.Text = "6";
			num_6.UseVisualStyleBackColor = true;
			num_6.Click += new System.EventHandler(Button_Click);
			// 
			// num_4
			// 
			num_4.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_4.Location = new Point(22, 212);
			num_4.Name = "num_4";
			num_4.Size = new Size(60, 60);
			num_4.Text = "4";
			num_4.UseVisualStyleBackColor = true;
			num_4.Click += new System.EventHandler(Button_Click);
			// 
			// num_2
			// 
			num_2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_2.Location = new Point(89, 278);
			num_2.Name = "num_2";
			num_2.Size = new Size(60, 60);
			num_2.Text = "2";
			num_2.UseVisualStyleBackColor = true;
			num_2.Click += new System.EventHandler(Button_Click);
			// 
			// num_3
			// 
			num_3.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_3.Location = new Point(156, 278);
			num_3.Name = "num_3";
			num_3.Size = new Size(60, 60);
			num_3.Text = "3";
			num_3.UseVisualStyleBackColor = true;
			num_3.Click += new System.EventHandler(Button_Click);
			// 
			// result
			// 
			result.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			result.Location = new Point(222, 278);
			result.Name = "result";
			result.Size = new Size(60, 126);
			result.Text = "=";
			result.UseVisualStyleBackColor = true;
			result.Click += new System.EventHandler(Button_Click);
			// 
			// num_1
			// 
			num_1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_1.Location = new Point(22, 278);
			num_1.Name = "num_1";
			num_1.Size = new Size(60, 60);
			num_1.Text = "1";
			num_1.UseVisualStyleBackColor = true;
			num_1.Click += new System.EventHandler(Button_Click);
			// 
			// divide
			// 
			divide.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			divide.Location = new Point(89, 80);
			divide.Name = "divide";
			divide.Size = new Size(60, 60);
			divide.Text = "/";
			divide.UseVisualStyleBackColor = true;
			divide.Click += new System.EventHandler(Button_Click);
			// 
			// dot
			// 
			dot.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			dot.Location = new Point(156, 344);
			dot.Name = "dot";
			dot.Size = new Size(60, 60);
			dot.Text = ",";
			dot.UseVisualStyleBackColor = true;
			dot.Click += new System.EventHandler(Button_Click);
			// 
			// plus
			// 
			plus.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			plus.Location = new Point(222, 146);
			plus.Name = "plus";
			plus.Size = new Size(60, 126);
			plus.Text = "+";
			plus.UseVisualStyleBackColor = true;
			plus.Click += new System.EventHandler(Button_Click);
			// 
			// num_9
			// 
			num_9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_9.Location = new Point(156, 146);
			num_9.Name = "num_9";
			num_9.Size = new Size(60, 60);
			num_9.Text = "9";
			num_9.UseVisualStyleBackColor = true;
			num_9.Click += new System.EventHandler(Button_Click);
			// 
			// num_8
			// 
			num_8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_8.Location = new Point(89, 146);
			num_8.Name = "num_8";
			num_8.Size = new Size(60, 60);
			num_8.Text = "8";
			num_8.UseVisualStyleBackColor = true;
			num_8.Click += new System.EventHandler(Button_Click);
			// 
			// num_0
			// 
			num_0.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			num_0.Location = new Point(22, 344);
			num_0.Name = "num_0";
			num_0.Size = new Size(127, 60);
			num_0.Text = "0";
			num_0.UseVisualStyleBackColor = true;
			num_0.Click += new System.EventHandler(Button_Click);
			// 
			// multiply
			// 
			multiply.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			multiply.Location = new Point(156, 80);
			multiply.Name = "multiply";
			multiply.Size = new Size(60, 60);
			multiply.Text = "*";
			multiply.UseVisualStyleBackColor = true;
			multiply.Click += new System.EventHandler(Button_Click);
			// 
			// minus
			// 
			minus.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			minus.Location = new Point(222, 80);
			minus.Name = "minus";
			minus.Size = new Size(60, 60);
			minus.Text = "-";
			minus.UseVisualStyleBackColor = true;
			minus.Click += new System.EventHandler(Button_Click);
			// 
			// c_ce
			// 
			c_ce.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			c_ce.Location = new Point(22, 80);
			c_ce.Name = "c_ce";
			c_ce.Size = new Size(60, 60);
			c_ce.Text = "C / CE";
			c_ce.UseVisualStyleBackColor = true;
			c_ce.Click += new System.EventHandler(Button_Click);
			// 
			// History
			// 
			History.BackColor = SystemColors.InactiveCaption;
			History.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204)));
			History.Location = new Point(22, 426);
			History.Name = "History";
			History.ScrollBars = ScrollBars.Horizontal;
			History.Size = new Size(260, 41);
			History.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(6F, 13F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(308, 480);
			Controls.Add(History);
			Controls.Add(divide);
			Controls.Add(multiply);
			Controls.Add(minus);
			Controls.Add(c_ce);
			Controls.Add(dot);
			Controls.Add(num_0);
			Controls.Add(num_2);
			Controls.Add(num_3);
			Controls.Add(result);
			Controls.Add(num_1);
			Controls.Add(num_5);
			Controls.Add(num_6);
			Controls.Add(num_4);
			Controls.Add(num_8);
			Controls.Add(num_9);
			Controls.Add(plus);
			Controls.Add(textBox1);
			Controls.Add(num_7);
			Name = "Form1";
			Text = "Form1";
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Button tmp = sender as Button;
			switch(tmp.Name)
			{
				case "c_ce":
				{
					textBox1.Clear();
					History.Clear();
					break;
				}
				case "dot":
				{
					if(!textBox1.Text.Contains(','))
					{
						textBox1.Text += ',';
						History.Text += ',';
					}
					break;
				}
				case "plus":
				{
					if(textBox1.Text != "")
					{
						History.Text += tmp.Text;

						FirstNum = Convert.ToDouble(textBox1.Text);
						textBox1.Clear();
						Operation = Operand.PLUS;
					}
					break;
				}
				case "minus":
				{
					if(textBox1.Text != "")
					{
						History.Text += tmp.Text;

						FirstNum = Convert.ToDouble(textBox1.Text);
						textBox1.Clear();
						Operation = Operand.MINUS;
					}
					break;
				}
				case "multiply":
				{
					if(textBox1.Text != "")
					{
						History.Text += tmp.Text;

						FirstNum = Convert.ToDouble(textBox1.Text);
						textBox1.Clear();
						Operation = Operand.MULTIPLY;
					}
					break;
				}
				case "divide":
				{
					if(textBox1.Text != "")
					{
						History.Text += tmp.Text;

						FirstNum = Convert.ToDouble(textBox1.Text);
						textBox1.Clear();
						Operation = Operand.DIVIDE;
					}
					break;
				}
				case "result":
				{
					if(Operation != Operand.RESULT)
					{
						double SecondNum = Convert.ToDouble(textBox1.Text);
						string res;
						switch(Operation)
						{
							case Operand.PLUS:
							{
								res = (FirstNum + SecondNum).ToString();
								break;
							}
							case Operand.MINUS:
							{
								res = (FirstNum - SecondNum).ToString();
								break;
							}
							case Operand.MULTIPLY:
							{
								res = (FirstNum * SecondNum).ToString();
								break;
							}
							case Operand.DIVIDE:
							{
								res = (FirstNum / SecondNum).ToString();
								break;
							}
							default:
							{
								res = "Error";
								break;
							}
						}
						Operation = Operand.RESULT;
						History.Text += tmp.Text;

						textBox1.Text = res;
						History.Text += res;
					}
					
					break;
				}
				default:
				{
					textBox1.Text += tmp.Text;
					History.Text += tmp.Text;
					break;
				}
			}

			
		}


	}
}
