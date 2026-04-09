using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Enums
{
    public partial class GroupBoxWeekdayParsing : UserControl
    {
        public GroupBoxWeekdayParsing()
        {
            InitializeComponent();
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
