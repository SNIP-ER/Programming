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
        private RectangleClasses[] _rectanglesClasses;
        private RectangleClasses _currentRectangleClasses;

        private Film[] _films;
        private Film _currentFilm;

        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;
        private List<Panel> _rectanglePanles;

        public MainForm()
        {
            InitializeComponent();

            EnumsListBox.SelectedIndex = 0;  // Изначально выбран 1-ый элемент в EnumsListBox.
            SeasonComboBox.SelectedIndex = 0;  // Изначально выбран 1-ый элемент в SeasonComboBox.

            Random random = new Random();


            _rectanglesClasses = new RectangleClasses[5];

            _rectanglesClasses[0] = new RectangleClasses(random.Next(0, 100), random.Next(0, 100), "Blue", 
                new Point2D(random.Next(-100, 100), random.Next(-100, 100)));
            _rectanglesClasses[1] = new RectangleClasses(random.Next(0, 100), random.Next(0, 100), "Green",
                new Point2D(random.Next(-100, 100), random.Next(-100, 100)));
            _rectanglesClasses[2] = new RectangleClasses(random.Next(0, 100), random.Next(0, 100), "Red",
                new Point2D(random.Next(-100, 100), random.Next(-100, 100)));
            _rectanglesClasses[3] = new RectangleClasses(random.Next(0, 100), random.Next(0, 100), "Yellow",
                new Point2D(random.Next(-100, 100), random.Next(-100, 100)));
            _rectanglesClasses[4] = new RectangleClasses(random.Next(0, 100), random.Next(0, 100), "Navy",
                new Point2D(random.Next(-100, 100), random.Next(-100, 100)));


            _films = new Film[5];

            _films[0] = new Film(2018, 8.1, "Мстители: Война бесконечности", "Боевик/Научная фантастика", 149);
            _films[1] = new Film(1979, 8.7, "Москва слезам не верит", "Комедия/Романтика", 150);
            _films[2] = new Film(2011, 9, "1+1", "Комедия/Драма", 112);
            _films[3] = new Film(2013, 7.2, "Сталинград", "Военный/Боевик", 131);
            _films[4] = new Film(2003, 8.1, "Бумер", "Криминал/Боевик", 110);
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
        private void ClassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangleClasses = _rectanglesClasses[ClassesRectanglesListBox.SelectedIndex];

            RectanglesLengthTextBox.Text = _currentRectangleClasses.Length.ToString();
            RectanglesWidthTextBox.Text = _currentRectangleClasses.Width.ToString();
            RectanglesColorTextBox.Text = _currentRectangleClasses.Color.ToString();
            RectangleXTextBox.Text = _currentRectangleClasses.Center.StoreX.ToString();
            RectangleYTextBox.Text = _currentRectangleClasses.Center.StoreY.ToString();
            RectangleIdTextBox.Text = _currentRectangleClasses.Id.ToString();
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
                _currentRectangleClasses.Length = float.Parse(RectanglesLengthTextBox.Text);
                RectanglesLengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RectanglesLengthTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры и , !", "Ошибка!",
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
                _currentRectangleClasses.Width = float.Parse(RectanglesWidthTextBox.Text);
                RectanglesWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                RectanglesWidthTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры и , !", "Ошибка!",
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
            _currentRectangleClasses.Color = RectanglesColorTextBox.Text;
        }

        /// <summary>
        /// Находит прямоугольник с наиболшей шириной.
        /// </summary>
        /// <param name="_rectangles">Массив прямоугольников.</param>
        /// <returns>Индекс прямоугольника с наибольшей шириной.</returns>
        private int FindRectangleWithMaxWidth(RectangleClasses[] _rectangles)
        {
            float maxWidth = 0;
            int maxIndex = 0;

            for (int i = 0; i < _rectangles.Length; i++)
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
            ClassesRectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectanglesClasses);
        }



        /// <summary>
        /// Смена объекта в поле _currentFilm на один из объектов из массива _films.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];

            FilmNameTextBox.Text = _currentFilm.Name.ToString();
            FilmGenreTextBox.Text = _currentFilm.Genre.ToString();
            FilmRatingTextBox.Text = _currentFilm.Rating.ToString();
            FilmYearTextBox.Text = _currentFilm.Year.ToString();
            FilmDurationTextBox.Text = _currentFilm.Duration.ToString();
        }

        /// <summary>
        /// Изменение названия вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = FilmNameTextBox.Text;
        }

        /// <summary>
        /// Изменение жанра вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = FilmGenreTextBox.Text;
        }

        /// <summary>
        /// Изменение рейтинга вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Rating = Convert.ToDouble(FilmRatingTextBox.Text);
                FilmRatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                FilmRatingTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры и , !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение года вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Year = Convert.ToInt32(FilmYearTextBox.Text);
                FilmYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                FilmYearTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Изменение продолжительности вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilmDurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Duration = Convert.ToInt32(FilmDurationTextBox.Text);
                FilmDurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                FilmDurationTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Находит фильм с наиболшим рейтингом.
        /// </summary>
        /// <param name="_films">Массив фильмов.</param>
        /// <returns>Индекс фильма с наибольшим рейтингом.</returns>
        private int FindFilmWithMaxRating(Film[] _films)
        {
            double maxRating = 0;
            int maxIndex = 0;

            for (int i = 0; i < _films.Length; i++)
            {
                if (_films[i].Rating > maxRating)
                {
                    maxRating = _films[i].Rating;
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
        private void FilmFindButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }



        /// <summary>
        /// Добавление прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButtonAdd_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Rectangle rectangle = new Rectangle(random.Next(0, 100), random.Next(0, 100),
                new Point2D(random.Next(0, 530), random.Next(0, 390)));

            _rectangles.Add(rectangle);

            RectanglesListBox.Items.Add($"{_rectangles.Count}: (X = {rectangle.Center.StoreX}; " +
                $"Y = {rectangle.Center.StoreY}; W = {rectangle.Width}; H = {rectangle.Height})");

            // создание новой панели
            Panel newRectangle = new Panel();
            newRectangle.Location = new Point(rectangle.Center.StoreX, rectangle.Center.StoreY);
            newRectangle.Size = new Size(rectangle.Width, rectangle.Height);
            newRectangle.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);

            RectanglesPanel.Controls.Add(newRectangle);     // отображение новой панели
        }

        /// <summary>
        /// Удаление выбранного прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButtonRemove_Click(object sender, EventArgs e)
        {
            int index = RectanglesListBox.SelectedIndex;

            if (index != -1)
            {
                _rectangles.RemoveAt(index);

                RectanglesListBox.Items.RemoveAt(index);
            }
            else
            {
                // если не выбран - ничего не происходит
            }
        }

        /// <summary>
        /// Заполнение полей ниже списка при выборе прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                RectanglesTextBoxId.Text = _currentRectangle.Id.ToString();
                RectanglesTextBoxX.Text = _currentRectangle.Center.StoreX.ToString();
                RectanglesTextBoxY.Text = _currentRectangle.Center.StoreY.ToString();
                RectanglesTextBoxWidth.Text = _currentRectangle.Width.ToString();
                RectanglesTextBoxHeight.Text = _currentRectangle.Height.ToString();

                // сброс цвета окошка для ввода при переключении между прямоугольниками
                RectanglesTextBoxX.BackColor = System.Drawing.Color.White;
                RectanglesTextBoxY.BackColor = System.Drawing.Color.White;
                RectanglesTextBoxWidth.BackColor = System.Drawing.Color.White;
                RectanglesTextBoxHeight.BackColor = System.Drawing.Color.White;
            }
            else
            {
                RectanglesTextBoxId.Text = "";
                RectanglesTextBoxX.Text = "";
                RectanglesTextBoxY.Text = "";
                RectanglesTextBoxWidth.Text = "";
                RectanglesTextBoxHeight.Text = "";
            }
        }

        /// <summary>
        /// Обновление строки в ListBox.
        /// </summary>
        private void ReplaceLineInListBox()
        {
            RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = $"{_currentRectangle.Id}: (X = {_currentRectangle.Center.StoreX}; " +
                $"Y = {_currentRectangle.Center.StoreY}; W = {_currentRectangle.Width}; H = {_currentRectangle.Height})";
        }

        /// <summary>
        /// Регистрация ухода с поля X, с дальнейшей проверкой на корректность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesTextBoxX_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(RectanglesTextBoxX.Text, out int newX))
            {
                RectanglesTextBoxX.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Validator.AssertValueInRangePanel(int.Parse(RectanglesTextBoxX.Text), 530) == false)
            {
                RectanglesTextBoxX.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры от 0 до 530!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Center.StoreX = newX;
                ReplaceLineInListBox();
                RectanglesTextBoxX.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Регистрация ухода с поля Y, с дальнейшей проверкой на корректность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesTextBoxY_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(RectanglesTextBoxY.Text, out int newY))
            {
                RectanglesTextBoxY.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Validator.AssertValueInRangePanel(int.Parse(RectanglesTextBoxY.Text), 390) == false)
            {
                RectanglesTextBoxY.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры от 0 до 390!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Center.StoreY = newY;
                ReplaceLineInListBox();
                RectanglesTextBoxY.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Регистрация ухода с поля Width, с дальнейшей проверкой на корректность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesTextBoxWidth_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(RectanglesTextBoxWidth.Text, out int newWidth))
            {
                RectanglesTextBoxWidth.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Width = newWidth;
                ReplaceLineInListBox();
                RectanglesTextBoxWidth.BackColor = System.Drawing.Color.White;
            }
        }

        /// <summary>
        /// Регистрация ухода с поля Height, с дальнейшей проверкой на корректность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesTextBoxHeight_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(RectanglesTextBoxHeight.Text, out int newHeight))
            {
                RectanglesTextBoxHeight.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Height = newHeight;
                ReplaceLineInListBox();
                RectanglesTextBoxHeight.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
