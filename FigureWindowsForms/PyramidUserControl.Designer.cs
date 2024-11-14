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
			this.labelAreaOfBase = new System.Windows.Forms.Label();
			this.labelPyramidHeight = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelAreaOfBase
			// 
			this.labelAreaOfBase.AutoSize = true;
			this.labelAreaOfBase.Location = new System.Drawing.Point(13, 7);
			this.labelAreaOfBase.Name = "labelAreaOfBase";
			this.labelAreaOfBase.Size = new System.Drawing.Size(138, 16);
			this.labelAreaOfBase.TabIndex = 0;
			this.labelAreaOfBase.Text = "Площадь основания";
			// 
			// labelPyramidHeight
			// 
			this.labelPyramidHeight.AutoSize = true;
			this.labelPyramidHeight.Location = new System.Drawing.Point(13, 37);
			this.labelPyramidHeight.Name = "labelPyramidHeight";
			this.labelPyramidHeight.Size = new System.Drawing.Size(55, 16);
			this.labelPyramidHeight.TabIndex = 1;
			this.labelPyramidHeight.Text = "Высота";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(160, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(160, 34);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 3;
			// 
			// PyramidUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelPyramidHeight);
			this.Controls.Add(this.labelAreaOfBase);
			this.Name = "PyramidUserControl";
			this.Size = new System.Drawing.Size(270, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAreaOfBase;
		private System.Windows.Forms.Label labelPyramidHeight;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
	}
}
