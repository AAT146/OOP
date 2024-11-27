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
			this._groupBoxListFigure = new System.Windows.Forms.GroupBox();
			this._radioButtonPyramida = new System.Windows.Forms.RadioButton();
			this._radioButtonParallelepiped = new System.Windows.Forms.RadioButton();
			this._radioButtonBall = new System.Windows.Forms.RadioButton();
			this._groupBoxParameters = new System.Windows.Forms.GroupBox();
			this._pyramidUserControl = new FigureWindowsForms.PyramidUserControl();
			this._parallelepipedUserControl = new FigureWindowsForms.ParallelepipedUserControl();
			this._ballUserControl = new FigureWindowsForms.BallUserControl();
			this._buttonVolume = new System.Windows.Forms.Button();
			this._groupBoxListFigure.SuspendLayout();
			this._groupBoxParameters.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxListFigure
			// 
			this._groupBoxListFigure.Controls.Add(this._radioButtonPyramida);
			this._groupBoxListFigure.Controls.Add(this._radioButtonParallelepiped);
			this._groupBoxListFigure.Controls.Add(this._radioButtonBall);
			this._groupBoxListFigure.Location = new System.Drawing.Point(14, 12);
			this._groupBoxListFigure.Name = "groupBoxListFigure";
			this._groupBoxListFigure.Size = new System.Drawing.Size(187, 184);
			this._groupBoxListFigure.TabIndex = 0;
			this._groupBoxListFigure.TabStop = false;
			this._groupBoxListFigure.Text = "Список фигур";
			// 
			// radioButtonPyramida
			// 
			this._radioButtonPyramida.AutoSize = true;
			this._radioButtonPyramida.Location = new System.Drawing.Point(17, 151);
			this._radioButtonPyramida.Name = "radioButtonPyramida";
			this._radioButtonPyramida.Size = new System.Drawing.Size(95, 20);
			this._radioButtonPyramida.TabIndex = 0;
			this._radioButtonPyramida.Text = "Пирамида";
			this._radioButtonPyramida.UseVisualStyleBackColor = true;
			this._radioButtonPyramida.CheckedChanged += new System.EventHandler(this.RadioButtonPyramidaCheckedChanged);
			// 
			// radioButtonParallelepiped
			// 
			this._radioButtonParallelepiped.AutoSize = true;
			this._radioButtonParallelepiped.Location = new System.Drawing.Point(17, 89);
			this._radioButtonParallelepiped.Name = "radioButtonParallelepiped";
			this._radioButtonParallelepiped.Size = new System.Drawing.Size(142, 20);
			this._radioButtonParallelepiped.TabIndex = 0;
			this._radioButtonParallelepiped.Text = "Параллелепипед";
			this._radioButtonParallelepiped.UseVisualStyleBackColor = true;
			this._radioButtonParallelepiped.CheckedChanged += new System.EventHandler(this.RadioButtonParallelepipedCheckedChanged);
			// 
			// radioButtonBall
			// 
			this._radioButtonBall.AutoSize = true;
			this._radioButtonBall.Location = new System.Drawing.Point(17, 30);
			this._radioButtonBall.Name = "radioButtonBall";
			this._radioButtonBall.Size = new System.Drawing.Size(55, 20);
			this._radioButtonBall.TabIndex = 0;
			this._radioButtonBall.Text = "Шар";
			this._radioButtonBall.UseVisualStyleBackColor = true;
			this._radioButtonBall.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
			// 
			// groupBoxParameters
			// 
			this._groupBoxParameters.Controls.Add(this._parallelepipedUserControl);
			this._groupBoxParameters.Controls.Add(this._ballUserControl);
			this._groupBoxParameters.Controls.Add(this._pyramidUserControl);
			this._groupBoxParameters.Location = new System.Drawing.Point(218, 12);
			this._groupBoxParameters.Name = "groupBoxParameters";
			this._groupBoxParameters.Size = new System.Drawing.Size(281, 184);
			this._groupBoxParameters.TabIndex = 1;
			this._groupBoxParameters.TabStop = false;
			this._groupBoxParameters.Text = "Параметры, см";
			// 
			// pyramidUserControl
			// 
			this._pyramidUserControl.Location = new System.Drawing.Point(6, 21);
			this._pyramidUserControl.Name = "pyramidUserControl";
			this._pyramidUserControl.Size = new System.Drawing.Size(270, 150);
			this._pyramidUserControl.TabIndex = 2;
			this._pyramidUserControl.Visible = false;
			// 
			// parallelepipedUserControl
			// 
			this._parallelepipedUserControl.Location = new System.Drawing.Point(6, 21);
			this._parallelepipedUserControl.Name = "parallelepipedUserControl";
			this._parallelepipedUserControl.Size = new System.Drawing.Size(269, 153);
			this._parallelepipedUserControl.TabIndex = 1;
			this._parallelepipedUserControl.Visible = false;
			// 
			// ballUserControl
			// 
			this._ballUserControl.Location = new System.Drawing.Point(7, 23);
			this._ballUserControl.Name = "ballUserControl";
			this._ballUserControl.Size = new System.Drawing.Size(268, 150);
			this._ballUserControl.TabIndex = 0;
			this._ballUserControl.Visible = false;
			// 
			// buttonVolume
			// 
			this._buttonVolume.Location = new System.Drawing.Point(218, 202);
			this._buttonVolume.Name = "buttonVolume";
			this._buttonVolume.Size = new System.Drawing.Size(281, 25);
			this._buttonVolume.TabIndex = 2;
			this._buttonVolume.Text = "Добавить объём фигуры";
			this._buttonVolume.UseVisualStyleBackColor = true;
			this._buttonVolume.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(511, 239);
			this.Controls.Add(this._buttonVolume);
			this.Controls.Add(this._groupBoxParameters);
			this.Controls.Add(this._groupBoxListFigure);
			this.Name = "AddFigure";
			this.Text = "Добавление фигуры";
			this._groupBoxListFigure.ResumeLayout(false);
			this._groupBoxListFigure.PerformLayout();
			this._groupBoxParameters.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		internal GroupBox _groupBoxListFigure;
		internal GroupBox _groupBoxParameters;
		internal Button _buttonVolume;
		internal BallUserControl _ballUserControl;
		internal ParallelepipedUserControl _parallelepipedUserControl;
		internal PyramidUserControl _pyramidUserControl;
		internal RadioButton _radioButtonPyramida;
		internal RadioButton _radioButtonBall;
		internal RadioButton _radioButtonParallelepiped;
	}
}