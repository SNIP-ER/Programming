using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            EnumsListBox.SelectedIndex = 0;  // Изначально выбран 1-ый элемент в EnumsListBox.
        }

        /// <summary>
        /// Показывает элементы в ValuesListBox, в зависимости от выбраного элемента в EnumsListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Color":
                ValuesListBox.DataSource = Enum.GetValues(typeof(Color));
                break;

                case "EducationForm":
                ValuesListBox.DataSource = Enum.GetValues(typeof(EducationForm));
                break;

                case "Genre":
                ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                break;

                case "Manufactures":
                ValuesListBox.DataSource = Enum.GetValues(typeof(Manufactures));
                break;

                case "Season":
                ValuesListBox.DataSource = Enum.GetValues(typeof(Season));
                break;

                case "Weekday":
                ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                break;
            }
        }

        /// <summary>
        /// Пишет в ValueTextBox индекс выбранного элемента в ValueListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }

        /// <summary>
        /// Парсинг дней недели.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            // true - игнорировать регистр.
            if (Enum.TryParse(ParseTextBox.Text, true, out Weekday weekday))
            {
                switch (weekday)
                {
                    case Weekday.Monday:
                    DayLabel.Text = $"Это день недели (Monday = {(int)weekday})";
                    break;

                    case Weekday.Tuesday:
                    DayLabel.Text = $"Это день недели (Tuesday = {(int)weekday})";
                    break;

                    case Weekday.Wednesday:
                    DayLabel.Text = $"Это день недели (Wednesday = {(int)weekday})";
                    break;

                    case Weekday.Thursday:
                    DayLabel.Text = $"Это день недели (Thursday = {(int)weekday})";
                    break;

                    case Weekday.Friday:
                    DayLabel.Text = $"Это день недели (Friday = {(int)weekday})";
                    break;

                    case Weekday.Saturday:
                    DayLabel.Text = $"Это день недели (Saturday = {(int)weekday})";
                    break;

                    case Weekday.Sunday:
                    DayLabel.Text = $"Это день недели (Sunday = {(int)weekday})";
                    break;
                }
            }

            else
            {
                DayLabel.Text = "Нет такого дня недели";
            }
        }
    }
}
