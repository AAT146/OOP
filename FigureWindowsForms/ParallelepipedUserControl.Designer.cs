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
			this.labelLength = new System.Windows.Forms.Label();
			this.labelWidth = new System.Windows.Forms.Label();
			this.labelHeight = new System.Windows.Forms.Label();
			this.labelAngleLengthWidth = new System.Windows.Forms.Label();
			this.labelAngleLengthHeight = new System.Windows.Forms.Label();
			this.textBoxLength = new System.Windows.Forms.TextBox();
			this.textBoxWidth = new System.Windows.Forms.TextBox();
			this.textBoxHeight = new System.Windows.Forms.TextBox();
			this.textBoxAngleLengthWidth = new System.Windows.Forms.TextBox();
			this.textBoxAngleLengthHeight = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelLength
			// 
			this.labelLength.AutoSize = true;
			this.labelLength.Location = new System.Drawing.Point(11, 7);
			this.labelLength.Name = "labelLength";
			this.labelLength.Size = new System.Drawing.Size(68, 16);
			this.labelLength.TabIndex = 0;
			this.labelLength.Text = "Длина (Д)";
			// 
			// labelWidth
			// 
			this.labelWidth.AutoSize = true;
			this.labelWidth.Location = new System.Drawing.Point(11, 37);
			this.labelWidth.Name = "labelWidth";
			this.labelWidth.Size = new System.Drawing.Size(80, 16);
			this.labelWidth.TabIndex = 1;
			this.labelWidth.Text = "Ширина (Ш)";
			// 
			// labelHeight
			// 
			this.labelHeight.AutoSize = true;
			this.labelHeight.Location = new System.Drawing.Point(11, 67);
			this.labelHeight.Name = "labelHeight";
			this.labelHeight.Size = new System.Drawing.Size(75, 16);
			this.labelHeight.TabIndex = 2;
			this.labelHeight.Text = "Высота (В)";
			// 
			// labelAngleLengthWidth
			// 
			this.labelAngleLengthWidth.AutoSize = true;
			this.labelAngleLengthWidth.Location = new System.Drawing.Point(11, 97);
			this.labelAngleLengthWidth.Name = "labelAngleLengthWidth";
			this.labelAngleLengthWidth.Size = new System.Drawing.Size(113, 16);
			this.labelAngleLengthWidth.TabIndex = 3;
			this.labelAngleLengthWidth.Text = "Угол между Д^Ш";
			// 
			// labelAngleLengthHeight
			// 
			this.labelAngleLengthHeight.AutoSize = true;
			this.labelAngleLengthHeight.Location = new System.Drawing.Point(11, 127);
			this.labelAngleLengthHeight.Name = "labelAngleLengthHeight";
			this.labelAngleLengthHeight.Size = new System.Drawing.Size(114, 16);
			this.labelAngleLengthHeight.TabIndex = 4;
			this.labelAngleLengthHeight.Text = "Угол между Д^В ";
			// 
			// textBoxLength
			// 
			this.textBoxLength.Location = new System.Drawing.Point(160, 4);
			this.textBoxLength.Name = "textBoxLength";
			this.textBoxLength.Size = new System.Drawing.Size(100, 22);
			this.textBoxLength.TabIndex = 5;
			// 
			// textBoxWidth
			// 
			this.textBoxWidth.Location = new System.Drawing.Point(160, 34);
			this.textBoxWidth.Name = "textBoxWidth";
			this.textBoxWidth.Size = new System.Drawing.Size(100, 22);
			this.textBoxWidth.TabIndex = 6;
			// 
			// textBoxHeight
			// 
			this.textBoxHeight.Location = new System.Drawing.Point(160, 64);
			this.textBoxHeight.Name = "textBoxHeight";
			this.textBoxHeight.Size = new System.Drawing.Size(100, 22);
			this.textBoxHeight.TabIndex = 7;
			// 
			// textBoxAngleLengthWidth
			// 
			this.textBoxAngleLengthWidth.Location = new System.Drawing.Point(160, 94);
			this.textBoxAngleLengthWidth.Name = "textBoxAngleLengthWidth";
			this.textBoxAngleLengthWidth.Size = new System.Drawing.Size(100, 22);
			this.textBoxAngleLengthWidth.TabIndex = 8;
			// 
			// textBoxAngleLengthHeight
			// 
			this.textBoxAngleLengthHeight.Location = new System.Drawing.Point(160, 124);
			this.textBoxAngleLengthHeight.Name = "textBoxAngleLengthHeight";
			this.textBoxAngleLengthHeight.Size = new System.Drawing.Size(100, 22);
			this.textBoxAngleLengthHeight.TabIndex = 9;
			// 
			// ParallelepipedUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxAngleLengthHeight);
			this.Controls.Add(this.textBoxAngleLengthWidth);
			this.Controls.Add(this.textBoxHeight);
			this.Controls.Add(this.textBoxWidth);
			this.Controls.Add(this.textBoxLength);
			this.Controls.Add(this.labelAngleLengthHeight);
			this.Controls.Add(this.labelAngleLengthWidth);
			this.Controls.Add(this.labelHeight);
			this.Controls.Add(this.labelWidth);
			this.Controls.Add(this.labelLength);
			this.Name = "ParallelepipedUserControl";
			this.Size = new System.Drawing.Size(270, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal Label labelLength;
		internal Label labelWidth;
		internal Label labelHeight;
		internal Label labelAngleLengthWidth;
		internal Label labelAngleLengthHeight;
		internal TextBox textBoxWidth;
		internal TextBox textBoxHeight;
		internal TextBox textBoxAngleLengthWidth;
		internal TextBox textBoxAngleLengthHeight;
		internal TextBox textBoxLength;
	}
}