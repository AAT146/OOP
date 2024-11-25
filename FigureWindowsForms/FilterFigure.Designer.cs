namespace FigureWindowsForms
{
	partial class FilterFigure
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBoxTypeFigure = new System.Windows.Forms.GroupBox();
			this.radioButtonPyramid = new System.Windows.Forms.RadioButton();
			this.radioButtonParallelepiped = new System.Windows.Forms.RadioButton();
			this.radioButtonBall = new System.Windows.Forms.RadioButton();
			this.buttonFound = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxValue = new System.Windows.Forms.TextBox();
			this.radioButtonValue = new System.Windows.Forms.RadioButton();
			this.groupBoxTypeFigure.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxTypeFigure
			// 
			this.groupBoxTypeFigure.Controls.Add(this.radioButtonPyramid);
			this.groupBoxTypeFigure.Controls.Add(this.radioButtonParallelepiped);
			this.groupBoxTypeFigure.Controls.Add(this.radioButtonBall);
			this.groupBoxTypeFigure.Location = new System.Drawing.Point(12, 12);
			this.groupBoxTypeFigure.Name = "groupBoxTypeFigure";
			this.groupBoxTypeFigure.Size = new System.Drawing.Size(185, 149);
			this.groupBoxTypeFigure.TabIndex = 0;
			this.groupBoxTypeFigure.TabStop = false;
			this.groupBoxTypeFigure.Text = "Основное условие";
			// 
			// radioButtonPyramid
			// 
			this.radioButtonPyramid.AutoSize = true;
			this.radioButtonPyramid.Location = new System.Drawing.Point(19, 112);
			this.radioButtonPyramid.Name = "radioButtonPyramid";
			this.radioButtonPyramid.Size = new System.Drawing.Size(95, 20);
			this.radioButtonPyramid.TabIndex = 2;
			this.radioButtonPyramid.TabStop = true;
			this.radioButtonPyramid.Text = "Пирамида";
			this.radioButtonPyramid.UseVisualStyleBackColor = true;
			// 
			// radioButtonParallelepiped
			// 
			this.radioButtonParallelepiped.AutoSize = true;
			this.radioButtonParallelepiped.Location = new System.Drawing.Point(19, 71);
			this.radioButtonParallelepiped.Name = "radioButtonParallelepiped";
			this.radioButtonParallelepiped.Size = new System.Drawing.Size(142, 20);
			this.radioButtonParallelepiped.TabIndex = 1;
			this.radioButtonParallelepiped.TabStop = true;
			this.radioButtonParallelepiped.Text = "Параллелепипед";
			this.radioButtonParallelepiped.UseVisualStyleBackColor = true;
			// 
			// radioButtonBall
			// 
			this.radioButtonBall.AutoSize = true;
			this.radioButtonBall.Location = new System.Drawing.Point(19, 32);
			this.radioButtonBall.Name = "radioButtonBall";
			this.radioButtonBall.Size = new System.Drawing.Size(55, 20);
			this.radioButtonBall.TabIndex = 0;
			this.radioButtonBall.TabStop = true;
			this.radioButtonBall.Text = "Шар";
			this.radioButtonBall.UseVisualStyleBackColor = true;
			// 
			// buttonFound
			// 
			this.buttonFound.Location = new System.Drawing.Point(122, 171);
			this.buttonFound.Name = "buttonFound";
			this.buttonFound.Size = new System.Drawing.Size(213, 26);
			this.buttonFound.TabIndex = 1;
			this.buttonFound.Text = "Найти";
			this.buttonFound.UseVisualStyleBackColor = true;
			this.buttonFound.Click += new System.EventHandler(this.buttonFound_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxValue);
			this.groupBox1.Controls.Add(this.radioButtonValue);
			this.groupBox1.Location = new System.Drawing.Point(213, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(241, 149);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Дополнительное условие";
			// 
			// textBoxValue
			// 
			this.textBoxValue.Location = new System.Drawing.Point(121, 32);
			this.textBoxValue.Name = "textBoxValue";
			this.textBoxValue.Size = new System.Drawing.Size(100, 22);
			this.textBoxValue.TabIndex = 1;
			// 
			// radioButtonValue
			// 
			this.radioButtonValue.AutoSize = true;
			this.radioButtonValue.Location = new System.Drawing.Point(19, 32);
			this.radioButtonValue.Name = "radioButtonValue";
			this.radioButtonValue.Size = new System.Drawing.Size(96, 20);
			this.radioButtonValue.TabIndex = 0;
			this.radioButtonValue.TabStop = true;
			this.radioButtonValue.Text = "Значение:";
			this.radioButtonValue.UseVisualStyleBackColor = true;
			// 
			// FilterFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 205);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonFound);
			this.Controls.Add(this.groupBoxTypeFigure);
			this.Name = "FilterFigure";
			this.Text = "FilterFigure";
			this.groupBoxTypeFigure.ResumeLayout(false);
			this.groupBoxTypeFigure.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox groupBoxTypeFigure;
		private System.Windows.Forms.RadioButton radioButtonPyramid;
		private System.Windows.Forms.RadioButton radioButtonParallelepiped;
		private System.Windows.Forms.RadioButton radioButtonBall;
		private System.Windows.Forms.Button buttonFound;
		internal System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButtonValue;
		private System.Windows.Forms.TextBox textBoxValue;
	}
}