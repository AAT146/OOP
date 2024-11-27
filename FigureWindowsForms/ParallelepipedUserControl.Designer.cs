using System.Windows.Forms;

namespace FigureWindowsForms
{
	partial class ParallelepipedUserControl
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
			this._labelLength = new System.Windows.Forms.Label();
			this._labelWidth = new System.Windows.Forms.Label();
			this._labelHeight = new System.Windows.Forms.Label();
			this._labelAngleLengthWidth = new System.Windows.Forms.Label();
			this._labelAngleLengthHeight = new System.Windows.Forms.Label();
			this._textBoxLength = new System.Windows.Forms.TextBox();
			this._textBoxWidth = new System.Windows.Forms.TextBox();
			this._textBoxHeight = new System.Windows.Forms.TextBox();
			this._textBoxAngleLengthWidth = new System.Windows.Forms.TextBox();
			this._textBoxAngleLengthHeight = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelLength
			// 
			this._labelLength.AutoSize = true;
			this._labelLength.Location = new System.Drawing.Point(11, 7);
			this._labelLength.Name = "labelLength";
			this._labelLength.Size = new System.Drawing.Size(68, 16);
			this._labelLength.TabIndex = 0;
			this._labelLength.Text = "Длина (Д)";
			// 
			// labelWidth
			// 
			this._labelWidth.AutoSize = true;
			this._labelWidth.Location = new System.Drawing.Point(11, 37);
			this._labelWidth.Name = "labelWidth";
			this._labelWidth.Size = new System.Drawing.Size(80, 16);
			this._labelWidth.TabIndex = 1;
			this._labelWidth.Text = "Ширина (Ш)";
			// 
			// labelHeight
			// 
			this._labelHeight.AutoSize = true;
			this._labelHeight.Location = new System.Drawing.Point(11, 67);
			this._labelHeight.Name = "labelHeight";
			this._labelHeight.Size = new System.Drawing.Size(75, 16);
			this._labelHeight.TabIndex = 2;
			this._labelHeight.Text = "Высота (В)";
			// 
			// labelAngleLengthWidth
			// 
			this._labelAngleLengthWidth.AutoSize = true;
			this._labelAngleLengthWidth.Location = new System.Drawing.Point(11, 97);
			this._labelAngleLengthWidth.Name = "labelAngleLengthWidth";
			this._labelAngleLengthWidth.Size = new System.Drawing.Size(113, 16);
			this._labelAngleLengthWidth.TabIndex = 3;
			this._labelAngleLengthWidth.Text = "Угол между Д^Ш";
			// 
			// labelAngleLengthHeight
			// 
			this._labelAngleLengthHeight.AutoSize = true;
			this._labelAngleLengthHeight.Location = new System.Drawing.Point(11, 127);
			this._labelAngleLengthHeight.Name = "labelAngleLengthHeight";
			this._labelAngleLengthHeight.Size = new System.Drawing.Size(114, 16);
			this._labelAngleLengthHeight.TabIndex = 4;
			this._labelAngleLengthHeight.Text = "Угол между Д^В ";
			// 
			// textBoxLength
			// 
			this._textBoxLength.Location = new System.Drawing.Point(160, 4);
			this._textBoxLength.Name = "textBoxLength";
			this._textBoxLength.Size = new System.Drawing.Size(100, 22);
			this._textBoxLength.TabIndex = 5;
			this._textBoxLength.MaxLength = 7;
			// 
			// textBoxWidth
			// 
			this._textBoxWidth.Location = new System.Drawing.Point(160, 34);
			this._textBoxWidth.Name = "textBoxWidth";
			this._textBoxWidth.Size = new System.Drawing.Size(100, 22);
			this._textBoxWidth.TabIndex = 6;
			this._textBoxWidth.MaxLength = 7;
			// 
			// textBoxHeight
			// 
			this._textBoxHeight.Location = new System.Drawing.Point(160, 64);
			this._textBoxHeight.Name = "textBoxHeight";
			this._textBoxHeight.Size = new System.Drawing.Size(100, 22);
			this._textBoxHeight.TabIndex = 7;
			this._textBoxHeight.MaxLength = 7;
			// 
			// textBoxAngleLengthWidth
			// 
			this._textBoxAngleLengthWidth.Location = new System.Drawing.Point(160, 94);
			this._textBoxAngleLengthWidth.Name = "textBoxAngleLengthWidth";
			this._textBoxAngleLengthWidth.Size = new System.Drawing.Size(100, 22);
			this._textBoxAngleLengthWidth.TabIndex = 8;
			this._textBoxAngleLengthWidth.MaxLength = 7;
			// 
			// textBoxAngleLengthHeight
			// 
			this._textBoxAngleLengthHeight.Location = new System.Drawing.Point(160, 124);
			this._textBoxAngleLengthHeight.Name = "textBoxAngleLengthHeight";
			this._textBoxAngleLengthHeight.Size = new System.Drawing.Size(100, 22);
			this._textBoxAngleLengthHeight.TabIndex = 9;
			this._textBoxAngleLengthHeight.MaxLength = 7;
			// 
			// ParallelepipedUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this._textBoxAngleLengthHeight);
			this.Controls.Add(this._textBoxAngleLengthWidth);
			this.Controls.Add(this._textBoxHeight);
			this.Controls.Add(this._textBoxWidth);
			this.Controls.Add(this._textBoxLength);
			this.Controls.Add(this._labelAngleLengthHeight);
			this.Controls.Add(this._labelAngleLengthWidth);
			this.Controls.Add(this._labelHeight);
			this.Controls.Add(this._labelWidth);
			this.Controls.Add(this._labelLength);
			this.Name = "ParallelepipedUserControl";
			this.Size = new System.Drawing.Size(270, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal Label _labelLength;
		internal Label _labelWidth;
		internal Label _labelHeight;
		internal Label _labelAngleLengthWidth;
		internal Label _labelAngleLengthHeight;
		internal TextBox _textBoxWidth;
		internal TextBox _textBoxHeight;
		internal TextBox _textBoxAngleLengthWidth;
		internal TextBox _textBoxAngleLengthHeight;
		internal TextBox _textBoxLength;
	}
}