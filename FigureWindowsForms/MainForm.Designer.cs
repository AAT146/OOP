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
			this._groupBoxCalculator = new System.Windows.Forms.GroupBox();
			this._dataGridView = new System.Windows.Forms.DataGridView();
			this._groupBoxButton = new System.Windows.Forms.GroupBox();
			this._buttonDeleteList = new System.Windows.Forms.Button();
			this._buttonResertFilter = new System.Windows.Forms.Button();
			this._buttonDelete = new System.Windows.Forms.Button();
			this._buttonRandom = new System.Windows.Forms.Button();
			this._buttonFilter = new System.Windows.Forms.Button();
			this._buttonAdd = new System.Windows.Forms.Button();
			this._toolStrip = new System.Windows.Forms.ToolStrip();
			this._toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this._toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this._toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this._groupBoxCalculator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
			this._groupBoxButton.SuspendLayout();
			this._toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _groupBoxCalculator
			// 
			this._groupBoxCalculator.Controls.Add(this._dataGridView);
			this._groupBoxCalculator.Location = new System.Drawing.Point(12, 30);
			this._groupBoxCalculator.Margin = new System.Windows.Forms.Padding(2);
			this._groupBoxCalculator.Name = "_groupBoxCalculator";
			this._groupBoxCalculator.Padding = new System.Windows.Forms.Padding(2);
			this._groupBoxCalculator.Size = new System.Drawing.Size(776, 305);
			this._groupBoxCalculator.TabIndex = 0;
			this._groupBoxCalculator.TabStop = false;
			// 
			// _dataGridView
			// 
			this._dataGridView.AllowUserToOrderColumns = true;
			this._dataGridView.AllowUserToResizeColumns = false;
			this._dataGridView.AllowUserToResizeRows = false;
			this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._dataGridView.Location = new System.Drawing.Point(6, 14);
			this._dataGridView.Margin = new System.Windows.Forms.Padding(2);
			this._dataGridView.Name = "_dataGridView";
			this._dataGridView.RowHeadersWidth = 51;
			this._dataGridView.RowTemplate.Height = 24;
			this._dataGridView.Size = new System.Drawing.Size(764, 283);
			this._dataGridView.TabIndex = 0;
			// 
			// _groupBoxButton
			// 
			this._groupBoxButton.Controls.Add(this._buttonDeleteList);
			this._groupBoxButton.Controls.Add(this._buttonResertFilter);
			this._groupBoxButton.Controls.Add(this._buttonDelete);
			this._groupBoxButton.Controls.Add(this._buttonRandom);
			this._groupBoxButton.Controls.Add(this._buttonFilter);
			this._groupBoxButton.Controls.Add(this._buttonAdd);
			this._groupBoxButton.Location = new System.Drawing.Point(12, 341);
			this._groupBoxButton.Name = "_groupBoxButton";
			this._groupBoxButton.Size = new System.Drawing.Size(776, 97);
			this._groupBoxButton.TabIndex = 1;
			this._groupBoxButton.TabStop = false;
			// 
			// _buttonDeleteList
			// 
			this._buttonDeleteList.Location = new System.Drawing.Point(549, 58);
			this._buttonDeleteList.Name = "_buttonDeleteList";
			this._buttonDeleteList.Size = new System.Drawing.Size(221, 31);
			this._buttonDeleteList.TabIndex = 5;
			this._buttonDeleteList.Text = "Очистить список";
			this._buttonDeleteList.UseVisualStyleBackColor = true;
			this._buttonDeleteList.Click += new System.EventHandler(this.ButtonDeleteListClick);
			// 
			// _buttonResertFilter
			// 
			this._buttonResertFilter.Location = new System.Drawing.Point(279, 58);
			this._buttonResertFilter.Name = "_buttonResertFilter";
			this._buttonResertFilter.Size = new System.Drawing.Size(221, 31);
			this._buttonResertFilter.TabIndex = 4;
			this._buttonResertFilter.Text = "Сбросить фильтр";
			this._buttonResertFilter.UseVisualStyleBackColor = true;
			this._buttonResertFilter.Click += new System.EventHandler(this.ButtonResertFilterClick);
			// 
			// _buttonDelete
			// 
			this._buttonDelete.Location = new System.Drawing.Point(6, 58);
			this._buttonDelete.Name = "_buttonDelete";
			this._buttonDelete.Size = new System.Drawing.Size(221, 31);
			this._buttonDelete.TabIndex = 3;
			this._buttonDelete.Text = "Удалить фигуру";
			this._buttonDelete.UseVisualStyleBackColor = true;
			this._buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// _buttonRandom
			// 
			this._buttonRandom.Location = new System.Drawing.Point(549, 14);
			this._buttonRandom.Name = "_buttonRandom";
			this._buttonRandom.Size = new System.Drawing.Size(221, 31);
			this._buttonRandom.TabIndex = 6;
			this._buttonRandom.Text = "Случайная фигура";
			this._buttonRandom.Click += new System.EventHandler(this.ButtonRandomClick);
			// 
			// _buttonFilter
			// 
			this._buttonFilter.Location = new System.Drawing.Point(279, 14);
			this._buttonFilter.Name = "_buttonFilter";
			this._buttonFilter.Size = new System.Drawing.Size(221, 31);
			this._buttonFilter.TabIndex = 1;
			this._buttonFilter.Text = "Фильтр";
			this._buttonFilter.UseVisualStyleBackColor = true;
			this._buttonFilter.Click += new System.EventHandler(this.ButtonFilterClick);
			// 
			// _buttonAdd
			// 
			this._buttonAdd.Location = new System.Drawing.Point(6, 14);
			this._buttonAdd.Name = "_buttonAdd";
			this._buttonAdd.Size = new System.Drawing.Size(221, 31);
			this._buttonAdd.TabIndex = 0;
			this._buttonAdd.Text = "Добавить фигуру";
			this._buttonAdd.UseVisualStyleBackColor = true;
			this._buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
			// 
			// _toolStrip
			// 
			this._toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripDropDownButton1});
			this._toolStrip.Location = new System.Drawing.Point(0, 0);
			this._toolStrip.Name = "_toolStrip";
			this._toolStrip.Size = new System.Drawing.Size(800, 27);
			this._toolStrip.TabIndex = 2;
			this._toolStrip.Text = "toolStrip";
			// 
			// _toolStripDropDownButton1
			// 
			this._toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripMenuItem1,
            this._toolStripMenuItem2});
			this._toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("_toolStripDropDownButton1.Image")));
			this._toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._toolStripDropDownButton1.Name = "_toolStripDropDownButton1";
			this._toolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
			this._toolStripDropDownButton1.Text = "Файл";
			// 
			// _toolStripMenuItem1
			// 
			this._toolStripMenuItem1.Name = "_toolStripMenuItem1";
			this._toolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
			this._toolStripMenuItem1.Text = "Сохранить";
			this._toolStripMenuItem1.Click += new System.EventHandler(this.SaveToolStripMenuItem1);
			// 
			// _toolStripMenuItem2
			// 
			this._toolStripMenuItem2.Name = "_toolStripMenuItem2";
			this._toolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
			this._toolStripMenuItem2.Text = "Загрузить";
			this._toolStripMenuItem2.Click += new System.EventHandler(this.OpenToolStripMenuItem2);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this._groupBoxCalculator);
			this.Controls.Add(this._toolStrip);
			this.Controls.Add(this._groupBoxButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Объем фигур";
			this.Load += new System.EventHandler(this.LoadMainForm);
			this._groupBoxCalculator.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
			this._groupBoxButton.ResumeLayout(false);
			this._toolStrip.ResumeLayout(false);
			this._toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

#endregion

		private GroupBox _groupBoxButton;
		private Button _buttonAdd;
		private Button _buttonDeleteList;
		private Button _buttonResertFilter;
		private Button _buttonDelete;
		private Button _buttonFilter;
		private DataGridView _dataGridView;
		private ToolStrip _toolStrip;
		private GroupBox _groupBoxCalculator;

		private ToolStripMenuItem _toolStripMenuItem1;
		private ToolStripMenuItem _toolStripMenuItem2;
		private ToolStripDropDownButton _toolStripDropDownButton1;
		private Button _buttonRandom;
	}
}