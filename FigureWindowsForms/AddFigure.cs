using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureWindowsForms
{
	public partial class AddFigure : Form
	{
		/// <summary>
		/// Поле для обработки события добавления.
		/// </summary>
		public EventHandler FigureAdded;

		/// <summary>
		/// Конструктор AddSalary.
		/// </summary>
		public AddFigure()
		{
			InitializeComponent();
			BackColor = Color.AliceBlue;
			StartPosition = FormStartPosition.CenterScreen;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;

			figureBallUserControl._textBoxHourlyRate.Tag = typeof(double);
			_salaryMonthlyUserControl._textBoxFixedSalary.Tag = typeof(double);
			_salaryMonthlyUserControl._textBoxMonthlyWorkingDays.Tag = typeof(int);
			_salaryMonthlyUserControl._textBoxActualWorkedDays.Tag = typeof(int);
			_salaryTariffRateUserControl._textBoxTariffRate.Tag = typeof(double);
			_salaryTariffRateUserControl._textBoxDays.Tag = typeof(int);

			_salaryHourlyRateUserControl._textBoxHourlyRate.KeyPress += new
				KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

			_salaryHourlyRateUserControl._textBoxHours.KeyPress += new
				KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

			_salaryMonthlyUserControl._textBoxFixedSalary.KeyPress += new
				KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

			_salaryMonthlyUserControl._textBoxMonthlyWorkingDays.KeyPress += new
				KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

			_salaryMonthlyUserControl._textBoxActualWorkedDays.KeyPress += new
				KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

			_salaryTariffRateUserControl._textBoxTariffRate.KeyPress += new
				KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);

			_salaryTariffRateUserControl._textBoxDays.KeyPress += new
				KeyPressEventHandler(TextBoxHandler.TextBoxKeyPress);
		}

		/// <summary>
		/// Загрузка формы часовой тарифной ставки.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ChangeSalaryHourlyRate(object sender, EventArgs e)
		{
			_salaryHourlyRateUserControl.Visible = true;
			_salaryMonthlyUserControl.Visible = false;
			_salaryTariffRateUserControl.Visible = false;
		}

		/// <summary>
		/// Загрузка формы оклада за месяц.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ChangeSalaryMonthly(object sender, EventArgs e)
		{
			_salaryHourlyRateUserControl.Visible = false;
			_salaryMonthlyUserControl.Visible = true;
			_salaryTariffRateUserControl.Visible = false;
		}

		/// <summary>
		/// Загрузка формы тарифной ставки.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ChangeSalaryTariffRate(object sender, EventArgs e)
		{
			_salaryHourlyRateUserControl.Visible = false;
			_salaryMonthlyUserControl.Visible = false;
			_salaryTariffRateUserControl.Visible = true;
		}

		/// <summary>
		/// Кнопка закрыть.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickButtonClose(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Кнопка добавить.
		/// </summary>
		/// <param name="sender">Данные.</param>
		/// <param name="e">Данные о событие.</param>
		private void ClickButtonAdd(object sender, EventArgs e)
		{
			try
			{
				SalaryBase salaryBase = null;

				if (_salaryHourlyRateUserControl.Visible)
				{
					salaryBase = new SalaryHourlyRate()
					{
						HourlyRate = Convert.ToDouble(
							_salaryHourlyRateUserControl._textBoxHourlyRate.Text),
						Hours = Convert.ToInt32(
							_salaryHourlyRateUserControl._textBoxHours.Text),
					};
				}

				if (_salaryMonthlyUserControl.Visible)
				{
					salaryBase = new SalaryMonthly()
					{
						FixedSalary = Convert.ToDouble(
							_salaryMonthlyUserControl._textBoxFixedSalary.Text),
						MonthlyWorkingDays = Convert.ToInt32(
							_salaryMonthlyUserControl._textBoxMonthlyWorkingDays.Text),
						ActualWorkedDays = Convert.ToInt32(
							_salaryMonthlyUserControl._textBoxActualWorkedDays.Text),
					};
				}

				if (_salaryTariffRateUserControl.Visible)
				{
					salaryBase = new SalaryTariffRate()
					{
						TariffRate = Convert.ToDouble(
							_salaryTariffRateUserControl._textBoxTariffRate.Text),
						Days = Convert.ToInt32(
							_salaryTariffRateUserControl._textBoxDays.Text),
					};
				}

				SalaryAdded?.Invoke(this, new SalaryAddedEvent(salaryBase));
			}
			catch (ArgumentOutOfRangeException exeption)
			{
				MessageBox.Show($"{exeption.Message}", "Предупреждение",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			catch
			{
				MessageBox.Show("Введите данные.", "Предупреждение",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		public AddFigure()
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{

		}
	}
}
