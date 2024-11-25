using System.Windows.Forms;

namespace FigureWindowsForms
{
	partial class AddForm
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
			this.radioButtonPyramida = new System.Windows.Forms.RadioButton();
			this.radioButtonParallelepiped = new System.Windows.Forms.RadioButton();
			this.radioButtonBall = new System.Windows.Forms.RadioButton();
			this.groupBoxParameters = new System.Windows.Forms.GroupBox();
			this.pyramidUserControl = new FigureWindowsForms.PyramidUserControl();
			this.parallelepipedUserControl = new FigureWindowsForms.ParallelepipedUserControl();
			this.ballUserControl = new FigureWindowsForms.BallUserControl();
			this.buttonVolume = new System.Windows.Forms.Button();
			this.groupBoxListFigure.SuspendLayout();
			this.groupBoxParameters.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxListFigure
			// 
			this.groupBoxListFigure.Controls.Add(this.radioButtonPyramida);
			this.groupBoxListFigure.Controls.Add(this.radioButtonParallelepiped);
			this.groupBoxListFigure.Controls.Add(this.radioButtonBall);
			this.groupBoxListFigure.Location = new System.Drawing.Point(14, 12);
			this.groupBoxListFigure.Name = "groupBoxListFigure";
			this.groupBoxListFigure.Size = new System.Drawing.Size(187, 184);
			this.groupBoxListFigure.TabIndex = 0;
			this.groupBoxListFigure.TabStop = false;
			this.groupBoxListFigure.Text = "Список фигур";
			// 
			// radioButtonPyramida
			// 
			this.radioButtonPyramida.AutoSize = true;
			this.radioButtonPyramida.Location = new System.Drawing.Point(17, 151);
			this.radioButtonPyramida.Name = "radioButtonPyramida";
			this.radioButtonPyramida.Size = new System.Drawing.Size(95, 20);
			this.radioButtonPyramida.TabIndex = 0;
			this.radioButtonPyramida.Text = "Пирамида";
			this.radioButtonPyramida.UseVisualStyleBackColor = true;
			this.radioButtonPyramida.CheckedChanged += new System.EventHandler(this.RadioButtonPyramidaCheckedChanged);
			// 
			// radioButtonParallelepiped
			// 
			this.radioButtonParallelepiped.AutoSize = true;
			this.radioButtonParallelepiped.Location = new System.Drawing.Point(17, 89);
			this.radioButtonParallelepiped.Name = "radioButtonParallelepiped";
			this.radioButtonParallelepiped.Size = new System.Drawing.Size(142, 20);
			this.radioButtonParallelepiped.TabIndex = 0;
			this.radioButtonParallelepiped.Text = "Параллелепипед";
			this.radioButtonParallelepiped.UseVisualStyleBackColor = true;
			this.radioButtonParallelepiped.CheckedChanged += new System.EventHandler(this.RadioButtonParallelepipedCheckedChanged);
			// 
			// radioButtonBall
			// 
			this.radioButtonBall.AutoSize = true;
			this.radioButtonBall.Location = new System.Drawing.Point(17, 30);
			this.radioButtonBall.Name = "radioButtonBall";
			this.radioButtonBall.Size = new System.Drawing.Size(55, 20);
			this.radioButtonBall.TabIndex = 0;
			this.radioButtonBall.Text = "Шар";
			this.radioButtonBall.UseVisualStyleBackColor = true;
			this.radioButtonBall.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
			// 
			// groupBoxParameters
			// 
			this.groupBoxParameters.Controls.Add(this.parallelepipedUserControl);
			this.groupBoxParameters.Controls.Add(this.ballUserControl);
			this.groupBoxParameters.Controls.Add(this.pyramidUserControl);
			this.groupBoxParameters.Location = new System.Drawing.Point(218, 12);
			this.groupBoxParameters.Name = "groupBoxParameters";
			this.groupBoxParameters.Size = new System.Drawing.Size(281, 184);
			this.groupBoxParameters.TabIndex = 1;
			this.groupBoxParameters.TabStop = false;
			this.groupBoxParameters.Text = "Параметры, см";
			// 
			// pyramidUserControl
			// 
			this.pyramidUserControl.Location = new System.Drawing.Point(6, 21);
			this.pyramidUserControl.Name = "pyramidUserControl";
			this.pyramidUserControl.Size = new System.Drawing.Size(270, 150);
			this.pyramidUserControl.TabIndex = 2;
			this.pyramidUserControl.Visible = false;
			// 
			// parallelepipedUserControl
			// 
			this.parallelepipedUserControl.Location = new System.Drawing.Point(6, 21);
			this.parallelepipedUserControl.Name = "parallelepipedUserControl";
			this.parallelepipedUserControl.Size = new System.Drawing.Size(269, 153);
			this.parallelepipedUserControl.TabIndex = 1;
			this.parallelepipedUserControl.Visible = false;
			// 
			// ballUserControl
			// 
			this.ballUserControl.Location = new System.Drawing.Point(7, 23);
			this.ballUserControl.Name = "ballUserControl";
			this.ballUserControl.Size = new System.Drawing.Size(268, 150);
			this.ballUserControl.TabIndex = 0;
			this.ballUserControl.Visible = false;
			// 
			// buttonVolume
			// 
			this.buttonVolume.Location = new System.Drawing.Point(218, 202);
			this.buttonVolume.Name = "buttonVolume";
			this.buttonVolume.Size = new System.Drawing.Size(281, 25);
			this.buttonVolume.TabIndex = 2;
			this.buttonVolume.Text = "Добавить объём фигуры";
			this.buttonVolume.UseVisualStyleBackColor = true;
			this.buttonVolume.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 239);
			this.Controls.Add(this.buttonVolume);
			this.Controls.Add(this.groupBoxParameters);
			this.Controls.Add(this.groupBoxListFigure);
			this.Name = "AddFigure";
			this.Text = "Добавление фигуры";
			this.groupBoxListFigure.ResumeLayout(false);
			this.groupBoxListFigure.PerformLayout();
			this.groupBoxParameters.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal GroupBox groupBoxListFigure;
		internal GroupBox groupBoxParameters;
		internal Button buttonVolume;
		internal BallUserControl ballUserControl;
		internal ParallelepipedUserControl parallelepipedUserControl;
		internal PyramidUserControl pyramidUserControl;
		internal RadioButton radioButtonPyramida;
		internal RadioButton radioButtonBall;
		internal RadioButton radioButtonParallelepiped;
	}
}