using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ListItemsApp
{
    public partial class MainForm : Form
    {
        private List<Items> _items = new List<Items>();
        private Items _currentItem;

        public MainForm()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }



        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Items items = new Items("Name", "", 0, 0);

            _items.Add(items);

            NameItemsListBox.Items.Add($"{items.Name}");
        }

        /// <summary>
        /// Удаление выбранного товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            int index = NameItemsListBox.SelectedIndex;

            if (index != -1)
            {
                _items.RemoveAt(index);
                NameItemsListBox.Items.RemoveAt(index);
            }
            else { }
        }



        /// <summary>
        /// Заполнение текстовых полей данных по выбранному товару.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NameItemsListBox.SelectedIndex != -1)
            {
                _currentItem = _items[NameItemsListBox.SelectedIndex];

                NameTextBox.Text = _currentItem.Name;

                UpdateItemsInfo(_currentItem);
            }
            else
            {
                ClearRectangleInfo();
            }
        }

        /// <summary>
        /// Обновления данных в текстовых полях по выделенному товару.ы
        /// </summary>
        /// <param name="item">Выделенный товар.</param>
        private void UpdateItemsInfo(Items item)
        {
            NameTextBox.Text = item.Name;
            ManufacturerTextBox.Text = item.Manufacturer;
            CountTextBox.Text = item.Count.ToString();
            CategoryComboBox.SelectedIndex = item.Index;
        }

        /// <summary>
        /// Очищает все текстовые поля со занчениями данных товара.
        /// </summary>
        private void ClearRectangleInfo()
        {
            NameTextBox.Text = "";
            ManufacturerTextBox.Text = "";
            CountTextBox.Text = "";
            CategoryComboBox.SelectedIndex = 0;
        }



        /// <summary>
        /// Изменение названия товара вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (NameItemsListBox.SelectedIndex != -1)
            {
                _currentItem.Name = NameTextBox.Text;
                NameItemsListBox.Items[NameItemsListBox.SelectedIndex] = _currentItem.Name;
            }
        }

        /// <summary>
        /// Изменение название производителя вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManufacturerTextBox_Leave(object sender, EventArgs e)
        {
            if (NameItemsListBox.SelectedIndex != -1)
            {
                _currentItem.Manufacturer = ManufacturerTextBox.Text;
            }
        }

        /// <summary>
        /// Изменение количество товара на складе вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountTextBox_Leave(object sender, EventArgs e)
        {
            if (NameItemsListBox.SelectedIndex != -1)
            {
                try
                {
                    _currentItem.Count = int.Parse(CountTextBox.Text);
                    CountTextBox.BackColor = System.Drawing.Color.White;
                }
                catch
                {
                    CountTextBox.BackColor = ColorTranslator.FromHtml("#FFB6C1");
                    MessageBox.Show("Можно вводить только цифры !", "Ошибка!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Изменение категории товара вручную пользователем.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Убрать фокус с ComboBox чтобы не было синей подсветки
            this.ActiveControl = null;

            if (_currentItem != null)
            {
                _currentItem.Index = NameItemsListBox.SelectedIndex;
            }
        }



        /// <summary>
        /// Курсор находится в зоне кнопки Добавить товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPictureBox_MouseEnter(object sender, EventArgs e) => ScalePictureBox((PictureBox)sender, true);

        /// <summary>
        /// Курсор уходит из зоны кнопки Добавить товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPictureBox_MouseLeave(object sender, EventArgs e) => ScalePictureBox((PictureBox)sender, false);

        /// <summary>
        /// Курсор находится в зоне кнопки Удалить товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemPictureBox_MouseEnter(object sender, EventArgs e) => ScalePictureBox((PictureBox)sender, true);

        /// <summary>
        /// Курсор уходит из зоны кнопки Добавить товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemPictureBox_MouseLeave(object sender, EventArgs e) => ScalePictureBox((PictureBox)sender, false);

        /// <summary>
        /// Изменение размера PictureBox.
        /// </summary>
        /// <param name="pic"></param>
        /// <param name="shrink"></param>
        private void ScalePictureBox(PictureBox pic, bool shrink)
        {
            if (shrink)
            {
                pic.Width = (int)(pic.Width * 0.9);
                pic.Height = (int)(pic.Height * 0.9);
                pic.Left += (int)(pic.Width * 0.05);
                pic.Top += (int)(pic.Height * 0.05);
            }
            else
            {
                pic.Left -= (int)(pic.Width * 0.05);
                pic.Top -= (int)(pic.Height * 0.05);
                pic.Width = (int)(pic.Width / 0.9);
                pic.Height = (int)(pic.Height / 0.9);
            }
        }
    }
}
