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
			this._checkBoxPyramid = new System.Windows.Forms.CheckBox();
			this._checkBoxParallelepiped = new System.Windows.Forms.CheckBox();
			this._checkBoxBall = new System.Windows.Forms.CheckBox();
			this._buttonFound = new System.Windows.Forms.Button();
			this._groupBox1 = new System.Windows.Forms.GroupBox();
			this._checkBoxVolume = new System.Windows.Forms.CheckBox();
			this._textBoxValue = new System.Windows.Forms.TextBox();
			this._groupBoxTypeFigure.SuspendLayout();
			this._groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _groupBoxTypeFigure
			// 
			this._groupBoxTypeFigure.Controls.Add(this._checkBoxPyramid);
			this._groupBoxTypeFigure.Controls.Add(this._checkBoxParallelepiped);
			this._groupBoxTypeFigure.Controls.Add(this._checkBoxBall);
			this._groupBoxTypeFigure.Location = new System.Drawing.Point(12, 12);
			this._groupBoxTypeFigure.Name = "_groupBoxTypeFigure";
			this._groupBoxTypeFigure.Size = new System.Drawing.Size(187, 149);
			this._groupBoxTypeFigure.TabIndex = 0;
			this._groupBoxTypeFigure.TabStop = false;
			this._groupBoxTypeFigure.Text = "Основное условие";
			// 
			// _checkBoxPyramid
			// 
			this._checkBoxPyramid.AutoSize = true;
			this._checkBoxPyramid.Location = new System.Drawing.Point(20, 110);
			this._checkBoxPyramid.Name = "_checkBoxPyramid";
			this._checkBoxPyramid.Size = new System.Drawing.Size(96, 20);
			this._checkBoxPyramid.TabIndex = 2;
			this._checkBoxPyramid.Text = "Пирамида";
			this._checkBoxPyramid.UseVisualStyleBackColor = true;
			// 
			// _checkBoxParallelepiped
			// 
			this._checkBoxParallelepiped.AutoSize = true;
			this._checkBoxParallelepiped.Location = new System.Drawing.Point(20, 69);
			this._checkBoxParallelepiped.Name = "_checkBoxParallelepiped";
			this._checkBoxParallelepiped.Size = new System.Drawing.Size(143, 20);
			this._checkBoxParallelepiped.TabIndex = 1;
			this._checkBoxParallelepiped.Text = "Параллелепипед";
			this._checkBoxParallelepiped.UseVisualStyleBackColor = true;
			// 
			// _checkBoxBall
			// 
			this._checkBoxBall.AutoSize = true;
			this._checkBoxBall.Location = new System.Drawing.Point(20, 30);
			this._checkBoxBall.Name = "_checkBoxBall";
			this._checkBoxBall.Size = new System.Drawing.Size(56, 20);
			this._checkBoxBall.TabIndex = 0;
			this._checkBoxBall.Text = "Шар";
			this._checkBoxBall.UseVisualStyleBackColor = true;
			// 
			// _buttonFound
			// 
			this._buttonFound.Location = new System.Drawing.Point(12, 166);
			this._buttonFound.Name = "_buttonFound";
			this._buttonFound.Size = new System.Drawing.Size(187, 31);
			this._buttonFound.TabIndex = 1;
			this._buttonFound.Text = "Найти";
			this._buttonFound.UseVisualStyleBackColor = true;
			this._buttonFound.Click += new System.EventHandler(this.ButtonFoundClick);
			// 
			// _groupBox1
			// 
			this._groupBox1.Controls.Add(this._checkBoxVolume);
			this._groupBox1.Controls.Add(this._textBoxValue);
			this._groupBox1.Location = new System.Drawing.Point(213, 14);
			this._groupBox1.Name = "_groupBox1";
			this._groupBox1.Size = new System.Drawing.Size(241, 147);
			this._groupBox1.TabIndex = 2;
			this._groupBox1.TabStop = false;
			this._groupBox1.Text = "Дополнительное условие";
			// 
			// _checkBoxVolume
			// 
			this._checkBoxVolume.AutoSize = true;
			this._checkBoxVolume.Location = new System.Drawing.Point(19, 28);
			this._checkBoxVolume.Name = "_checkBoxVolume";
			this._checkBoxVolume.Size = new System.Drawing.Size(196, 20);
			this._checkBoxVolume.TabIndex = 2;
			this._checkBoxVolume.Text = "Задать величину объема";
			this._checkBoxVolume.UseVisualStyleBackColor = true;
			// 
			// _textBoxValue
			// 
			this._textBoxValue.Location = new System.Drawing.Point(19, 65);
			this._textBoxValue.Name = "_textBoxValue";
			this._textBoxValue.Size = new System.Drawing.Size(100, 22);
			this._textBoxValue.TabIndex = 1;
			// 
			// FilterForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 204);
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
		private System.Windows.Forms.Button _buttonFound;
		internal System.Windows.Forms.GroupBox _groupBox1;
		private System.Windows.Forms.TextBox _textBoxValue;
		private System.Windows.Forms.CheckBox _checkBoxPyramid;
		private System.Windows.Forms.CheckBox _checkBoxParallelepiped;
		private System.Windows.Forms.CheckBox _checkBoxBall;
		private System.Windows.Forms.CheckBox _checkBoxVolume;
	}
}