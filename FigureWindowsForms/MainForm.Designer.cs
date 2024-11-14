using System.Windows.Forms;

namespace FigureWindowsForms
{
	partial class MainForm
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
			this.groupBoxCalculator = new System.Windows.Forms.GroupBox();
			this.groupBoxButton = new System.Windows.Forms.GroupBox();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonFilter = new System.Windows.Forms.Button();
			this.buttonRandomList = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonResertFilter = new System.Windows.Forms.Button();
			this.buttonDeleteList = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.groupBoxCalculator.SuspendLayout();
			this.groupBoxButton.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxCalculator
			// 
			this.groupBoxCalculator.Controls.Add(this.dataGridView);
			this.groupBoxCalculator.Location = new System.Drawing.Point(12, 30);
			this.groupBoxCalculator.Name = "groupBoxCalculator";
			this.groupBoxCalculator.Size = new System.Drawing.Size(776, 305);
			this.groupBoxCalculator.TabIndex = 0;
			this.groupBoxCalculator.TabStop = false;
			this.groupBoxCalculator.Text = "groupBoxCalculator";
			this.groupBoxCalculator.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// groupBoxButton
			// 
			this.groupBoxButton.Controls.Add(this.buttonDeleteList);
			this.groupBoxButton.Controls.Add(this.buttonResertFilter);
			this.groupBoxButton.Controls.Add(this.buttonDelete);
			this.groupBoxButton.Controls.Add(this.buttonRandomList);
			this.groupBoxButton.Controls.Add(this.buttonFilter);
			this.groupBoxButton.Controls.Add(this.buttonAdd);
			this.groupBoxButton.Location = new System.Drawing.Point(12, 341);
			this.groupBoxButton.Name = "groupBoxButton";
			this.groupBoxButton.Size = new System.Drawing.Size(776, 97);
			this.groupBoxButton.TabIndex = 1;
			this.groupBoxButton.TabStop = false;
			this.groupBoxButton.Text = "groupBoxButton";
			this.groupBoxButton.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(6, 14);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(221, 31);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Добавить строку";
			this.buttonAdd.UseVisualStyleBackColor = true;
			// 
			// buttonFilter
			// 
			this.buttonFilter.Location = new System.Drawing.Point(279, 14);
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Size = new System.Drawing.Size(221, 31);
			this.buttonFilter.TabIndex = 1;
			this.buttonFilter.Text = "Фильтр";
			this.buttonFilter.UseVisualStyleBackColor = true;
			// 
			// buttonRandomList
			// 
			this.buttonRandomList.Location = new System.Drawing.Point(549, 14);
			this.buttonRandomList.Name = "buttonRandomList";
			this.buttonRandomList.Size = new System.Drawing.Size(221, 31);
			this.buttonRandomList.TabIndex = 2;
			this.buttonRandomList.Text = "Случайный список";
			this.buttonRandomList.UseVisualStyleBackColor = true;
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(6, 58);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(221, 31);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "Удалить строку";
			this.buttonDelete.UseVisualStyleBackColor = true;
			// 
			// buttonResertFilter
			// 
			this.buttonResertFilter.Location = new System.Drawing.Point(279, 58);
			this.buttonResertFilter.Name = "buttonResertFilter";
			this.buttonResertFilter.Size = new System.Drawing.Size(221, 31);
			this.buttonResertFilter.TabIndex = 4;
			this.buttonResertFilter.Text = "Сбросить фильтр";
			this.buttonResertFilter.UseVisualStyleBackColor = true;
			// 
			// buttonDeleteList
			// 
			this.buttonDeleteList.Location = new System.Drawing.Point(549, 58);
			this.buttonDeleteList.Name = "buttonDeleteList";
			this.buttonDeleteList.Size = new System.Drawing.Size(221, 31);
			this.buttonDeleteList.TabIndex = 5;
			this.buttonDeleteList.Text = "Очистить список";
			this.buttonDeleteList.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(6, 14);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(764, 283);
			this.dataGridView.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(800, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBoxButton);
			this.Controls.Add(this.groupBoxCalculator);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.groupBoxCalculator.ResumeLayout(false);
			this.groupBoxButton.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		/// <summary>
		/// 
		/// </summary>
		private GroupBox groupBoxCalculator;
		private GroupBox groupBoxButton;
		private Button buttonAdd;
		private Button buttonDeleteList;
		private Button buttonResertFilter;
		private Button buttonDelete;
		private Button buttonRandomList;
		private Button buttonFilter;
		private DataGridView dataGridView;
		private ToolStrip toolStrip1;
	}
}