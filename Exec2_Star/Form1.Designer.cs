namespace Exec2_Star
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.rightTriangleButton = new System.Windows.Forms.Button();
			this.isoscelesTriangleButton = new System.Windows.Forms.Button();
			this.leftTriangleButton = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.inputTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// rightTriangleButton
			// 
			this.rightTriangleButton.Location = new System.Drawing.Point(105, 45);
			this.rightTriangleButton.Name = "rightTriangleButton";
			this.rightTriangleButton.Size = new System.Drawing.Size(131, 38);
			this.rightTriangleButton.TabIndex = 0;
			this.rightTriangleButton.Text = "靠左三角形";
			this.rightTriangleButton.UseVisualStyleBackColor = true;
			this.rightTriangleButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// isoscelesTriangleButton
			// 
			this.isoscelesTriangleButton.Location = new System.Drawing.Point(534, 45);
			this.isoscelesTriangleButton.Name = "isoscelesTriangleButton";
			this.isoscelesTriangleButton.Size = new System.Drawing.Size(124, 38);
			this.isoscelesTriangleButton.TabIndex = 1;
			this.isoscelesTriangleButton.Text = "等腰三角形";
			this.isoscelesTriangleButton.UseVisualStyleBackColor = true;
			this.isoscelesTriangleButton.Click += new System.EventHandler(this.isoscelesTriangleButton_Click);
			// 
			// leftTriangleButton
			// 
			this.leftTriangleButton.Location = new System.Drawing.Point(322, 45);
			this.leftTriangleButton.Name = "leftTriangleButton";
			this.leftTriangleButton.Size = new System.Drawing.Size(118, 38);
			this.leftTriangleButton.TabIndex = 2;
			this.leftTriangleButton.Text = "靠右三角形";
			this.leftTriangleButton.UseVisualStyleBackColor = true;
			this.leftTriangleButton.Click += new System.EventHandler(this.leftTriangleButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(122, 177);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(300, 224);
			this.textBox1.TabIndex = 3;
			// 
			// inputTextBox
			// 
			this.inputTextBox.Location = new System.Drawing.Point(131, 114);
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.Size = new System.Drawing.Size(125, 29);
			this.inputTextBox.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.leftTriangleButton);
			this.Controls.Add(this.isoscelesTriangleButton);
			this.Controls.Add(this.rightTriangleButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button rightTriangleButton;
		private System.Windows.Forms.Button isoscelesTriangleButton;
		private System.Windows.Forms.Button leftTriangleButton;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox inputTextBox;
	}
}

