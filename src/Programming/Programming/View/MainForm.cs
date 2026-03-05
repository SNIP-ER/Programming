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
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;

        public MainForm()
        {
            InitializeComponent();

            EnumsListBox.SelectedIndex = 0;  // Изначально выбран 1-ый элемент в EnumsListBox.
            SeasonComboBox.SelectedIndex = 0;  // Изначально выбран 1-ый элемент в SeasonComboBox.

            Random random = new Random();

            _rectangles = new Rectangle[5];

            _rectangles[0] = new Rectangle(random.Next(0, 100), random.Next(0, 100), "Blue");
            _rectangles[1] = new Rectangle(random.Next(0, 100), random.Next(0, 100), "Green");
            _rectangles[2] = new Rectangle(random.Next(0, 100), random.Next(0, 100), "Red");
            _rectangles[3] = new Rectangle(random.Next(0, 100), random.Next(0, 100), "Yellow");
            _rectangles[4] = new Rectangle(random.Next(0, 100), random.Next(0, 100), "Navy");
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

        /// <summary>
        /// Кастомизация окна программы в зависимости от выбраного времени года.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.Text)
            {
                case "Default":
                this.BackColor = ColorTranslator.FromHtml("#f0f0f0");
                EnumsTabControl.BackColor = ColorTranslator.FromHtml("#fff");
                EnumsListBox.BackColor = ColorTranslator.FromHtml("#fff");
                ValuesListBox.BackColor = ColorTranslator.FromHtml("#fff");
                ValueTextBox.BackColor = ColorTranslator.FromHtml("#e1e1e1");
                ParseTextBox.BackColor = ColorTranslator.FromHtml("#fff");
                SeasonComboBox.BackColor = ColorTranslator.FromHtml("#fff");
                ParseButton.BackColor = ColorTranslator.FromHtml("#e1e1e1");
                SeasonButton.BackColor = ColorTranslator.FromHtml("#e1e1e1");
                break;

                case "Spring":
                this.BackColor = ColorTranslator.FromHtml("#559c45");
                EnumsTabControl.BackColor = ColorTranslator.FromHtml("#83c973");
                EnumsListBox.BackColor = ColorTranslator.FromHtml("#b1e3a6");
                ValuesListBox.BackColor = ColorTranslator.FromHtml("#b1e3a6");
                ValueTextBox.BackColor = ColorTranslator.FromHtml("#b1e3a6");
                ParseTextBox.BackColor = ColorTranslator.FromHtml("#b1e3a6");
                SeasonComboBox.BackColor = ColorTranslator.FromHtml("#b1e3a6");
                ParseButton.BackColor = ColorTranslator.FromHtml("#dce87d");
                SeasonButton.BackColor = ColorTranslator.FromHtml("#dce87d");
                break;

                case "Autumn":
                this.BackColor = ColorTranslator.FromHtml("#e29c45");
                EnumsTabControl.BackColor = ColorTranslator.FromHtml("#e3b781");
                EnumsListBox.BackColor = ColorTranslator.FromHtml("#e3b781");
                ValuesListBox.BackColor = ColorTranslator.FromHtml("#e3b781");
                ValueTextBox.BackColor = ColorTranslator.FromHtml("#e3b781");
                ParseTextBox.BackColor = ColorTranslator.FromHtml("#e3b781");
                SeasonComboBox.BackColor = ColorTranslator.FromHtml("#e3b781");
                ParseButton.BackColor = ColorTranslator.FromHtml("#d68594");
                SeasonButton.BackColor = ColorTranslator.FromHtml("#d68594");
                break;

                case "Summer":
                MessageBox.Show("Ура! Лето!", "Summer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;

                case "Winter":
                MessageBox.Show("Зима! Скоро Новый Год!", "Winter", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            }
        }



        /// <summary>
        /// Смена объекта в поле _currentRectangle на один из объектов из массива _rectangles.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];

            RectanglesLengthTextBox.Text = _currentRectangle.Length.ToString();
            RectanglesWidthTextBox.Text = _currentRectangle.Width.ToString();
            RectanglesColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        /// <summary>
        /// Изменение длины вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newLength = Convert.ToInt32(RectanglesLengthTextBox.Text);

                if (newLength >= 0)
                {
                    RectanglesLengthTextBox.BackColor = System.Drawing.Color.White;
                    _currentRectangle.Length = newLength;
                }
                else
                {
                    RectanglesLengthTextBox.Text = "";
                    MessageBox.Show("Длина не может быть отрицательной!", "Ошибка!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                RectanglesLengthTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно и нужно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение ширины вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int newWidth = Convert.ToInt32(RectanglesWidthTextBox.Text);

                if (newWidth >= 0)
                {
                    RectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
                    _currentRectangle.Width = newWidth;
                }
                else
                {
                    RectanglesWidthTextBox.Text = "";
                    MessageBox.Show("Длина не может быть отрицательной!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                RectanglesWidthTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно и нужно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение цвета вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = RectanglesColorTextBox.Text;
        }



        /// <summary>
        /// Находит прямоугольник с наиболшей шириной.
        /// </summary>
        /// <param name="_rectangles">Массив прямоугольников.</param>
        /// <returns>Индекс прямоугольника с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(Rectangle[] _rectangles)
        {
            int maxWidth = 0;
            int maxIndex = 0;

            for (int i = 0; i < _rectangles.Length - 1; i++)
            {
                if (_rectangles[i].Width > maxWidth)
                {
                    maxWidth = _rectangles[i].Width;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        /// <summary>
        /// Обработка нажатия на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
