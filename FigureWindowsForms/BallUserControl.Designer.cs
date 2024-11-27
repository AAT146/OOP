namespace FigureWindowsForms
{
	partial class BallUserControl
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
			this._labelRadius = new System.Windows.Forms.Label();
			this._textBoxRadius = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelRadius
			// 
			this._labelRadius.AutoSize = true;
			this._labelRadius.Location = new System.Drawing.Point(11, 7);
			this._labelRadius.Name = "labelRadius";
			this._labelRadius.Size = new System.Drawing.Size(55, 16);
			this._labelRadius.TabIndex = 0;
			this._labelRadius.Text = "Радиус";
			// 
			// textBoxRadius
			// 
			this._textBoxRadius.Location = new System.Drawing.Point(160, 4);
			this._textBoxRadius.Name = "textBoxRadius";
			this._textBoxRadius.Size = new System.Drawing.Size(100, 22);
			this._textBoxRadius.TabIndex = 1;
			this._textBoxRadius.MaxLength = 7;
			// 
			// BallUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._textBoxRadius);
			this.Controls.Add(this._labelRadius);
			this.Name = "BallUserControl";
			this.Size = new System.Drawing.Size(270, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		internal System.Windows.Forms.Label _labelRadius;
		internal System.Windows.Forms.TextBox _textBoxRadius;
	}
}
