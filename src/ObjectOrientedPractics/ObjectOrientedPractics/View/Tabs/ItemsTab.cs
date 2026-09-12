using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _currentItem;


        public ItemsTab()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Добавление новой карточки товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsAdd_Click(object sender, EventArgs e)
        {
            Item item = new Item("Name", "Info", 0);

            _items.Add(item);

            listBoxItems.Items.Add($"{item.Name}");
        }

        /// <summary>
        /// Удаление выбраной карточки товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonItemsRemove_Click(object sender, EventArgs e)
        {
            int index = listBoxItems.SelectedIndex;

            if (index != -1)
            {
                _items.RemoveAt(index);
                listBoxItems.Items.RemoveAt(index);
            }
        }

        /// <summary>
        /// Заполнение полей выбранной карточки товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1)
            {
                _currentItem = _items[listBoxItems.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }
            else
            {
                ClearItemInfo();
            }
        }

        /// <summary>
        /// Обновить текст о товаре.
        /// </summary>
        /// <param name="item"></param>
        private void UpdateItemInfo(Item item)
        {
            textBoxSelectedItemId.Text = item.Id.ToString();
            textBoxSelectedItemCost.Text = item.Cost.ToString();
            textBoxSelectedItemName.Text = item.Name;
            textBoxSelectedItemDescription.Text = item.Info;
        }

        /// <summary>
        /// Очистить поля с информацией о товаре.
        /// </summary>
        private void ClearItemInfo()
        {
            textBoxSelectedItemId.Text = "";
            textBoxSelectedItemCost.Text = "";
            textBoxSelectedItemName.Text = "";
            textBoxSelectedItemDescription.Text = "";
        }

        /// <summary>
        /// Сохранение изменений в строке с ценой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSelectedItemCost_Leave(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!float.TryParse(textBoxSelectedItemCost.Text, out float newCost))
            {
                textBoxSelectedItemCost.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Можно вводить только цифры и , !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertFloatOnSize(newCost, 100000, "bool"))
            {
                _currentItem.Cost = newCost;
                ReplaceLineInListBox();
                textBoxSelectedItemCost.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxSelectedItemCost.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Число не должно быть отрицательным и больше 100000 !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение названия.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSelectedItemName_Leave(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertStringOnLength(textBoxSelectedItemName.Text, 200, "bool"))
            {
                _currentItem.Name = textBoxSelectedItemName.Text;
                ReplaceLineInListBox();
                textBoxSelectedItemName.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxSelectedItemName.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле не должно быть пустым и больше 200 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Сохранение описания.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSelectedItemDescription_Leave(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex == -1)
            {
                MessageBox.Show("Сначала выберите товар!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValueValidator.AssertStringOnLength(textBoxSelectedItemDescription.Text, 1000, "bool"))
            {
                _currentItem.Info = textBoxSelectedItemDescription.Text;
                ReplaceLineInListBox();
                textBoxSelectedItemDescription.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxSelectedItemDescription.BackColor = ColorTranslator.FromHtml(AppColors._error);
                MessageBox.Show("Поле не должно быть пустым и больше 1000 символов !", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обновить название товара в списке товаров.
        /// </summary>
        private void ReplaceLineInListBox()
        {
            listBoxItems.Items[listBoxItems.SelectedIndex] = $"{_currentItem.Name}";
        }
    }
}
