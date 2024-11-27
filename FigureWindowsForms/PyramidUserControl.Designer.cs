namespace FigureWindowsForms
{
	partial class PyramidUserControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this._labelAreaOfBase = new System.Windows.Forms.Label();
			this._labelPyramidHeight = new System.Windows.Forms.Label();
			this._textBoxAreaOfBase = new System.Windows.Forms.TextBox();
			this._textBoxPyramidHeight = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelAreaOfBase
			// 
			this._labelAreaOfBase.AutoSize = true;
			this._labelAreaOfBase.Location = new System.Drawing.Point(11, 7);
			this._labelAreaOfBase.Name = "labelAreaOfBase";
			this._labelAreaOfBase.Size = new System.Drawing.Size(138, 16);
			this._labelAreaOfBase.TabIndex = 0;
			this._labelAreaOfBase.Text = "Площадь основания";
			// 
			// labelPyramidHeight
			// 
			this._labelPyramidHeight.AutoSize = true;
			this._labelPyramidHeight.Location = new System.Drawing.Point(11, 37);
			this._labelPyramidHeight.Name = "labelPyramidHeight";
			this._labelPyramidHeight.Size = new System.Drawing.Size(55, 16);
			this._labelPyramidHeight.TabIndex = 1;
			this._labelPyramidHeight.Text = "Высота";
			// 
			// textBoxAreaOfBase
			// 
			this._textBoxAreaOfBase.Location = new System.Drawing.Point(160, 4);
			this._textBoxAreaOfBase.Name = "textBoxAreaOfBase";
			this._textBoxAreaOfBase.Size = new System.Drawing.Size(100, 22);
			this._textBoxAreaOfBase.TabIndex = 2;
			this._textBoxAreaOfBase.MaxLength = 7;
			// 
			// textBoxPyramidHeight
			// 
			this._textBoxPyramidHeight.Location = new System.Drawing.Point(160, 34);
			this._textBoxPyramidHeight.Name = "textBoxPyramidHeight";
			this._textBoxPyramidHeight.Size = new System.Drawing.Size(100, 22);
			this._textBoxPyramidHeight.TabIndex = 3;
			this._textBoxPyramidHeight.MaxLength = 7;
			// 
			// PyramidUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._textBoxPyramidHeight);
			this.Controls.Add(this._textBoxAreaOfBase);
			this.Controls.Add(this._labelPyramidHeight);
			this.Controls.Add(this._labelAreaOfBase);
			this.Name = "PyramidUserControl";
			this.Size = new System.Drawing.Size(270, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label _labelAreaOfBase;
		internal System.Windows.Forms.Label _labelPyramidHeight;
		internal System.Windows.Forms.TextBox _textBoxAreaOfBase;
		internal System.Windows.Forms.TextBox _textBoxPyramidHeight;
	}
}
