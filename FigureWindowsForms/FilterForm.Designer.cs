namespace FigureWindowsForms
{
	partial class FilterForm
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
			this._groupBoxTypeFigure = new System.Windows.Forms.GroupBox();
			this._radioButtonPyramid = new System.Windows.Forms.RadioButton();
			this._radioButtonParallelepiped = new System.Windows.Forms.RadioButton();
			this._radioButtonBall = new System.Windows.Forms.RadioButton();
			this._buttonFound = new System.Windows.Forms.Button();
			this._groupBox1 = new System.Windows.Forms.GroupBox();
			this._textBoxValue = new System.Windows.Forms.TextBox();
			this._radioButtonValue = new System.Windows.Forms.RadioButton();
			this._groupBoxTypeFigure.SuspendLayout();
			this._groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxTypeFigure
			// 
			this._groupBoxTypeFigure.Controls.Add(this._radioButtonPyramid);
			this._groupBoxTypeFigure.Controls.Add(this._radioButtonParallelepiped);
			this._groupBoxTypeFigure.Controls.Add(this._radioButtonBall);
			this._groupBoxTypeFigure.Location = new System.Drawing.Point(12, 12);
			this._groupBoxTypeFigure.Name = "groupBoxTypeFigure";
			this._groupBoxTypeFigure.Size = new System.Drawing.Size(185, 149);
			this._groupBoxTypeFigure.TabIndex = 0;
			this._groupBoxTypeFigure.TabStop = false;
			this._groupBoxTypeFigure.Text = "Основное условие";
			// 
			// radioButtonPyramid
			// 
			this._radioButtonPyramid.AutoSize = true;
			this._radioButtonPyramid.Location = new System.Drawing.Point(19, 112);
			this._radioButtonPyramid.Name = "radioButtonPyramid";
			this._radioButtonPyramid.Size = new System.Drawing.Size(95, 20);
			this._radioButtonPyramid.TabIndex = 2;
			this._radioButtonPyramid.TabStop = true;
			this._radioButtonPyramid.Text = "Пирамида";
			this._radioButtonPyramid.UseVisualStyleBackColor = true;
			// 
			// radioButtonParallelepiped
			// 
			this._radioButtonParallelepiped.AutoSize = true;
			this._radioButtonParallelepiped.Location = new System.Drawing.Point(19, 71);
			this._radioButtonParallelepiped.Name = "radioButtonParallelepiped";
			this._radioButtonParallelepiped.Size = new System.Drawing.Size(142, 20);
			this._radioButtonParallelepiped.TabIndex = 1;
			this._radioButtonParallelepiped.TabStop = true;
			this._radioButtonParallelepiped.Text = "Параллелепипед";
			this._radioButtonParallelepiped.UseVisualStyleBackColor = true;
			// 
			// radioButtonBall
			// 
			this._radioButtonBall.AutoSize = true;
			this._radioButtonBall.Location = new System.Drawing.Point(19, 32);
			this._radioButtonBall.Name = "radioButtonBall";
			this._radioButtonBall.Size = new System.Drawing.Size(55, 20);
			this._radioButtonBall.TabIndex = 0;
			this._radioButtonBall.TabStop = true;
			this._radioButtonBall.Text = "Шар";
			this._radioButtonBall.UseVisualStyleBackColor = true;
			// 
			// buttonFound
			// 
			this._buttonFound.Location = new System.Drawing.Point(122, 170);
			this._buttonFound.Name = "buttonFound";
			this._buttonFound.Size = new System.Drawing.Size(213, 26);
			this._buttonFound.TabIndex = 1;
			this._buttonFound.Text = "Найти";
			this._buttonFound.UseVisualStyleBackColor = true;
			this._buttonFound.Click += new System.EventHandler(this.buttonFound_Click);
			// 
			// groupBox1
			// 
			this._groupBox1.Controls.Add(this._textBoxValue);
			this._groupBox1.Controls.Add(this._radioButtonValue);
			this._groupBox1.Location = new System.Drawing.Point(213, 14);
			this._groupBox1.Name = "groupBox1";
			this._groupBox1.Size = new System.Drawing.Size(241, 147);
			this._groupBox1.TabIndex = 2;
			this._groupBox1.TabStop = false;
			this._groupBox1.Text = "Дополнительное условие";
			// 
			// textBoxValue
			// 
			this._textBoxValue.Location = new System.Drawing.Point(19, 67);
			this._textBoxValue.Name = "textBoxValue";
			this._textBoxValue.Size = new System.Drawing.Size(100, 22);
			this._textBoxValue.TabIndex = 1;
			// 
			// radioButtonValue
			// 
			this._radioButtonValue.AutoSize = true;
			this._radioButtonValue.Location = new System.Drawing.Point(19, 32);
			this._radioButtonValue.Name = "radioButtonValue";
			this._radioButtonValue.Size = new System.Drawing.Size(194, 20);
			this._radioButtonValue.TabIndex = 0;
			this._radioButtonValue.TabStop = true;
			this._radioButtonValue.Text = "Значение объма фигуры:";
			this._radioButtonValue.UseVisualStyleBackColor = true;
			// 
			// FilterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 205);
			this.Controls.Add(this._groupBox1);
			this.Controls.Add(this._buttonFound);
			this.Controls.Add(this._groupBoxTypeFigure);
			this.Name = "FilterForm";
			this.Text = "Фильтр";
			this._groupBoxTypeFigure.ResumeLayout(false);
			this._groupBoxTypeFigure.PerformLayout();
			this._groupBox1.ResumeLayout(false);
			this._groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.GroupBox _groupBoxTypeFigure;
		private System.Windows.Forms.RadioButton _radioButtonPyramid;
		private System.Windows.Forms.RadioButton _radioButtonParallelepiped;
		private System.Windows.Forms.RadioButton _radioButtonBall;
		private System.Windows.Forms.Button _buttonFound;
		internal System.Windows.Forms.GroupBox _groupBox1;
		private System.Windows.Forms.RadioButton _radioButtonValue;
		private System.Windows.Forms.TextBox _textBoxValue;
	}
}