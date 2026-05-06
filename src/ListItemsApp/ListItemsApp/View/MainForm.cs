using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

            // Изначально выбран английский язык интерфейса
            TranslateComboBox.SelectedIndex = 0;
        }


        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
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
        private void RemButton_Click(object sender, EventArgs e)
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
                    CountTextBox.BackColor = ColorTranslator.FromHtml(AppColors._error);
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
            if (_currentItem != null)
            {
                _currentItem.Index = NameItemsListBox.SelectedIndex;
            }
        }


        /// <summary>
        /// Выбор языка интерфейса, в зависимости от выбранного варианта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TranslateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Изменяем фокус на саму форму, чтобы убрать выделение текста
            this.ActiveControl = null;
        }
    }
}
