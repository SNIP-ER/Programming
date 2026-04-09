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
    public partial class GroupBoxRectangles : UserControl
    {
        private RectangleClasses[] _rectanglesClasses;
        private RectangleClasses _currentRectangleClasses;

        public GroupBoxRectangles()
        {
            InitializeComponent();

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
                RectanglesLengthTextBox.BackColor = System.Drawing.Color.FromArgb(AppColors._white);
            }
            catch
            {
                RectanglesLengthTextBox.BackColor = ColorTranslator.FromHtml(AppColors._error);
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
                RectanglesWidthTextBox.BackColor = System.Drawing.Color.FromArgb(AppColors._white);
            }
            catch
            {
                RectanglesWidthTextBox.BackColor = ColorTranslator.FromHtml(AppColors._error);
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
    }
}
