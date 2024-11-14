using Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FigureWindowsForms
{
	public partial class MainForm : Form
	{
		/// <summary>
		/// Список объемов фигур.
		/// </summary>
		private BindingList<FigureBase> _volumeFigureList = new BindingList<FigureBase>();

		/// <summary>
		/// Список отфильтрованных объемов фигур.
		/// </summary>
		private BindingList<FigureBase> _filterVolumeFigureList = new BindingList<FigureBase>();

		/// <summary>
		/// Для файлов.
		/// </summary>
		private readonly XmlSerializer _serializer =
			new XmlSerializer(typeof(BindingList<FigureBase>));

		/// <summary>
		/// Поле для хранения состояния формы добавления.
		/// </summary>
		private bool _isAddFormOpen = false;

		/// <summary>
		/// Поле для хранения состояния формы фильтра.
		/// </summary>
		private bool _isFilterFormOpen = false;

		/// <summary>
		/// Поле для хранения состояния фильтрации.
		/// </summary>
		private bool _isFilter = false;

		/// <summary>
		/// Конструктор MainForm.
		/// </summary>
		public MainForm()
		{
			InitializeComponent();
			BackColor = Color.AliceBlue;
			dataGridView.BackgroundColor = Color.LightGray;
			StartPosition = FormStartPosition.CenterScreen;
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
		{

		}
	}
}
