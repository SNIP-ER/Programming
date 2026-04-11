using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles = new List<Rectangle>();
        private Rectangle _currentRectangle;
        private List<Panel> _rectanglePanles = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButtonAdd_Click(object sender, EventArgs e)
        {
            int canvasWidth = RectanglesPanel.Width;
            int canvasHeight = RectanglesPanel.Height;

            Rectangle rectangle = RectangleFactory.Randomize(canvasWidth, canvasHeight);

            _rectangles.Add(rectangle);

            RectanglesListBox.Items.Add($"{_rectangles.Count}: (X = {rectangle.Center.StoreX}; " +
                $"Y = {rectangle.Center.StoreY}; W = {rectangle.Width}; H = {rectangle.Height})");

            // создание новой панели
            Panel newRectangle = new Panel();
            newRectangle.Location = new Point((int)(rectangle.Center.StoreX - rectangle.Width / 2),
                (int)(rectangle.Center.StoreY - rectangle.Height / 2));
            newRectangle.Size = new Size((int)rectangle.Width, (int)rectangle.Height);

            _rectanglePanles.Add(newRectangle);     // сохранение нового прямоугольника
            RectanglesPanel.Controls.Add(newRectangle);     // отображение новой панели

            FindCollisions();
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

                // удаление прямоугольника
                _rectanglePanles.RemoveAt(index);
                RectanglesPanel.Controls.RemoveAt(index);

                FindCollisions();
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

                UpdateRectangleInfo(_currentRectangle);
            }
            else
            {
                ClearRectangleInfo();
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
                RectanglesTextBoxX.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Validator.AssertValueInRangePanel(int.Parse(RectanglesTextBoxX.Text), 530) == false)
            {
                RectanglesTextBoxX.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры от 0 до 530!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Center.StoreX = newX;
                ReplaceLineInListBox();
                RectanglesTextBoxX.BackColor = System.Drawing.Color.White;

                // Изменение прямоугольника
                Panel currentPanel = _rectanglePanles[RectanglesListBox.SelectedIndex];

                currentPanel.Location = new Point((int)(_currentRectangle.Center.StoreX - _currentRectangle.Width / 2),
                    (int)(_currentRectangle.Center.StoreY - _currentRectangle.Height / 2));
                currentPanel.Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Height);

                FindCollisions();    // снова проверяем на пересечение
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
                RectanglesTextBoxY.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Validator.AssertValueInRangePanel(int.Parse(RectanglesTextBoxY.Text), 390) == false)
            {
                RectanglesTextBoxY.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры от 0 до 390!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Center.StoreY = newY;
                ReplaceLineInListBox();
                RectanglesTextBoxY.BackColor = System.Drawing.Color.White;

                // Изменение прямоугольника
                Panel currentPanel = _rectanglePanles[RectanglesListBox.SelectedIndex];

                currentPanel.Location = new Point((int)(_currentRectangle.Center.StoreX - _currentRectangle.Width / 2),
                    (int)(_currentRectangle.Center.StoreY - _currentRectangle.Height / 2));
                currentPanel.Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Height);

                FindCollisions();    // снова проверяем на пересечение
            }
        }

        /// <summary>
        /// Регистрация ухода с поля Width, с дальнейшей проверкой на корректность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesTextBoxWidth_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(RectanglesTextBoxWidth.Text, out float newWidth))
            {
                RectanglesTextBoxWidth.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры и , !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Width = newWidth;
                ReplaceLineInListBox();
                RectanglesTextBoxWidth.BackColor = System.Drawing.Color.White;

                // Изменение прямоугольника
                Panel currentPanel = _rectanglePanles[RectanglesListBox.SelectedIndex];

                currentPanel.Location = new Point((int)(_currentRectangle.Center.StoreX - _currentRectangle.Width / 2),
                    (int)(_currentRectangle.Center.StoreY - _currentRectangle.Height / 2));
                currentPanel.Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Height);

                FindCollisions();    // снова проверяем на пересечение
            }
        }

        /// <summary>
        /// Регистрация ухода с поля Height, с дальнейшей проверкой на корректность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesTextBoxHeight_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(RectanglesTextBoxHeight.Text, out float newHeight))
            {
                RectanglesTextBoxHeight.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры и , !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _currentRectangle.Height = newHeight;
                ReplaceLineInListBox();
                RectanglesTextBoxHeight.BackColor = System.Drawing.Color.White;

                // Изменение прямоугольника
                Panel currentPanel = _rectanglePanles[RectanglesListBox.SelectedIndex];

                currentPanel.Location = new Point((int)(_currentRectangle.Center.StoreX - _currentRectangle.Width / 2),
                    (int)(_currentRectangle.Center.StoreY - _currentRectangle.Height / 2));
                currentPanel.Size = new Size((int)_currentRectangle.Width, (int)_currentRectangle.Height);

                FindCollisions();    // снова проверяем на пересечение
            }
        }

        /// <summary>
        /// Регистрация пересечения панелей.
        /// </summary>
        private void FindCollisions()
        {
            int count = _rectanglePanles.Count;

            // перекраска всех панелей
            for (int i = 0; i < count; i++)
            {
                _rectanglePanles[i].BackColor = System.Drawing.Color.FromArgb(AppColors._lightGreen);
                _rectanglePanles[i].BorderStyle = BorderStyle.FixedSingle;
            }

            // проверка пересечений
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    bool flag = CollisionManager.IsCollision(_rectangles[i], _rectangles[j]);

                    if (flag)
                    {
                        _rectanglePanles[i].BackColor = System.Drawing.Color.FromArgb(AppColors._lightRed);
                        _rectanglePanles[j].BackColor = System.Drawing.Color.FromArgb(AppColors._lightRed);
                        _rectanglePanles[i].BorderStyle = BorderStyle.None;
                        _rectanglePanles[j].BorderStyle = BorderStyle.None;
                    }
                }

                // утчет последнего из первого цикла и первого из второго цикла
                if (count > 2)
                {
                    bool flagFinish = CollisionManager.IsCollision(_rectangles[count - 1], _rectangles[0]);

                    if (flagFinish)
                    {
                        _rectanglePanles[count - 1].BackColor = System.Drawing.Color.FromArgb(AppColors._lightRed);
                        _rectanglePanles[0].BackColor = System.Drawing.Color.FromArgb(AppColors._lightRed);
                        _rectanglePanles[count - 1].BorderStyle = BorderStyle.None;
                        _rectanglePanles[0].BorderStyle = BorderStyle.None;
                    }
                }
            }
        }

        /// <summary>
        /// Обновление данных в текстовых полях по указанному прямоугольнику.
        /// </summary>
        /// <param name="rectangle">Прямоугольник, в котором меняется значение.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            RectanglesTextBoxId.Text = rectangle.Id.ToString();
            RectanglesTextBoxX.Text = rectangle.Center.StoreX.ToString();
            RectanglesTextBoxY.Text = rectangle.Center.StoreY.ToString();
            RectanglesTextBoxWidth.Text = rectangle.Width.ToString();
            RectanglesTextBoxHeight.Text = rectangle.Height.ToString();

            // сброс цвета окошка для ввода при переключении между прямоугольниками
            RectanglesTextBoxX.BackColor = System.Drawing.Color.White;
            RectanglesTextBoxY.BackColor = System.Drawing.Color.White;
            RectanglesTextBoxWidth.BackColor = System.Drawing.Color.White;
            RectanglesTextBoxHeight.BackColor = System.Drawing.Color.White;
        }

        /// <summary>
        /// Очищает все текстовые поля со занчениями прямоугольника.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectanglesTextBoxId.Text = "";
            RectanglesTextBoxX.Text = "";
            RectanglesTextBoxY.Text = "";
            RectanglesTextBoxWidth.Text = "";
            RectanglesTextBoxHeight.Text = "";
        }

        /// <summary>
        /// Пользователь нажал на кнопку add.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButtonAdd_MouseDown(object sender, MouseEventArgs e)
        {
            RectanglesButtonAdd.Image = Properties.Resources.add_pressed;
        }

        /// <summary>
        /// Пользователь отпустил кнопку add.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButtonAdd_MouseUp(object sender, MouseEventArgs e)
        {
            RectanglesButtonAdd.Image = Properties.Resources.add;
        }

        /// <summary>
        /// Пользователь нажал на кнопку remove.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButtonRemove_MouseDown(object sender, MouseEventArgs e)
        {
            RectanglesButtonRemove.Image = Properties.Resources.remove_pressed;
        }

        /// <summary>
        /// Пользователь отпустил кнопку remove.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesButtonRemove_MouseUp(object sender, MouseEventArgs e)
        {
            RectanglesButtonRemove.Image = Properties.Resources.remove;
        }
    }
}
