using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Classes
{
    public partial class GroupBoxMovies : UserControl
    {
        private Film[] _films;
        private Film _currentFilm;

        public GroupBoxMovies()
        {
            InitializeComponent();

            _films = new Film[5];

            _films[0] = new Film(2018, 8.1, "Мстители: Война бесконечности", "Боевик/Научная фантастика", 149);
            _films[1] = new Film(1979, 8.7, "Москва слезам не верит", "Комедия/Романтика", 150);
            _films[2] = new Film(2011, 9, "1+1", "Комедия/Драма", 112);
            _films[3] = new Film(2013, 7.2, "Сталинград", "Военный/Боевик", 131);
            _films[4] = new Film(2003, 8.1, "Бумер", "Криминал/Боевик", 110);
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
                FilmRatingTextBox.BackColor = ColorTranslator.FromHtml(AppColors._error);
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
                FilmYearTextBox.BackColor = ColorTranslator.FromHtml(AppColors._error);
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
                FilmDurationTextBox.BackColor = ColorTranslator.FromHtml(AppColors._error);
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
    }
}
