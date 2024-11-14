namespace FigureWindowsForms
{
	partial class AddFigure
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
			this.groupBoxListFigure = new System.Windows.Forms.GroupBox();
			this.groupBoxParameters = new System.Windows.Forms.GroupBox();
			this.figurePyramid = new System.Windows.Forms.CheckBox();
			this.figureParallelepiped = new System.Windows.Forms.CheckBox();
			this.figureBall = new System.Windows.Forms.CheckBox();
			this.groupBoxListFigure.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxListFigure
			// 
			this.groupBoxListFigure.Controls.Add(this.figurePyramid);
			this.groupBoxListFigure.Controls.Add(this.figureParallelepiped);
			this.groupBoxListFigure.Controls.Add(this.figureBall);
			this.groupBoxListFigure.Location = new System.Drawing.Point(14, 12);
			this.groupBoxListFigure.Name = "groupBoxListFigure";
			this.groupBoxListFigure.Size = new System.Drawing.Size(187, 182);
			this.groupBoxListFigure.TabIndex = 0;
			this.groupBoxListFigure.TabStop = false;
			this.groupBoxListFigure.Text = "Список фигур";
			// 
			// groupBoxParameters
			// 
			this.groupBoxParameters.Location = new System.Drawing.Point(218, 12);
			this.groupBoxParameters.Name = "groupBoxParameters";
			this.groupBoxParameters.Size = new System.Drawing.Size(281, 182);
			this.groupBoxParameters.TabIndex = 1;
			this.groupBoxParameters.TabStop = false;
			this.groupBoxParameters.Text = "Параметры, см";
			// 
			// figurePyramid
			// 
			this.figurePyramid.AutoSize = true;
			this.figurePyramid.Location = new System.Drawing.Point(7, 75);
			this.figurePyramid.Name = "figurePyramid";
			this.figurePyramid.Size = new System.Drawing.Size(96, 20);
			this.figurePyramid.TabIndex = 2;
			this.figurePyramid.Text = "Пирамида";
			this.figurePyramid.UseVisualStyleBackColor = true;
			// 
			// figureParallelepiped
			// 
			this.figureParallelepiped.AutoSize = true;
			this.figureParallelepiped.Location = new System.Drawing.Point(7, 49);
			this.figureParallelepiped.Name = "figureParallelepiped";
			this.figureParallelepiped.Size = new System.Drawing.Size(143, 20);
			this.figureParallelepiped.TabIndex = 1;
			this.figureParallelepiped.Text = "Параллелепипед";
			this.figureParallelepiped.UseVisualStyleBackColor = true;
			this.figureParallelepiped.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
			// 
			// figureBall
			// 
			this.figureBall.AutoSize = true;
			this.figureBall.Location = new System.Drawing.Point(7, 23);
			this.figureBall.Name = "figureBall";
			this.figureBall.Size = new System.Drawing.Size(56, 20);
			this.figureBall.TabIndex = 0;
			this.figureBall.Text = "Шар";
			this.figureBall.UseVisualStyleBackColor = true;
			this.figureBall.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// AddFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 206);
			this.Controls.Add(this.groupBoxParameters);
			this.Controls.Add(this.groupBoxListFigure);
			this.Name = "AddFigure";
			this.Text = "AddFigure";
			this.groupBoxListFigure.ResumeLayout(false);
			this.groupBoxListFigure.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxListFigure;
		private System.Windows.Forms.GroupBox groupBoxParameters;
		private System.Windows.Forms.CheckBox figurePyramid;
		private System.Windows.Forms.CheckBox figureParallelepiped;
		private System.Windows.Forms.CheckBox figureBall;
	}
}