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
			this.labelRadius = new System.Windows.Forms.Label();
			this.textBoxRadius = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// labelRadius
			// 
			this.labelRadius.AutoSize = true;
			this.labelRadius.Location = new System.Drawing.Point(11, 7);
			this.labelRadius.Name = "labelRadius";
			this.labelRadius.Size = new System.Drawing.Size(55, 16);
			this.labelRadius.TabIndex = 0;
			this.labelRadius.Text = "Радиус";
			this.labelRadius.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBoxRadius
			// 
			this.textBoxRadius.Location = new System.Drawing.Point(160, 4);
			this.textBoxRadius.Name = "textBoxRadius";
			this.textBoxRadius.Size = new System.Drawing.Size(100, 22);
			this.textBoxRadius.TabIndex = 1;
			// 
			// BallUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxRadius);
			this.Controls.Add(this.labelRadius);
			this.Name = "BallUserControl";
			this.Size = new System.Drawing.Size(270, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		internal System.Windows.Forms.Label labelRadius;
		internal System.Windows.Forms.TextBox textBoxRadius;
	}
}
