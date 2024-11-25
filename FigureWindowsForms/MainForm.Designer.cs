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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.groupBoxCalculator = new System.Windows.Forms.GroupBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.groupBoxButton = new System.Windows.Forms.GroupBox();
			this.buttonDeleteList = new System.Windows.Forms.Button();
			this.buttonResertFilter = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonRandomList = new System.Windows.Forms.Button();
			this.buttonFilter = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBoxCalculator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.groupBoxButton.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxCalculator
			// 
			this.groupBoxCalculator.Controls.Add(this.dataGridView);
			this.groupBoxCalculator.Location = new System.Drawing.Point(12, 30);
			this.groupBoxCalculator.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxCalculator.Name = "groupBoxCalculator";
			this.groupBoxCalculator.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxCalculator.Size = new System.Drawing.Size(776, 305);
			this.groupBoxCalculator.TabIndex = 0;
			this.groupBoxCalculator.TabStop = false;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(6, 14);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowHeadersWidth = 51;
			this.dataGridView.RowTemplate.Height = 24;
			this.dataGridView.Size = new System.Drawing.Size(764, 283);
			this.dataGridView.TabIndex = 0;
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
			// 
			// buttonDeleteList
			// 
			this.buttonDeleteList.Location = new System.Drawing.Point(549, 58);
			this.buttonDeleteList.Name = "buttonDeleteList";
			this.buttonDeleteList.Size = new System.Drawing.Size(221, 31);
			this.buttonDeleteList.TabIndex = 5;
			this.buttonDeleteList.Text = "Очистить список";
			this.buttonDeleteList.UseVisualStyleBackColor = true;
			this.buttonDeleteList.Click += new System.EventHandler(this.ButtonDeleteListClick);
			// 
			// buttonResertFilter
			// 
			this.buttonResertFilter.Location = new System.Drawing.Point(279, 58);
			this.buttonResertFilter.Name = "buttonResertFilter";
			this.buttonResertFilter.Size = new System.Drawing.Size(221, 31);
			this.buttonResertFilter.TabIndex = 4;
			this.buttonResertFilter.Text = "Сбросить фильтр";
			this.buttonResertFilter.UseVisualStyleBackColor = true;
			this.buttonResertFilter.Click += new System.EventHandler(this.ButtonResertFilterClick);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(6, 58);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(221, 31);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "Удалить фигуру";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonRandomList
			// 
			this.buttonRandomList.Location = new System.Drawing.Point(549, 14);
			this.buttonRandomList.Name = "buttonRandomList";
			this.buttonRandomList.Size = new System.Drawing.Size(221, 31);
			this.buttonRandomList.TabIndex = 2;
			this.buttonRandomList.Text = "Случайный список";
			this.buttonRandomList.UseVisualStyleBackColor = true;
			this.buttonRandomList.Click += new System.EventHandler(this.ButtonRandomListClick);
			// 
			// buttonFilter
			// 
			this.buttonFilter.Location = new System.Drawing.Point(279, 14);
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Size = new System.Drawing.Size(221, 31);
			this.buttonFilter.TabIndex = 1;
			this.buttonFilter.Text = "Фильтр";
			this.buttonFilter.UseVisualStyleBackColor = true;
			this.buttonFilter.Click += new System.EventHandler(this.ButtonFilterClick);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(6, 14);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(221, 31);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Добавить фигуру";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// toolStrip
			// 
			this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
			this.toolStripDropDownButton1.Text = "Файл";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem1.Text = "Сохранить";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem1);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
			this.toolStripMenuItem2.Text = "Загрузить";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.OpenToolStripMenuItem2);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.groupBoxCalculator);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.groupBoxButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Объем фигур";
			this.Load += new System.EventHandler(this.LoadMainForm);
			this.groupBoxCalculator.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.groupBoxButton.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox groupBoxButton;
		private Button buttonAdd;
		private Button buttonDeleteList;
		private Button buttonResertFilter;
		private Button buttonDelete;
		private Button buttonRandomList;
		private Button buttonFilter;
		private DataGridView dataGridView;
		private ToolStrip toolStrip;
		private GroupBox groupBoxCalculator;

		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem toolStripMenuItem2;
		private ToolStripDropDownButton toolStripDropDownButton1;
	}
}