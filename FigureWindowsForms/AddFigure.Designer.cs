using System.Windows.Forms;

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
			this.buttonVolume = new System.Windows.Forms.Button();
			this.radioButtonBall = new System.Windows.Forms.RadioButton();
			this.radioButtonParallelepiped = new System.Windows.Forms.RadioButton();
			this.radioButtonPyramida = new System.Windows.Forms.RadioButton();
			this.groupBoxListFigure.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxListFigure
			// 
			this.groupBoxListFigure.Controls.Add(this.radioButtonPyramida);
			this.groupBoxListFigure.Controls.Add(this.radioButtonParallelepiped);
			this.groupBoxListFigure.Controls.Add(this.radioButtonBall);
			this.groupBoxListFigure.Location = new System.Drawing.Point(14, 12);
			this.groupBoxListFigure.Name = "groupBoxListFigure";
			this.groupBoxListFigure.Size = new System.Drawing.Size(187, 154);
			this.groupBoxListFigure.TabIndex = 0;
			this.groupBoxListFigure.TabStop = false;
			this.groupBoxListFigure.Text = "Список фигур";
			// 
			// groupBoxParameters
			// 
			this.groupBoxParameters.Location = new System.Drawing.Point(218, 12);
			this.groupBoxParameters.Name = "groupBoxParameters";
			this.groupBoxParameters.Size = new System.Drawing.Size(281, 154);
			this.groupBoxParameters.TabIndex = 1;
			this.groupBoxParameters.TabStop = false;
			this.groupBoxParameters.Text = "Параметры, см";
			// 
			// buttonVolume
			// 
			this.buttonVolume.Location = new System.Drawing.Point(218, 172);
			this.buttonVolume.Name = "buttonVolume";
			this.buttonVolume.Size = new System.Drawing.Size(281, 25);
			this.buttonVolume.TabIndex = 2;
			this.buttonVolume.Text = "Расчитать объем";
			this.buttonVolume.UseVisualStyleBackColor = true;
			this.buttonVolume.Click += new System.EventHandler(this.button1_Click);
			// 
			// radioButtonBall
			// 
			this.radioButtonBall.AutoSize = true;
			this.radioButtonBall.Location = new System.Drawing.Point(17, 30);
			this.radioButtonBall.Name = "radioButtonBall";
			this.radioButtonBall.Size = new System.Drawing.Size(55, 20);
			this.radioButtonBall.TabIndex = 0;
			this.radioButtonBall.TabStop = true;
			this.radioButtonBall.Text = "Шар";
			this.radioButtonBall.UseVisualStyleBackColor = true;
			this.radioButtonBall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButtonParallelepiped
			// 
			this.radioButtonParallelepiped.AutoSize = true;
			this.radioButtonParallelepiped.Location = new System.Drawing.Point(17, 75);
			this.radioButtonParallelepiped.Name = "radioButtonParallelepiped";
			this.radioButtonParallelepiped.Size = new System.Drawing.Size(142, 20);
			this.radioButtonParallelepiped.TabIndex = 0;
			this.radioButtonParallelepiped.TabStop = true;
			this.radioButtonParallelepiped.Text = "Параллелепипед";
			this.radioButtonParallelepiped.UseVisualStyleBackColor = true;
			// 
			// radioButtonPyramida
			// 
			this.radioButtonPyramida.AutoSize = true;
			this.radioButtonPyramida.Location = new System.Drawing.Point(17, 119);
			this.radioButtonPyramida.Name = "radioButtonPyramida";
			this.radioButtonPyramida.Size = new System.Drawing.Size(95, 20);
			this.radioButtonPyramida.TabIndex = 0;
			this.radioButtonPyramida.TabStop = true;
			this.radioButtonPyramida.Text = "Пирамида";
			this.radioButtonPyramida.UseVisualStyleBackColor = true;
			// 
			// AddFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 206);
			this.Controls.Add(this.buttonVolume);
			this.Controls.Add(this.groupBoxParameters);
			this.Controls.Add(this.groupBoxListFigure);
			this.Name = "AddFigure";
			this.Text = "Добавление фигуры";
			this.groupBoxListFigure.ResumeLayout(false);
			this.groupBoxListFigure.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBoxListFigure;
		private GroupBox groupBoxParameters;
		private Button buttonVolume;
		private BallUserControl ballUserControl;
		private ParallelepipedUserControl parallelepipedUserControl;
		private PyramidUserControl pyramidUserControl;
		private RadioButton radioButtonPyramida;
		private RadioButton radioButtonParallelepiped;
		private RadioButton radioButtonBall;
	}
}